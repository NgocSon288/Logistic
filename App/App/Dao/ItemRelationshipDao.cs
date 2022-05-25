using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dao
{
    public class ItemRelationshipDao
    {
        private AppDbContext db;

        private List<ItemRelationship> items;

        public ItemRelationshipDao()
        {
            if (db == null)
            {
                db = new AppDbContext();
            }

            items = db.ItemRelationships.ToList();
        }

        public ItemRelationship GetByParentAndChildId(int parentId, int childId)
        {
            return items.FirstOrDefault(x => x.ParentId == parentId && x.ChildId == childId);
        }
        public List<ItemRelationship> GetAll()
        {
            return items;
        }
    }
}
