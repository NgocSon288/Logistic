using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dao
{
    public class ScheduleDao
    {
        private AppDbContext db;

        public ScheduleDao()
        {
            if (db == null)
            {
                db = new AppDbContext();
            }
        }

        public Schedule GetScheduleOrderByItemId(int itemId, int year)
        {
            var item = db.Items.FirstOrDefault(x => x.Id == itemId);

            if (item.ItemTypeId == 2)
            {
                return GetScheduleOrderByItemIdLevel2(itemId, year);
            }

            return GetScheduleOrderByItemIdLevel3(itemId, year);
        }

        /// <summary>
        /// Get All Schedule by item Id
        /// Only Level 2: Assembly
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public Schedule GetScheduleOrderByItemIdLevel2(int itemId, int year)
        {
            var item = db.Items.FirstOrDefault(x => x.Id == itemId);
            var originOrders = db.Orders.Where(x => x.Year == year).ToList();
            Dictionary<(int, int), int> relationShipDictionary = new Dictionary<(int, int), int>(); // Số lượng phần tử là số lượng của loại order
            Dictionary<(int, int), int> inventories = new Dictionary<(int, int), int>(); // Danh sách các Inventory theo của F theo hệ quy chiếu W
            List<int> parentId = new List<int>();

            var orders = originOrders.Where(x =>
            {
                var rs = x.Item.ItemRelationships1.FirstOrDefault(r => r.ChildId == itemId);
                if (!relationShipDictionary.ContainsKey((x.ItemId.Value, itemId)) && rs != null)
                {
                    relationShipDictionary.Add((x.ItemId.Value, itemId), rs.Value.Value);
                    inventories.Add((x.ItemId.Value, itemId), x.Item.Inventory.Value * x.Item.ItemRelationships1.FirstOrDefault(r1 => r1.ChildId == itemId).Value.Value);
                    //x.Quantity.Value * x.Item.ItemRelationships1.FirstOrDefault(r1 => r1.ChildId == itemId).Value.Value);
                }
                if (rs != null)
                {
                    parentId.Add(rs.ParentId);
                    return true;
                }

                return false;
            }).ToList();

            var d = 0;
            var orderReference = orders.Select(x => new OrderCus()
            {
                Id = x.Id,
                ItemId = itemId,
                ParentId = parentId[d++],
                Quantity = x.Quantity.Value * relationShipDictionary[(x.ItemId.Value, itemId)],
                Week = x.Week - x.Item.LeadTime,
                Year = x.Year
            }).ToList();

            var schedult = new Schedule()
            {
                Orders = orderReference,
                Inventories = inventories,
                item = new ItemCus()
                {
                    Id = item.Id,
                    LeadTime = item.LeadTime,
                    Inventory = item.Inventory,
                    SafetyStock = item.SafetyStock,
                    Name = item.Name,
                    ItemType = item.ItemType,
                    ItemRelationships = item.ItemRelationships,
                    ItemRelationships1 = item.ItemRelationships1,
                    ItemTypeId = item.ItemTypeId,
                    LotSize = item.LotSize
                }
            };

            return schedult;
        }

        /// <summary>
        /// Get All Schedule by item Id
        /// Only Level 3: Material
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public Schedule GetScheduleOrderByItemIdLevel3(int itemId, int year)
        {
            var item = db.Items.FirstOrDefault(x => x.Id == itemId);
            var originOrders = db.Orders.Where(x => x.Year == year).ToList();
            Dictionary<(int, int), int> relationShipDictionary = new Dictionary<(int, int), int>(); // Số lượng phần tử là số lượng của loại order
            Dictionary<(int, int), int> inventories = new Dictionary<(int, int), int>(); // Danh sách các Inventory theo của F theo hệ quy chiếu W

            List<int> parentId = new List<int>();

            var orders = originOrders.Where(x =>
            {
                var rs2 = x.Item.ItemRelationships1.FirstOrDefault(r => r.Item.ItemRelationships1.Any(rr => rr.ChildId == itemId));     // WA
                if (rs2 == null)
                    return false;
                var rs3 = rs2.Item.ItemRelationships1.FirstOrDefault(r => r.ParentId == rs2.ChildId);
                if (!relationShipDictionary.ContainsKey((x.ItemId.Value, itemId)) && rs2 != null)
                {
                    var multipRefer = rs2.Value.Value * rs3.Value.Value;
                    relationShipDictionary.Add((x.ItemId.Value, itemId), multipRefer);
                    inventories.Add((x.ItemId.Value, itemId),
                        x.Item.Inventory.Value * multipRefer);
                }

                if (rs2 != null)
                {
                    parentId.Add(rs2.ParentId);
                    return true;
                }

                return false;
            }).ToList();

            var d = 0;
            var items = db.Items.ToList();
            var itemsParent = items.FirstOrDefault(x => x.ItemRelationships1.Any(i => i.ParentId == (parentId.Count == 0 ? 0 : parentId[0])))?.ItemRelationships1;
            var middleItem = itemsParent?.FirstOrDefault(x => x.Item.ItemRelationships1.Any(r => r.ChildId == itemId));

            var orderReference = orders.Select(x => new OrderCus()
            {
                Id = x.Id,
                ItemId = itemId,
                ParentId = parentId[d++],
                Quantity = x.Quantity.Value * relationShipDictionary[(x.ItemId.Value, itemId)],
                Week = x.Week - x.Item.LeadTime,// trừ leadtime của trung giang
                Year = x.Year
            }).ToList();

            var schedult = new Schedule()
            {
                Orders = orderReference,
                Inventories = inventories,
                item = new ItemCus()
                {
                    Id = item.Id,
                    LeadTime = item.LeadTime,
                    LeadTime2 = middleItem == null ? 0 : middleItem.Item.LeadTime.Value,
                    Inventory = item.Inventory,
                    SafetyStock = item.SafetyStock,
                    Name = item.Name,
                    ItemType = item.ItemType,
                    ItemRelationships = item.ItemRelationships,
                    ItemRelationships1 = item.ItemRelationships1,
                    ItemTypeId = item.ItemTypeId,
                    LotSize = item.LotSize
                }
            };

            return schedult;
        }
    }
}
