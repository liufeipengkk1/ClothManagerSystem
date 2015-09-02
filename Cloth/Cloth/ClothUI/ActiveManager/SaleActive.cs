using ClothDAL;
using ClothModel;
using ClothUI.clothManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI.ActiveManager
{
    public partial class SaleActive : Form
    {
        private bool flag = true;

        public SaleActive()
        {
            InitializeComponent();
        }

        private void SaleActive_Load(object sender, EventArgs e)
        {
            pal_bottom.Hide();
            list_active.Columns.Add("活动名称", 200, HorizontalAlignment.Left);
            list_active.Columns.Add("开始日期", 200, HorizontalAlignment.Left);
            list_active.Columns.Add("结束日期", 200, HorizontalAlignment.Left);
            list_active.Columns.Add("活动介绍", 400, HorizontalAlignment.Left);
            list_active.Columns.Add("是否完成", 200, HorizontalAlignment.Left);

            list_cloth.Columns.Add("条纹码", 200, HorizontalAlignment.Left);
            list_cloth.Columns.Add("品牌", 200, HorizontalAlignment.Left);
            list_cloth.Columns.Add("款式", 200, HorizontalAlignment.Left);
            list_cloth.Columns.Add("颜色", 200, HorizontalAlignment.Left);
            list_cloth.Columns.Add("尺寸", 200, HorizontalAlignment.Left);
            list_cloth.Columns.Add("上架时间", 200, HorizontalAlignment.Left);
            list_cloth.Columns.Add("原价", 200, HorizontalAlignment.Left);

            ActivityDAL ad = new ActivityDAL();
            Activity[] acs = ad.ListAll();
            if(acs != null)
            {
                foreach (Activity ac in acs)
                {
                    BindActivityItem(ac);
                }
            }
            

            ListViewItem it = new ListViewItem();
            it.SubItems[0].Text = "123";
            it.SubItems.Add("da");
            list_cloth.Items.Add(it);


            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = "asdf";
            this.ToolStripMenuItem_add.DropDownItems.Add(item);

        }


        private void addItem(DateTime Time)
        {
            ActivityDAL ad = new ActivityDAL();
            Activity[] acs;
            if(Time == null )
            {
                acs = ad.ListAll();
            }
            else
            {
                acs = ad.ListBeing(Time);
            }
            
            if(acs != null)
                foreach (Activity ac in acs)
                {
                    BindActivityItem(ac);
                }
        }

        private void BindActivityItem(Activity ac)
        {
            ListViewItem item = new ListViewItem();
            item.Text = ac.Name;
            item.SubItems.Add(ac.StartTime.ToString("yyyy/MM/dd"));
            item.SubItems.Add(ac.EndTime.ToString("yyyy/MM/dd"));
            item.SubItems.Add(ac.ActivityContent);
            if(DateTime.Now >= ac.StartTime && DateTime.Now <= ac.EndTime)
            {
                item.SubItems.Add("正在进行中");
            }
            else if(DateTime.Now < ac.StartTime)
            {
                item.SubItems.Add("还未开始");
            }
            else
            {
                item.SubItems.Add("活动结束");
            }
            list_active.Items.Add(item);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                pal_bottom.Show();
                button1.Text = "隐藏销量";
                flag = false;
            }
            else
            {
                flag = true;
                pal_bottom.Hide();
                button1.Text = "显示销量";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddActive addActive = new AddActive();
            addActive.FLAG = "Insert";
            if (addActive.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindActivityItem(addActive.activity);
        }


        private void ToolStripMenuItem_add_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Text);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            list_active.Items.Clear();
            addItem(Convert.ToDateTime(dateTimePicker.Text));
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(list_active.SelectedItems.Count != 0)
            {
                ActivityDAL ad = new ActivityDAL();
                ListViewItem item = list_active.SelectedItems[0];
                AddActive addActive = new AddActive();
                addActive.FLAG = "Edit";
                addActive.activity = ad.Search(item.Text);
                addActive.ShowDialog();
            }
        }

        private void btn_delelte_Click(object sender, EventArgs e)
        {
            if (list_active.SelectedItems.Count != 0)
            {
                ActivityDAL ad = new ActivityDAL();
                ListViewItem item = list_active.SelectedItems[0];
                ad.DeleteActivity(item.Text);
                list_active.Items.Remove(item);
            }
        }
    }
}
