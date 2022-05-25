using App.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UserControls
{
    public partial class ItemsUC : UserControl
    {
        ItemDao itemdao;
        public ItemsUC()
        {
            InitializeComponent();
            itemdao = new ItemDao();
        }

        #region Events
        private void ItemsUC_Load(object sender, EventArgs e)
        {
            SetupListView();
        }


        private void LvItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column - 1)
            {
                case 0:
                    {
                        GenerateItem(itemdao.GetAll().OrderBy(x => x.Name).ToList());
                        break;
                    }
                case 1:
                    {
                        GenerateItem(itemdao.GetAll().OrderBy(x => x.ItemTypeId).ToList());
                        break;
                    }
                case 2:
                    {
                        GenerateItem(itemdao.GetAll().OrderBy(x => x.LotSize).ToList());
                        break;
                    }
                case 4:
                    {
                        GenerateItem(itemdao.GetAll().OrderBy(x => x.LeadTime).ToList());
                        break;
                    }
                case 5:
                    {
                        GenerateItem(itemdao.GetAll().OrderBy(x => x.SafetyStock).ToList());
                        break;
                    }
                default:
                    {
                        GenerateItem(itemdao.GetAll().OrderBy(x => x.Inventory).ToList());
                        break;
                    }
            }
        }

        #endregion

        #region Methods

        private void SetupListView()
        {
            lvItems.ColumnClick += LvItems_ColumnClick;

            lvItems.Columns.Add(CreateHeaderColumn("#", 50));
            lvItems.Columns.Add(CreateHeaderColumn("Name", 120));
            lvItems.Columns.Add(CreateHeaderColumn("Type", 200));
            lvItems.Columns.Add(CreateHeaderColumn("Lotsize", 120));
            lvItems.Columns.Add(CreateHeaderColumn("Lotsize Rule", 200));
            lvItems.Columns.Add(CreateHeaderColumn("Lead Time", 140));
            lvItems.Columns.Add(CreateHeaderColumn("Safety Stock", 180));
            lvItems.Columns.Add(CreateHeaderColumn("Project on Hand", 240));

            GenerateItem(itemdao.GetAll());
        }

        private void GenerateItem(List<Item> items)
        {
            lvItems.Items.Clear();
            var count = items.Count;
            for (int i = 0; i < count; i++)
            {
                lvItems.Items.Add(CreateItemRow(items[i], i + 1));
            }
        }

        private ColumnHeader CreateHeaderColumn(string text, int width, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Center) =>
            new ColumnHeader() { Text = text, Width = width, TextAlign = horizontalAlignment };

        private ListViewItem CreateItemRow(Item item, int i)
        {
            var itemRow = new ListViewItem();

            itemRow.Text = i.ToString();
            itemRow.SubItems.Add(item.Name);
            itemRow.SubItems.Add(item.ItemType.Name);
            itemRow.SubItems.Add(item.LotSize.ToString());
            itemRow.SubItems.Add(item.LotSize==0?"lot for lot":"multiple");
            itemRow.SubItems.Add(item.LeadTime.ToString());
            itemRow.SubItems.Add(item.SafetyStock.ToString());
            itemRow.SubItems.Add(item.Inventory.ToString());

            return itemRow;
        }

        #endregion

        #region New Feature

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
