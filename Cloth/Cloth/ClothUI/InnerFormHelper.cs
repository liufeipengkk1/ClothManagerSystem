using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI
{
    static class InnerFormHelper
    {
        public static void InitInnerPanelForm(Panel pal,params Form[] winds)
        {
            if (winds == null)
            {
                MessageBox.Show("界面异常");
                return;
            }

            foreach (Form wind in winds)
            {
                wind.TopLevel = false;
                wind.ClientSize = new System.Drawing.Size(pal.Size.Width, pal.Size.Height);
                wind.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //填充整个panel
                wind.Dock = DockStyle.Fill;
                pal.Controls.Add(wind);
            }
        }

        public static void InitInnerPanelListView(ListView list,Panel pal, params String[] colNames)
        {
            int count = colNames.Count();
            int width = pal.ClientSize.Width;
            int cellWidth = width / count;
            foreach (String name in colNames)
            {
                list.Columns.Add(name, cellWidth,HorizontalAlignment.Left);
            }
        }


        public static void ShowTooltip(this Control control, ToolTip tip, string message, int xoffset = 0, int yoffset = 0)
        {
            Point _mousePoint = Control.MousePosition; 
            int _x = control.PointToClient(_mousePoint).X;
            int _y = control.PointToClient(_mousePoint).Y; 
            tip.Show(message, control, _x + xoffset, _y + yoffset);
            tip.Active = true; 
        }
    }
}
