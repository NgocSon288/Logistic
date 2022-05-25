using App.Common;
using App.Helper;
using App.UserControls;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            Load();

        }

        private ItemsUC fItem;
        private BomUC fBom;
        private MpsUC fMps;
        private ScheduleUC fSchedule;

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private BUTTON CURRENT_BUTTON;
        private enum BUTTON
        {
            ITEM1,
            ITEM,
            BOM,
            MPS,
            SCHEDULE
        }

        #region Methods

        new private void Load()
        { 
            CURRENT_BUTTON = BUTTON.ITEM1;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 62);
            panelMenu.Controls.Add(leftBorderBtn);

            Reset();

            btnSchedule_Click(btnSchedule, new EventArgs()); 
        }

        public void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            //fHome = new fHome();
            //UIHelper.ShowControl(fHome, panelContent);
        }

        private void DisposeForm()
        {
            //try { fHome?.Dispose(); } catch (Exception) { }
            //try { fProfile?.Dispose(); } catch (Exception) { }
            //try { fFriend?.Dispose(); } catch (Exception) { }
            //try { fMessenger?.Dispose(); } catch (Exception) { }
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //Button transition
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Constants.BORDER_MENU_LEFT_COLOR;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Constants.BORDER_MENU_LEFT_COLOR;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = Constants.BORDER_MENU_LEFT_COLOR;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        #endregion

        #region Controls Button

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            if (MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            if (CURRENT_BUTTON == BUTTON.ITEM)
            {
                return;
            }
            CURRENT_BUTTON = BUTTON.ITEM;

            DisposeForm();

            ActivateButton(sender);

            fItem = new ItemsUC();
            UIHelper.ShowControl(fItem, panelContent);
        }

        private void btnBom_Click(object sender, EventArgs e)
        {
            if (CURRENT_BUTTON == BUTTON.BOM)
            {
                return;
            }
            CURRENT_BUTTON = BUTTON.BOM;

            DisposeForm();

            ActivateButton(sender);

            fBom = new BomUC();
            UIHelper.ShowControl(fBom, panelContent);
        }

        private void btnPms_Click(object sender, EventArgs e)
        {
            if (CURRENT_BUTTON == BUTTON.MPS)
            {
                return;
            }
            CURRENT_BUTTON = BUTTON.MPS;

            DisposeForm();

            ActivateButton(sender);

            fMps = new MpsUC();
            UIHelper.ShowControl(fMps, panelContent);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (CURRENT_BUTTON == BUTTON.SCHEDULE)
            {
                return;
            }
            CURRENT_BUTTON = BUTTON.SCHEDULE;

            ActivateButton(sender);

            fSchedule = new ScheduleUC();
            UIHelper.ShowControl(fSchedule, panelContent);
        }
        #endregion
    }
}
