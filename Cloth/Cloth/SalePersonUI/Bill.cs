using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePersonUI
{
    public partial class Bill : Form
    {
        public String Money { get; set; }
        public Bill()
        {
            InitializeComponent();
        }

        private void txt_money_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_money.Text != "")
            {
                lbl_zhaoxian.Text = (long.Parse(txt_money.Text) - long.Parse(Money)).ToString();
            }
        }

        private void Bill_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter && lbl_zhaoxian.Text != "")
             {
                 btn_ok.PerformClick();
             }
             else if(e.Modifiers == Keys.Escape)
             {
                 btn_cancel.PerformClick();
             }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // 这行判断非常有必要：不用快捷键直接点击此按钮的时候，需要这行判断
            if(lbl_zhaoxian.Text != "0" && txt_money.Text != "")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            lbl_zhaoxian.Text = "0";
        }
        
    }
}
