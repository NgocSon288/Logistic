
namespace App.UserControls
{
    partial class ScheduleUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContent = new System.Windows.Forms.Panel();
            this.lvItemReport = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportExc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProjectOnhand = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLotForLot = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSafetyStock = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLeadtime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLotsize = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbItem = new System.Windows.Forms.ComboBox();
            this.nudWeeks = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.orderReportTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvOrderReport = new System.Windows.Forms.ListView();
            this.btnSaveOrderReport = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.orderReportTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.orderReportTab);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1333, 985);
            this.panelContent.TabIndex = 20;
            // 
            // lvItemReport
            // 
            this.lvItemReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvItemReport.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItemReport.FullRowSelect = true;
            this.lvItemReport.GridLines = true;
            this.lvItemReport.HideSelection = false;
            this.lvItemReport.Location = new System.Drawing.Point(6, 213);
            this.lvItemReport.Name = "lvItemReport";
            this.lvItemReport.Size = new System.Drawing.Size(1308, 686);
            this.lvItemReport.TabIndex = 5;
            this.lvItemReport.UseCompatibleStateImageBehavior = false;
            this.lvItemReport.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "Schedule";
            // 
            // btnExportExc
            // 
            this.btnExportExc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExc.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnExportExc.FlatAppearance.BorderSize = 2;
            this.btnExportExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExc.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnExportExc.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnExportExc.Location = new System.Drawing.Point(532, 137);
            this.btnExportExc.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExc.Name = "btnExportExc";
            this.btnExportExc.Size = new System.Drawing.Size(262, 48);
            this.btnExportExc.TabIndex = 43;
            this.btnExportExc.Text = "Export to excel";
            this.btnExportExc.UseVisualStyleBackColor = true;
            this.btnExportExc.Click += new System.EventHandler(this.btnExportExc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Weeks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(937, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Project on hand:";
            // 
            // lblProjectOnhand
            // 
            this.lblProjectOnhand.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectOnhand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblProjectOnhand.Location = new System.Drawing.Point(1152, 11);
            this.lblProjectOnhand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectOnhand.Name = "lblProjectOnhand";
            this.lblProjectOnhand.Size = new System.Drawing.Size(174, 21);
            this.lblProjectOnhand.TabIndex = 48;
            this.lblProjectOnhand.Text = "123";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(937, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 26);
            this.label6.TabIndex = 49;
            this.label6.Text = "Lotsize rule:";
            // 
            // lblLotForLot
            // 
            this.lblLotForLot.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotForLot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLotForLot.Location = new System.Drawing.Point(1152, 82);
            this.lblLotForLot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLotForLot.Name = "lblLotForLot";
            this.lblLotForLot.Size = new System.Drawing.Size(174, 21);
            this.lblLotForLot.TabIndex = 50;
            this.lblLotForLot.Text = "lot_for_lot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(651, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 26);
            this.label8.TabIndex = 51;
            this.label8.Text = "Safety stock:";
            // 
            // lblSafetyStock
            // 
            this.lblSafetyStock.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSafetyStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSafetyStock.Location = new System.Drawing.Point(831, 11);
            this.lblSafetyStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSafetyStock.Name = "lblSafetyStock";
            this.lblSafetyStock.Size = new System.Drawing.Size(104, 21);
            this.lblSafetyStock.TabIndex = 52;
            this.lblSafetyStock.Text = "40";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(651, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 26);
            this.label10.TabIndex = 53;
            this.label10.Text = "Leadtime:";
            // 
            // lblLeadtime
            // 
            this.lblLeadtime.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeadtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLeadtime.Location = new System.Drawing.Point(831, 89);
            this.lblLeadtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeadtime.Name = "lblLeadtime";
            this.lblLeadtime.Size = new System.Drawing.Size(104, 21);
            this.lblLeadtime.TabIndex = 54;
            this.lblLeadtime.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(285, 82);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 26);
            this.label12.TabIndex = 55;
            this.label12.Text = "Lotsize:";
            // 
            // lblLotsize
            // 
            this.lblLotsize.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotsize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLotsize.Location = new System.Drawing.Point(425, 82);
            this.lblLotsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLotsize.Name = "lblLotsize";
            this.lblLotsize.Size = new System.Drawing.Size(174, 21);
            this.lblLotsize.TabIndex = 56;
            this.lblLotsize.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(285, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 26);
            this.label14.TabIndex = 57;
            this.label14.Text = "Item name:";
            // 
            // cbbItem
            // 
            this.cbbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbItem.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbItem.FormattingEnabled = true;
            this.cbbItem.Location = new System.Drawing.Point(430, 11);
            this.cbbItem.Name = "cbbItem";
            this.cbbItem.Size = new System.Drawing.Size(180, 34);
            this.cbbItem.TabIndex = 58;
            this.cbbItem.SelectedIndexChanged += new System.EventHandler(this.cbbItem_SelectedIndexChanged);
            // 
            // nudWeeks
            // 
            this.nudWeeks.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeeks.Location = new System.Drawing.Point(112, 9);
            this.nudWeeks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeeks.Name = "nudWeeks";
            this.nudWeeks.Size = new System.Drawing.Size(147, 33);
            this.nudWeeks.TabIndex = 59;
            this.nudWeeks.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudWeeks.ValueChanged += new System.EventHandler(this.nudWeeks_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Year:";
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("Consolas", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.Location = new System.Drawing.Point(112, 70);
            this.nudYear.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(147, 33);
            this.nudYear.TabIndex = 61;
            this.nudYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudYear.ValueChanged += new System.EventHandler(this.nudYear_ValueChanged);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.nudYear);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.nudWeeks);
            this.pnlInfo.Controls.Add(this.cbbItem);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Controls.Add(this.lblLotsize);
            this.pnlInfo.Controls.Add(this.label12);
            this.pnlInfo.Controls.Add(this.lblLeadtime);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.lblSafetyStock);
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Controls.Add(this.lblLotForLot);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.lblProjectOnhand);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.btnExportExc);
            this.pnlInfo.Location = new System.Drawing.Point(6, 18);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1310, 189);
            this.pnlInfo.TabIndex = 0;
            // 
            // orderReportTab
            // 
            this.orderReportTab.Controls.Add(this.tabPage1);
            this.orderReportTab.Controls.Add(this.tabPage2);
            this.orderReportTab.Location = new System.Drawing.Point(3, 83);
            this.orderReportTab.Name = "orderReportTab";
            this.orderReportTab.SelectedIndex = 0;
            this.orderReportTab.Size = new System.Drawing.Size(1327, 902);
            this.orderReportTab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlInfo);
            this.tabPage1.Controls.Add(this.lvItemReport);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1319, 873);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveOrderReport);
            this.tabPage2.Controls.Add(this.lvOrderReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1319, 873);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvOrderReport
            // 
            this.lvOrderReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvOrderReport.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrderReport.FullRowSelect = true;
            this.lvOrderReport.GridLines = true;
            this.lvOrderReport.HideSelection = false;
            this.lvOrderReport.Location = new System.Drawing.Point(345, 62);
            this.lvOrderReport.Name = "lvOrderReport";
            this.lvOrderReport.Size = new System.Drawing.Size(627, 805);
            this.lvOrderReport.TabIndex = 6;
            this.lvOrderReport.UseCompatibleStateImageBehavior = false;
            this.lvOrderReport.View = System.Windows.Forms.View.Details;
            // 
            // btnSaveOrderReport
            // 
            this.btnSaveOrderReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveOrderReport.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnSaveOrderReport.FlatAppearance.BorderSize = 2;
            this.btnSaveOrderReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrderReport.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnSaveOrderReport.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnSaveOrderReport.Location = new System.Drawing.Point(516, 7);
            this.btnSaveOrderReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveOrderReport.Name = "btnSaveOrderReport";
            this.btnSaveOrderReport.Size = new System.Drawing.Size(262, 48);
            this.btnSaveOrderReport.TabIndex = 44;
            this.btnSaveOrderReport.Text = "Export to excel";
            this.btnSaveOrderReport.UseVisualStyleBackColor = true;
            this.btnSaveOrderReport.Click += new System.EventHandler(this.btnSaveOrderReport_Click);
            // 
            // ScheduleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panelContent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ScheduleUC";
            this.Size = new System.Drawing.Size(1333, 985);
            this.Load += new System.EventHandler(this.ScheduleUC_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.orderReportTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvItemReport;
        private System.Windows.Forms.TabControl orderReportTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWeeks;
        private System.Windows.Forms.ComboBox cbbItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLotsize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLeadtime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSafetyStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLotForLot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProjectOnhand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportExc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSaveOrderReport;
        private System.Windows.Forms.ListView lvOrderReport;
    }
}
