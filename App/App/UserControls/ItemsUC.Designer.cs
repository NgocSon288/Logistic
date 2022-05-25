
namespace App.UserControls
{
    partial class ItemsUC
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlSearchUnderline = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvItems = new System.Windows.Forms.ListView();
            this.panelContent.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.pnlFilter);
            this.panelContent.Controls.Add(this.btnDelete);
            this.panelContent.Controls.Add(this.btnUpdate);
            this.panelContent.Controls.Add(this.btnNew);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.lvItems);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1333, 985);
            this.panelContent.TabIndex = 20;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.button1);
            this.pnlFilter.Controls.Add(this.panel4);
            this.pnlFilter.Location = new System.Drawing.Point(24, 90);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1282, 98);
            this.pnlFilter.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(1142, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 42;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlSearchUnderline);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Location = new System.Drawing.Point(570, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 73);
            this.panel4.TabIndex = 21;
            // 
            // pnlSearchUnderline
            // 
            this.pnlSearchUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlSearchUnderline.Location = new System.Drawing.Point(24, 58);
            this.pnlSearchUnderline.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnlSearchUnderline.Name = "pnlSearchUnderline";
            this.pnlSearchUnderline.Size = new System.Drawing.Size(533, 2);
            this.pnlSearchUnderline.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSearch.Location = new System.Drawing.Point(103, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(441, 50);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search...";
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(23, 9);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(67, 62);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.TabStop = false;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(101)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(101)))));
            this.btnDelete.Location = new System.Drawing.Point(1121, 915);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 46);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(101)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(101)))));
            this.btnUpdate.Location = new System.Drawing.Point(904, 915);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 46);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(101)))));
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(101)))));
            this.btnNew.Location = new System.Drawing.Point(682, 915);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(185, 46);
            this.btnNew.TabIndex = 38;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // lvItems
            // 
            this.lvItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvItems.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(24, 194);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(1282, 700);
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // ItemsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panelContent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemsUC";
            this.Size = new System.Drawing.Size(1333, 985);
            this.Load += new System.EventHandler(this.ItemsUC_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlSearchUnderline;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button button1;
    }
}
