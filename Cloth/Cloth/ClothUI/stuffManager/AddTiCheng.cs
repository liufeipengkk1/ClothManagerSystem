using ClothModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI.stuffManager
{
    public partial class AddTiCheng : Form
    {
        public MTiCheng tc;
        
        public AddTiCheng()
        {
            InitializeComponent();
        }

        private void AddTiCheng_Load(object sender, EventArgs e)
        {
            cbx_Ways.Items.Add("MONEY");
            cbx_Ways.Items.Add("按比例");
            cbx_Ways.SelectedIndex = 0;
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text == "" || txt_Money.Text == "")
            {
                MessageBox.Show("有空项");
                return;
            }
            tc = new MTiCheng();
            tc.Name = txt_Name.Text;
            tc.Down = float.Parse(txt_down.Text);
            tc.Up = float.Parse(txt_up.Text);
            tc.Money = float.Parse(txt_Money.Text);
            if(cbx_Ways.SelectedIndex == 0)
            {
                tc.Ways = WAY.MONEY;
            }
            else if (cbx_Ways.SelectedIndex == 1)
            {
                tc.Ways = WAY.PERCENTAGE;
            }
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        
    }
}
