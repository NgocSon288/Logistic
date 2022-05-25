using App.Dao;
using App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UserControls
{
    public partial class ScheduleUC : UserControl
    {
        private ItemDao itemDao;
        private OrderDao orderDao;
        private ItemRelationshipDao itemRelationshipDao;
        private List<Item> items;
        private List<Order> orderSource;
        private List<Schedule> orderFilter;
        private int itemIdSelected;
        private int weekSelected;
        private int yearSelected;


        public ScheduleUC()
        {
            InitializeComponent();

            itemDao = new ItemDao();
            orderDao = new OrderDao();
            itemRelationshipDao = new ItemRelationshipDao();
        }

        #region Events

        private void ScheduleUC_Load(object sender, EventArgs e)
        {
            LoadFirst();
            SetupListView();

            cbbItem.DataSource = items;
            cbbItem.DisplayMember = "Name";

        }
        private void btnDoReport_Click(object sender, EventArgs e)
        {
            var weeks = nudWeeks.Value;


        }

        private void btnExportExc_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "xls";
            saveFile.Filter = "Excel |*.xls";
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;
            saveFile.Title = "Where do you want to save the file?";
            saveFile.InitialDirectory = @"Desktop";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string folderName = saveFile.FileName;

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }


                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "Week";
                xlWorkSheet.Cells[1, 2] = "Year";
                xlWorkSheet.Cells[1, 3] = "Gross Requirement";
                xlWorkSheet.Cells[1, 4] = "Schedule Receipt";
                xlWorkSheet.Cells[1, 5] = "Net Requirement";
                xlWorkSheet.Cells[1, 6] = "Project On Hand";
                xlWorkSheet.Cells[1, 7] = "Planned Order Receipt";
                xlWorkSheet.Cells[1, 8] = "Planned Order Release";

                var count = lvItemReport.Items.Count;

                for (int i = 0; i < count; i++)
                {
                    var item = lvItemReport.Items[i];

                    xlWorkSheet.Cells[i + 2, 1] = item.SubItems[0].Text;
                    xlWorkSheet.Cells[i + 2, 2] = item.SubItems[1].Text;
                    xlWorkSheet.Cells[i + 2, 3] = item.SubItems[2].Text;
                    xlWorkSheet.Cells[i + 2, 4] = item.SubItems[3].Text;
                    xlWorkSheet.Cells[i + 2, 5] = item.SubItems[4].Text;
                    xlWorkSheet.Cells[i + 2, 6] = item.SubItems[5].Text;
                    xlWorkSheet.Cells[i + 2, 7] = item.SubItems[6].Text;
                    xlWorkSheet.Cells[i + 2, 8] = item.SubItems[7].Text;
                }



                xlWorkBook.SaveAs(folderName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                MessageBox.Show("Excel file created , you can find the file " + folderName);
            }
        }
        private void btnSaveOrderReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "xls";
            saveFile.Filter = "Excel |*.xls";
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;
            saveFile.Title = "Where do you want to save the file?";
            saveFile.InitialDirectory = @"Desktop";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string folderName = saveFile.FileName;

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }


                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "Item";
                xlWorkSheet.Cells[1, 2] = "Week";
                xlWorkSheet.Cells[1, 3] = "Quantity";

                var count = lvItemReport.Items.Count;

                for (int i = 0; i < count; i++)
                {
                    var item = lvOrderReport.Items[i];

                    xlWorkSheet.Cells[i + 2, 1] = item.SubItems[0].Text;
                    xlWorkSheet.Cells[i + 2, 2] = item.SubItems[1].Text;
                    xlWorkSheet.Cells[i + 2, 3] = item.SubItems[2].Text;
                }



                xlWorkBook.SaveAs(folderName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                MessageBox.Show("Excel file created , you can find the file " + folderName);
            }
        }

        private void cbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = cbbItem.SelectedItem as Item;
            itemIdSelected = itemSelected.Id;

            // Setup info
            lblLotsize.Text = itemSelected.LotSize.ToString();
            lblSafetyStock.Text = itemSelected.SafetyStock.ToString();
            lblLeadtime.Text = itemSelected.LeadTime.ToString();
            lblProjectOnhand.Text = itemSelected.Inventory.ToString();
            lblLotsize.Text = itemSelected.LotSize.ToString();

            // Setup Listview
            orderFilter = OrderFilterCondition();
            GenerateItem();
        }


        private void nudWeeks_ValueChanged(object sender, EventArgs e)
        {
            if (weekSelected == (int)nudWeeks.Value)
            {
                return;
            }

            weekSelected = (int)nudWeeks.Value;
            orderFilter = OrderFilterCondition();
            GenerateItem();
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            if (yearSelected == (int)nudYear.Value)
            {
                return;
            }
            yearSelected = (int)nudYear.Value;
            orderFilter = OrderFilterCondition();
            GenerateItem();
        }

        #endregion

        #region Methods


        private void SetupListView()
        {
            lvItemReport.Columns.Add(CreateHeaderColumn("Week", 100));
            lvItemReport.Columns.Add(CreateHeaderColumn("Year", 130));
            lvItemReport.Columns.Add(CreateHeaderColumn("Gross Requirement", 180));
            lvItemReport.Columns.Add(CreateHeaderColumn("Schedule Receipt", 180));
            lvItemReport.Columns.Add(CreateHeaderColumn("Net Rerequiment", 180));
            lvItemReport.Columns.Add(CreateHeaderColumn("Project on Hand", 180));
            lvItemReport.Columns.Add(CreateHeaderColumn("Planned Order Receipt", 180));
            lvItemReport.Columns.Add(CreateHeaderColumn("Planned Order Release", 180));


            lvOrderReport.Columns.Add(CreateHeaderColumn("Item", 200));
            lvOrderReport.Columns.Add(CreateHeaderColumn("Week", 200));
            lvOrderReport.Columns.Add(CreateHeaderColumn("Quantity", 200));

            GenerateItem();
        }

        private List<Schedule> OrderFilterCondition()
        {
            var schedules = orderSource
                .Where(x => x.Year == yearSelected && x.Week <= weekSelected)
                .Select(x => OrderToSchedule(x))
                .Where(x => x.Children.Any(i => i == itemIdSelected))
                .ToList();

            return Distinct(schedules);
        }

        private List<Schedule> Distinct(List<Schedule> schedules)
        {
            var scheduleDistinct = new List<Schedule>();

            foreach (var item in schedules)
            {
                if (!scheduleDistinct.Any(x => x.Id != item.Id && x.Week == item.Week && x.Year == item.Year))
                {
                    scheduleDistinct.Add(item);
                }
                else
                {
                    var itemScheduleExists = scheduleDistinct.FirstOrDefault(x => x.Week == item.Week && x.Year == item.Year);
                    itemScheduleExists.Demand += item.Demand;
                }
            }

            return scheduleDistinct;
        }

        private void GenerateItem()
        {
            lvItemReport.Items.Clear();
            //var genderList = new List<ListViewItem>();
            var scheduleLs = new List<Schedule>();

            for (int i = 0; i <= weekSelected; i++)
            {
                var item = orderFilter.FirstOrDefault(x => x.Week == i);

                if (item == null)
                {
                    item = new Schedule()
                    {
                        Week = i,
                        Year = yearSelected
                    };
                }

                scheduleLs.Add(item);

            }

            // Consider
            ConsideringLogistic(scheduleLs);

            lvItemReport.Items.AddRange(scheduleLs.Select(x => CreateItemRow(x)).ToArray());
            lvOrderReport.Items.AddRange(scheduleLs.Select(x => CreateItemRow2(x)).ToArray());
        }

        private void ConsideringLogistic(List<Schedule> scheduleLs)
        {
            var offsetWeek = 3; // TODO: From F1 -> WA -> W1, need to find
            var leadtime = 2;   // TODO: get leadtime of selected Item
            var pohInit = Int32.Parse(lblProjectOnhand.Text);
            var safe = Int32.Parse(lblSafetyStock.Text);

            for (int i = 1; i <= weekSelected; i++)
            {
                var item = scheduleLs[i];
                var gross = item.Demand;

                // Project On Hand
                if (i % 4 != 0)
                {
                    //item.ProjectOnHand = pohInit;
                    scheduleLs[i - (offsetWeek - leadtime)].ProjectOnHand = pohInit;
                }

            }
        }

        private ListViewItem CreateItemRow(Schedule itemOrder)
        {
            var itemRow = new ListViewItem();
            itemRow.Text = itemOrder.Week.ToString();
            itemRow.SubItems.Add(itemOrder.Demand.ToString());
            itemRow.SubItems.Add(itemOrder.Demand.ToString());    // Gross Requiment = Demand
            itemRow.SubItems.Add(itemOrder.ScheduleReceipt.ToString());    // Schedule Receipt
            itemRow.SubItems.Add(itemOrder.NetRequiment.ToString());    // Net Requiment
            itemRow.SubItems.Add(itemOrder.ProjectOnHand.ToString());
            itemRow.SubItems.Add(itemOrder.PlannedOrderReceipt.ToString());    // Planned Order Rece
            itemRow.SubItems.Add(itemOrder.PlannedOrderRelease.ToString());    // Planned Order Release

            return itemRow;
        }

        private ListViewItem CreateItemRow2(Schedule schedule)
        {
            var itemRow = new ListViewItem();
            itemRow.Text = 1.ToString();
            itemRow.SubItems.Add(0.ToString());
            itemRow.SubItems.Add(0.ToString());     

            return itemRow;
        }

        private void LoadFirst()
        {
            items = itemDao.GetAll().Where(x => x.ItemTypeId != 1).ToList();

            itemIdSelected = items[0].Id;
            weekSelected = (int)nudWeeks.Value;
            yearSelected = (int)nudYear.Value;

            orderSource = orderDao.GetAll();
            orderFilter = OrderFilterCondition();

        }
        private ColumnHeader CreateHeaderColumn(string text, int width, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Center) =>
            new ColumnHeader() { Text = text, Width = width, TextAlign = horizontalAlignment };

        private Schedule OrderToSchedule(Order x)
        {
            return new Schedule()
            {
                Id = x.Item.Id,
                Week = x.Week.Value,
                Year = x.Year.Value,
                GrossRequirement = 0,
                ScheduleReceipt = 0,
                NetRequiment = 0,
                ProjectOnHand = Int32.Parse(lblProjectOnhand.Text),
                PlannedOrderReceipt = 0,
                PlannedOrderRelease = 0,
                Children = itemDao.GetListChildrenId(x.Item.Id),
                Demand = GetDemandByOrder(x)
            };
        }

        private int GetDemandByOrder(Order x)
        {
            var quantity = x.Quantity.Value;
            var itemParent = x.Item;                              // F1, F2
            var itemSelected = itemDao.GetById(itemIdSelected);    // W1,W3,...

            if (itemSelected.ItemTypeId == 2)
            {
                var rel = itemRelationshipDao.GetByParentAndChildId(itemParent.Id, itemSelected.Id);
                return rel == null ? 0 : rel.Value.Value * quantity;
            }

            var itemMiddle = itemDao.GetItemMiddle(itemParent.Id, itemSelected.Id);

            if (itemMiddle == null)
                return 0;

            var rel1 = itemRelationshipDao.GetByParentAndChildId(itemParent.Id, itemMiddle.Id);
            var rel2 = itemRelationshipDao.GetByParentAndChildId(itemMiddle.Id, itemSelected.Id);

            if (rel1 == null || rel2 == null)
            {
                return 0;
            }

            return rel1.Value.Value * rel2.Value.Value * x.Quantity.Value;

        }

        #endregion

        
    }
}
