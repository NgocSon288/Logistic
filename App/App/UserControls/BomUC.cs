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
    public partial class BomUC : UserControl
    {
        ItemDao itemdao;
        ItemRelationshipDao itemRelationshipDao;
        private List<ItemRelationship> itemResources;
        private List<ItemRelationship> items;
        private List<Item> itemOrigin;
        private List<int> idChecked;
        private int itemCount;
        public BomUC()
        {
            InitializeComponent();
            itemdao = new ItemDao();
            itemRelationshipDao = new ItemRelationshipDao();
        }

        #region Events

        private void BomUC_Load(object sender, EventArgs e)
        {
            LoadFirst();

            SetupListView();
            SetUpTreeView();
            SetUpdateFilter();
        }

        private void LvItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    {
                        items = items.OrderBy(x => x.Id).ToList();
                        GenerateItem();
                        break;
                    }
                case 1:
                    {
                        items = items.OrderBy(x => x.Item.Name).ToList();
                        GenerateItem();
                        break;
                    }
                case 2:
                    {

                        items = items.OrderBy(x => x.Item1.Name).ToList();
                        GenerateItem();
                        break;
                        //var itemTemps = items.Select(x => new
                        //{
                        //    Item = x,
                        //    ParentName = string.Join(",", x.ItemRelationships.Select(i => i.Item.Name))
                        //})
                        //    .OrderByDescending(x => x.ParentName)
                        //    .ToList();

                        //items = items.OrderByDescending(x => string.Join("", x.ItemRelationships.Select(i => i.Item.Name))).ToList();


                        //GenerateItem();
                        //break;
                    }
                default:
                    {
                        //items = items.OrderBy(x => x.Value).ToList();
                        //GenerateItem();

                        items = items.OrderBy(x => x.Value).ToList();
                        GenerateItem();
                        break;
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

        private void LoadFirst()
        {
            itemResources = itemRelationshipDao.GetAll();
            items = itemResources.ToList();
            itemOrigin = itemdao.GetAll();
            idChecked = new List<int>();
            idChecked = new List<int>();
            itemCount = itemResources.Count;
        }

        private void SetupListView()
        {
            lvItems.ColumnClick += LvItems_ColumnClick;

            lvItems.Columns.Add(CreateHeaderColumn("Id", 70));
            lvItems.Columns.Add(CreateHeaderColumn("Name", 250));
            lvItems.Columns.Add(CreateHeaderColumn("Parent", 300));
            lvItems.Columns.Add(CreateHeaderColumn("Value", 200));

            GenerateItem();
        }

        private void Filter()
        {
            if (idChecked.Count == 0 || idChecked.Count == itemCount)
            {
                items = itemResources.ToList();
            }
            else
            {
                items = itemResources.Where(x => idChecked.Any(i => x.Item.Id == i || x.Item1.Id == i)).ToList();
            }
        }
        private void SetUpTreeView()
        {
            var itemFinished = itemOrigin.Where(x => x.ItemTypeId == 1).ToList();       // Finished Item

            foreach (var fitem in itemFinished)
            {
                var nodeFinish = new TreeNode(fitem.Name + ":1");

                var childrenAssembly = fitem.ItemRelationships1.Select(x => x.Item).ToList(); // Assembly Item
                foreach (var aitem in childrenAssembly)
                {
                    var nodeAssembly = new TreeNode(aitem.Name + ":" + aitem.ItemRelationships.FirstOrDefault(x=>x.ParentId==fitem.Id&&x.ChildId==aitem.Id)?.Value);
                    nodeFinish.Nodes.Add(nodeAssembly);

                    var childrenMaterial = aitem.ItemRelationships1.Select(x => x.Item).ToList();   // Material Item
                    foreach (var mitem in childrenMaterial)
                    {
                        var nodeMaterial = new TreeNode(mitem.Name + ":" + mitem.ItemRelationships.FirstOrDefault(x => x.ParentId == aitem.Id && x.ChildId == mitem.Id)?.Value);
                        nodeAssembly.Nodes.Add(nodeMaterial);
                    }
                }

                tvBom.Nodes.Add(nodeFinish);
            }
        }

        private void SetUpdateFilter()
        {
            foreach (var item in itemOrigin)
            {
                var cbItem = new CheckBox();

                cbItem.Text = item.Name;
                cbItem.Font = new Font("Consolas", 18, FontStyle.Regular);
                cbItem.Height = 40;
                cbItem.Cursor = Cursors.Hand;
                cbItem.Margin = new Padding(10, 0, 0, 0);
                cbItem.CheckStateChanged += CbItem_CheckStateChanged;
                cbItem.Tag = item;

                flpFilter.Controls.Add(cbItem);
            }
        }

        private void GenerateItem()
        {
            lvItems.Items.Clear();
            lvItems.Items.AddRange(items.Select(x => CreateItemRow(x)).ToArray());
        }

        private ColumnHeader CreateHeaderColumn(string text, int width, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Center) =>
            new ColumnHeader() { Text = text, Width = width, TextAlign = horizontalAlignment };
        private ListViewItem CreateItemRow(ItemRelationship item)
        {

            var itemRow = new ListViewItem();
            itemRow.Text = item.Id.ToString();
            itemRow.SubItems.Add(item.Item.Name);
            itemRow.SubItems.Add(item.Item1.Name);
            itemRow.SubItems.Add(item.Value.ToString());

            return itemRow;
        }
        //private ListViewItem CreateItemRow(Item item)
        //{

        //    var itemRow = new ListViewItem();
        //    itemRow.Text = item.Id.ToString();
        //    itemRow.SubItems.Add(item.Name);
        //    itemRow.SubItems.Add(string.Join(",", item.ItemRelationships.Select(x => x.Item1.Name)));
        //    //itemRow.SubItems.Add(item.);

        //    return itemRow;
        //}
        #endregion

    }
}

// Đưa vào danh sách Checked rồi Filter theo danh sách đó