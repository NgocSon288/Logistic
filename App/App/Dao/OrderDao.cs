using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.Dao
{
    public class OrderDao
    {
        private AppDbContext db;

        private List<Order> itemSource;

        public OrderDao()
        {
            if (db == null)
            {
                db = new AppDbContext();
            }

            RefeshSource();
        }

        public void RefeshSource()
        {
            itemSource = db.Orders.ToList();
        }

        public List<Order> GetByItemId(int itemId)
        {
            return itemSource.Where(x => x.ItemId == itemId).ToList();
        }

        public List<Order> GetAll()
        {
            return itemSource.ToList();
        }

        public List<Order> GetByItemIds(List<int> ids)
        {
            if (ids == null || ids.Count == 0)
            {
                return itemSource.ToList();
            }

            var result = new List<Order>();
            foreach (var item in ids)
            {
                result.AddRange(GetByItemId(item));
            }

            return result;
        }
    }
}
