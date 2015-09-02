using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI.clothManager._4
{
    public partial class LogoMgr : Form
    {
        public LogoMgr()
        {
            InitializeComponent();
        }

        private void LogoMgr_Load(object sender, EventArgs e)
        {
            list_data.Columns.Add("品牌", 200, HorizontalAlignment.Center);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text == "")
            {
                MessageBox.Show("请输入要添加的品牌名称");
                return;
            }

            list_data.Items.Add(txt_Name.Text);
            txt_Name.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in list_data.SelectedItems)
            {
                item.Remove();
            }

            list_data.Refresh();
        }
    }
}
