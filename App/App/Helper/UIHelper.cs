using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms; 

namespace App.Helper
{
    public static class UIHelper
    {
        public static void ShowControl(System.Windows.Forms.Control control, System.Windows.Forms.Control content)
        {
            content.Controls.Clear();

            foreach (System.Windows.Forms.Control item in content.Controls)
            {
                item.Dispose();
            }

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            content.BringToFront();

            content.Controls.Add(control);
        }

        public static void ShowCombackControl(System.Windows.Forms.Control parent)
        {
            parent.Controls.Clear();

            parent.SendToBack();
        }

    }
}
