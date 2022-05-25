
namespace App.UserControls
{
    partial class BomUC
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
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.tvBom = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lvItems = new System.Windows.Forms.ListView();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.flpFilter);
            this.panelContent.Controls.Add(this.tvBom);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.lvItems);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1333, 985);
            this.panelContent.TabIndex = 20;
            // 
            // flpFilter
            // 
            this.flpFilter.AutoScroll = true;
            this.flpFilter.BackColor = System.Drawing.SystemColors.Window;
            this.flpFilter.Location = new System.Drawing.Point(1127, 129);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(191, 838);
            this.flpFilter.TabIndex = 4;
            // 
            // tvBom
            // 
            this.tvBom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvBom.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvBom.FullRowSelect = true;
            this.tvBom.Indent = 40;
            this.tvBom.ItemHeight = 50;
            this.tvBom.Location = new System.Drawing.Point(24, 129);
            this.tvBom.Name = "tvBom";
            this.tvBom.Size = new System.Drawing.Size(225, 838);
            this.tvBom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOM";
            // 
            // lvItems
            // 
            this.lvItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvItems.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(259, 129);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(854, 840);
            this.lvItems.TabIndex = 1;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // BomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panelContent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BomUC";
            this.Size = new System.Drawing.Size(1333, 985);
            this.Load += new System.EventHandler(this.BomUC_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvBom;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
    }
}
