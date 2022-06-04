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
        private ScheduleDao scheduleDao;
        private ItemRelationshipDao itemRelationshipDao;
        private List<Item> items;
        private List<Order> orderSource;
        private Schedule schedule;
        private int itemIdSelected;
        private int weekSelected;
        private int yearSelected;


        public ScheduleUC()
        {
            InitializeComponent();
            scheduleDao = new ScheduleDao();
            itemDao = new ItemDao();
            orderDao = new OrderDao();
            itemRelationshipDao = new ItemRelationshipDao();
        }

        #region Events

        private void ScheduleUC_Load(object sender, EventArgs e)
        {
            LoadFirst();

            cbbItem.DataSource = items;
            cbbItem.DisplayMember = "Name";
            SetupListView();

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
            try
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

                    var count = lvOrderReport.Items.Count;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            lblLotForLot.Text = itemSelected.LotSize == 0 ? "Lot for lot" : "Multiple";

            // Setup Listview 
            GenerateItem();
        }


        private void nudWeeks_ValueChanged(object sender, EventArgs e)
        {
            if (weekSelected == (int)nudWeeks.Value)
            {
                return;
            }

            weekSelected = (int)nudWeeks.Value;
            GenerateItem();
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            if (yearSelected == (int)nudYear.Value)
            {
                return;
            }
            yearSelected = (int)nudYear.Value;
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
                //.Where(x => x.Children.Any(i => i == itemIdSelected))
                .ToList();

            return Distinct(schedules);
        }

        private List<Schedule> Distinct(List<Schedule> schedules)
        {
            //var scheduleDistinct = new List<Schedule>();

            //foreach (var item in schedules)
            //{
            //    if (!scheduleDistinct.Any(x => x.Id != item.Id && x.Week == item.Week && x.Year == item.Year))
            //    {
            //        scheduleDistinct.Add(item);
            //    }
            //    else
            //    {
            //        var itemScheduleExists = scheduleDistinct.FirstOrDefault(x => x.Week == item.Week && x.Year == item.Year);
            //        itemScheduleExists.Demand += item.Demand;
            //    }
            //}

            //return scheduleDistinct;
            return null;
        }

        private void GenerateItem()
        {
            lvItemReport.Items.Clear();
            lvOrderReport.Items.Clear();
            schedule = scheduleDao.GetScheduleOrderByItemId((cbbItem.SelectedItem as Item).Id, yearSelected);
            var orders = schedule.Orders;
            var f_refer_wa = schedule.Inventories;
            var f_refer_wa_Count = f_refer_wa.Count;
            // Item
            var uniqueItem = schedule.item;
            var lotSize = uniqueItem.LotSize;
            var parentIds = f_refer_wa.Keys.Select(x => x.Item1).ToList();

            var itemRendersReport = new List<ItemReport>();
            var itemRendersOrder = new List<ItemReport>();

            for (int i = 0; i <= weekSelected; i++)
            {
                var item = orders.FirstOrDefault(x => x.Week == i);

                if (item != null)
                {
                    var gross = 0;
                    for (int j = 0; j < f_refer_wa_Count; j++)
                    {
                        var g = orders.FirstOrDefault(o => o.Week == i && parentIds[j] == o.ParentId).Quantity.Value - f_refer_wa[(parentIds[j], item.ItemId.Value)];
                        f_refer_wa[(parentIds[j], item.ItemId.Value)] = g > 0 ? 0 : -g;

                        gross += g > 0 ? g : 0;
                    }


                    // Gross > 0 => cần net tùy theo SS
                    var net = gross - (uniqueItem.Inventory - uniqueItem.SafetyStock);
                    net = net > 0 ? net : 0;

                    // Inventory
                    var inven = net + uniqueItem.Inventory - gross;

                    // Update Invent
                    uniqueItem.Inventory = inven;


                    if (uniqueItem.ItemTypeId == 2)
                    {
                        itemRendersReport.Add(new ItemReport()
                        {
                            Week = i,
                            Year = yearSelected,
                            Gross = gross < 0 ? 0 : gross,
                            NetRequirement = net.Value,
                            PlannedOrderRelease = 0,
                            ProjectOnHand = lotSize == 0 ? inven.Value : 0,
                            PlannedOrderReceipt = net.Value,
                            SchedultReceipt = 0
                        });
                    }
                    else if (uniqueItem.ItemTypeId == 3)
                    {
                        itemRendersReport.Add(new ItemReport()
                        {
                            Week = i,
                            Year = yearSelected,
                            Gross = 0,          // always
                            NetRequirement = 0,
                            PlannedOrderReceipt = 0,
                            PlannedOrderRelease = 0,
                            ProjectOnHand = lotSize == 0 ? uniqueItem.Inventory.Value : 0,
                            SchedultReceipt = 0
                        });
                        itemRendersReport[i - uniqueItem.LeadTime2].Gross = gross;
                        itemRendersReport[i - uniqueItem.LeadTime2].NetRequirement = net.Value;
                        itemRendersReport[i - uniqueItem.LeadTime2].ProjectOnHand = inven.Value;
                        if (lotSize == 0)
                        {
                            //itemRendersReport[i - uniqueItem.LeadTime2].SchedultReceipt = net.Value;
                            itemRendersReport[i - uniqueItem.LeadTime2].SchedultReceipt = 0; 
                        }
                        else
                        {
                            var countk = Math.Ceiling((double)net.Value / lotSize.Value);
                            //itemRendersReport[i - uniqueItem.LeadTime2].SchedultReceipt = (int)(lotSize * countk);
                            itemRendersReport[i - uniqueItem.LeadTime2].SchedultReceipt = 0;
                            itemRendersReport[i - uniqueItem.LeadTime2].PlannedOrderReceipt = (int)(lotSize * countk);


                            // Update Invent 
                            inven = uniqueItem.Inventory + ((int)(lotSize * countk) - net.Value);
                            uniqueItem.Inventory = inven;
                            itemRendersReport[itemRendersReport.Count - 1].ProjectOnHand = inven.Value;
                        }

                        for (int k = i - uniqueItem.LeadTime2; k < i; k++)
                        {
                            itemRendersReport[k].ProjectOnHand = inven.Value;
                        }
                    }

                    if (net.Value > 0)
                    {
                        itemRendersReport[i - uniqueItem.LeadTime.Value - uniqueItem.LeadTime2].PlannedOrderRelease = net.Value;
                        itemRendersReport[i - uniqueItem.LeadTime2].PlannedOrderReceipt = net.Value;
                    }
                }
                else
                {
                    itemRendersReport.Add(new ItemReport()
                    {
                        Week = i,
                        Year = yearSelected,
                        Gross = 0,          // always
                        NetRequirement = 0,
                        PlannedOrderReceipt = 0,
                        PlannedOrderRelease = 0,
                        ProjectOnHand = uniqueItem.Inventory.Value,
                        SchedultReceipt = 0
                    });
                }

            }

            // Consider
            //ConsideringLogistic(scheduleLs);

            lvItemReport.Items.AddRange(itemRendersReport.Select(x => CreateItemRow(x)).ToArray());

            lvOrderReport.Items.AddRange(itemRendersReport
                .Where(x => x.PlannedOrderRelease > 0)
                .GroupBy(x => x.Week)
                .Select(x => new ItemReport()
                {
                    Week = x.Key,
                    Year = yearSelected,
                    PlannedOrderRelease = x.Sum(i => i.PlannedOrderRelease)
                }).Select(x => CreateItemRow2(x)).ToArray());
        }

        private void ConsideringLogistic(List<Schedule> scheduleLs)
        {
            var offsetWeek = 3; // TODO: From F1 -> WA -> W1, need to find
            var leadtime = 2;   // TODO: get leadtime of selected Item
            var pohInit = Int32.Parse(lblProjectOnhand.Text);
            var safe = Int32.Parse(lblSafetyStock.Text);

            for (int i = 1; i <= weekSelected; i++)
            {

            }
        }

        private ListViewItem CreateItemRow(ItemReport itemReport)
        {
            var itemRow = new ListViewItem();
            itemRow.Text = itemReport.Week.ToString();
            itemRow.SubItems.Add(itemReport.Year.ToString());
            itemRow.SubItems.Add(itemReport.Gross.ToString());    // Gross Requiment = Demand
            itemRow.SubItems.Add(itemReport.SchedultReceipt.ToString());    // Schedule Receipt
            itemRow.SubItems.Add(itemReport.NetRequirement.ToString());    // Net Requiment
            itemRow.SubItems.Add(itemReport.ProjectOnHand.ToString());
            itemRow.SubItems.Add(itemReport.PlannedOrderReceipt.ToString());    // Planned Order Rece
            itemRow.SubItems.Add(itemReport.PlannedOrderRelease.ToString());    // Planned Order Release

            return itemRow;
        }

        private ListViewItem CreateItemRow2(ItemReport itemReport)
        {
            var itemRow = new ListViewItem();
            itemRow.Text = (cbbItem.SelectedItem as Item).Name.ToString();
            itemRow.SubItems.Add(itemReport.Week.ToString());
            itemRow.SubItems.Add(itemReport.PlannedOrderRelease.ToString());

            return itemRow;
        }

        private void LoadFirst()
        {
            items = itemDao.GetAll().Where(x => x.ItemTypeId != 1).ToList();

            itemIdSelected = items[0].Id;
            weekSelected = (int)nudWeeks.Value;
            yearSelected = (int)nudYear.Value;

            orderSource = orderDao.GetAll();
            //orderFilter = OrderFilterCondition();

        }
        private ColumnHeader CreateHeaderColumn(string text, int width, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Center) =>
            new ColumnHeader() { Text = text, Width = width, TextAlign = horizontalAlignment };

        private Schedule OrderToSchedule(Order x)
        {
            return new Schedule()
            {

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
