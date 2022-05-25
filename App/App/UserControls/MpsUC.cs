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
using System.Windows.Input;

namespace App.UserControls
{
    public partial class MpsUC : UserControl
    {
        private ItemDao itemDao;
        private OrderDao orderDao;
        private List<Item> itemFinishedResource;
        private List<Item> itemFinished;
        private List<Order> orderSources;
        private List<Order> orderFilter;
        private List<int> idChecked;
        private int itemCount;
        public MpsUC()
        {
            InitializeComponent();

            itemDao = new ItemDao();
            orderDao = new OrderDao();
        }

        #region Events

        private void MpsUC_Load(object sender, EventArgs e)
        {
            LoadFirst();

            SetupListView();

            SetUpdateFilter();
        }

        private void LvItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column - 1)
            {
                case 0:
                    {
                        orderFilter = orderSources.Where(x => idChecked.Any(i => i == x.ItemId) || idChecked.Count == 0).OrderBy(x => x.Item.Name).ToList();
                        GenerateItem();
                        break;
                    }
                case 1:
                    {
                        orderFilter = orderSources.Where(x => idChecked.Any(i => i == x.ItemId) || idChecked.Count == 0).OrderBy(x => x.Week).ToList();
                        GenerateItem();
                        break;
                    }
                case 2:
                    {
                        orderFilter = orderSources.Where(x => idChecked.Any(i => i == x.ItemId) || idChecked.Count == 0).OrderBy(x => x.Year).ToList();
                        GenerateItem();
                        break;
                    }
                default:
                    {
                        orderFilter = orderSources.Where(x => idChecked.Any(i => i == x.ItemId) || idChecked.Count == 0).OrderBy(x => x.Quantity).ToList();
                        GenerateItem();
                        break;
                    }
            }
        }

        private void CbItem_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            var item = cb.Tag as Item;

            if (idChecked.Any(x => x == item.Id))
            {
                idChecked.Remove(item.Id);
            }
            else
            {
                idChecked.Add(item.Id);
            }

            Filter();
            GenerateItem();
        }

        #endregion

        #region Methods

        private void Filter()
        {
            if (idChecked.Count == 0 || idChecked.Count == itemCount)
            {
                orderFilter = orderSources.ToList();
            }
            else
            {
                orderFilter = orderSources.Where(x => idChecked.Any(i => i == x.ItemId)).ToList();
            }
        }

        private void SetUpdateFilter()
        {
            foreach (var item in itemFinishedResource.Where(x => x.ItemTypeId == 1))
            {
                var cbItem = new CheckBox();

                cbItem.Text = item.Name;
                cbItem.Font = new Font("Consolas", 18, FontStyle.Regular);
                cbItem.Height = 40;
                cbItem.Cursor = System.Windows.Forms.Cursors.Hand;
                cbItem.Margin = new Padding(10, 0, 0, 0);
                cbItem.CheckStateChanged += CbItem_CheckStateChanged;
                cbItem.Tag = item;

                flpFilter.Controls.Add(cbItem);
            }
        }

        private void GenerateItem()
        {
            lvOrder.Items.Clear();
            int i = 1;
            lvOrder.Items.AddRange(orderFilter.Select(x => CreateItemRow(x, i++)).ToArray());
        }
        private ListViewItem CreateItemRow(Order itemOrder, int i)
        {

            var itemRow = new ListViewItem();
            itemRow.Text = i.ToString();
            itemRow.SubItems.Add(itemOrder.Item.Name);
            itemRow.SubItems.Add(itemOrder.Week.ToString());
            itemRow.SubItems.Add(itemOrder.Year.ToString());
            itemRow.SubItems.Add(itemOrder.Quantity.ToString());

            return itemRow;
        }

        private void SetupListView()
        {
            lvOrder.ColumnClick += LvItems_ColumnClick;

            lvOrder.Columns.Add(CreateHeaderColumn("#", 70));
            lvOrder.Columns.Add(CreateHeaderColumn("Name", 250));
            lvOrder.Columns.Add(CreateHeaderColumn("Week", 200));
            lvOrder.Columns.Add(CreateHeaderColumn("Year", 300));
            lvOrder.Columns.Add(CreateHeaderColumn("Quantity", 255));

            GenerateItem();
        }

        private void LoadFirst()
        {
            itemFinishedResource = itemDao.GetAll().Where(x => x.ItemTypeId == 1).ToList();
            itemFinished = itemFinishedResource.ToList();
            idChecked = new List<int>();
            itemCount = itemFinishedResource.Count;
            orderSources = orderDao.GetByItemIds(null);
            orderFilter = orderSources.ToList();
        }

        private ColumnHeader CreateHeaderColumn(string text, int width, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Center) =>
            new ColumnHeader() { Text = text, Width = width, TextAlign = horizontalAlignment };


        #endregion

    }
}
