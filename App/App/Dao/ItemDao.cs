using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.Dao
{
    public class ItemDao
    {
        private AppDbContext db;

        public ItemDao()
        {
            if (db == null)
            {
                db = new AppDbContext();
            }
        }

        public List<Item> GetAll()
        {
            return db.Items.ToList();
        }
        public Item GetById(int id)
        {
            return db.Items.FirstOrDefault(x => x.Id == id);
        }

        public Item GetItemMiddle(int parentId, int childId)
        {
            //var items = db.Items.ToList();
            //foreach (var item in items)
            //{
            //    if (item.Id == 32)
            //    {
            //        var a = 1;
            //    }
            //}

            //return null;
            return db.Items.FirstOrDefault(x => x.ItemRelationships.Any(p => p.ParentId == parentId) && x.ItemRelationships1.Any(p => p.ChildId == childId));
        }

        public List<int> GetListChildrenId(int idType_1)
        {
            var items = db.Items.ToList();
            var result = new List<int>();

            var ids_Type_2 = items.Where(x => x.ItemRelationships.Any(i => i.ParentId == idType_1)).Select(x => x.Id).ToList();
            result.AddRange(ids_Type_2);

            foreach (var item in ids_Type_2)
            {
                result.AddRange(items.Where(x => x.ItemRelationships.Any(i => i.ParentId == item)).Select(x => x.Id).ToList());
            }

            return result;
        }
    }
}
