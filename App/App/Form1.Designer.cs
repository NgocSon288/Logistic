
namespace App
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnSchedule = new FontAwesome.Sharp.IconButton();
            this.btnPms = new FontAwesome.Sharp.IconButton();
            this.btnBom = new FontAwesome.Sharp.IconButton();
            this.btnItems = new FontAwesome.Sharp.IconButton();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(267, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1333, 985);
            this.panelContent.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnSchedule);
            this.panelMenu.Controls.Add(this.btnPms);
            this.panelMenu.Controls.Add(this.btnBom);
            this.panelMenu.Controls.Add(this.btnItems);
            this.panelMenu.Controls.Add(this.imgLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 985);
            this.panelMenu.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.ObjectUngroup;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 922);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(13, 0, 53, 0);
            this.btnExit.Size = new System.Drawing.Size(267, 63);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.IconChar = FontAwesome.Sharp.IconChar.DiceD6;
            this.btnSchedule.IconColor = System.Drawing.Color.White;
            this.btnSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(0, 275);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(13, 0, 53, 0);
            this.btnSchedule.Size = new System.Drawing.Size(267, 63);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.TabStop = false;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnPms
            // 
            this.btnPms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPms.FlatAppearance.BorderSize = 0;
            this.btnPms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnPms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPms.ForeColor = System.Drawing.Color.White;
            this.btnPms.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger;
            this.btnPms.IconColor = System.Drawing.Color.White;
            this.btnPms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPms.Location = new System.Drawing.Point(0, 212);
            this.btnPms.Margin = new System.Windows.Forms.Padding(0);
            this.btnPms.Name = "btnPms";
            this.btnPms.Padding = new System.Windows.Forms.Padding(13, 0, 53, 0);
            this.btnPms.Size = new System.Drawing.Size(267, 63);
            this.btnPms.TabIndex = 3;
            this.btnPms.TabStop = false;
            this.btnPms.Text = "MPS";
            this.btnPms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPms.UseVisualStyleBackColor = false;
            this.btnPms.Click += new System.EventHandler(this.btnPms_Click);
            // 
            // btnBom
            // 
            this.btnBom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBom.FlatAppearance.BorderSize = 0;
            this.btnBom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnBom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBom.ForeColor = System.Drawing.Color.White;
            this.btnBom.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnBom.IconColor = System.Drawing.Color.White;
            this.btnBom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBom.Location = new System.Drawing.Point(0, 149);
            this.btnBom.Margin = new System.Windows.Forms.Padding(0);
            this.btnBom.Name = "btnBom";
            this.btnBom.Padding = new System.Windows.Forms.Padding(13, 0, 53, 0);
            this.btnBom.Size = new System.Drawing.Size(267, 63);
            this.btnBom.TabIndex = 2;
            this.btnBom.TabStop = false;
            this.btnBom.Text = "BOM";
            this.btnBom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBom.UseVisualStyleBackColor = false;
            this.btnBom.Click += new System.EventHandler(this.btnBom_Click);
            // 
            // btnItems
            // 
            this.btnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnItems.IconColor = System.Drawing.Color.White;
            this.btnItems.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.Location = new System.Drawing.Point(0, 86);
            this.btnItems.Margin = new System.Windows.Forms.Padding(0);
            this.btnItems.Name = "btnItems";
            this.btnItems.Padding = new System.Windows.Forms.Padding(13, 0, 53, 0);
            this.btnItems.Size = new System.Drawing.Size(267, 63);
            this.btnItems.TabIndex = 1;
            this.btnItems.TabStop = false;
            this.btnItems.Text = "Items";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(267, 86);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 985);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSchedule;
        private FontAwesome.Sharp.IconButton btnPms;
        private FontAwesome.Sharp.IconButton btnBom;
        private FontAwesome.Sharp.IconButton btnItems;
        private System.Windows.Forms.PictureBox imgLogo;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}

