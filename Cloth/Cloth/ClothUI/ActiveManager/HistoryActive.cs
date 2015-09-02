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
    public partial class HistoryActive : Form
    {
        public HistoryActive()
        {
            InitializeComponent();
        }

        private void HistoryActive_Load(object sender, EventArgs e)
        {
            list_active.Columns.Add("活动名称", 200, HorizontalAlignment.Left);
            list_active.Columns.Add("开始日期", 200, HorizontalAlignment.Left);
            list_active.Columns.Add("结束日期", 200, HorizontalAlignment.Left);
            list_active.Columns.Add("活动介绍", 400, HorizontalAlignment.Left);
            list_active.Columns.Add("是否完成", 200, HorizontalAlignment.Left);

            ActivityDAL ad = new ActivityDAL();
            Activity[] acs = ad.ListAll();
            if (acs != null)
            {
                foreach (Activity ac in acs)
                {
                    BindActivityItem(ac);
                }
            }
        }


        private void BindActivityItem(Activity ac)
        {
            ListViewItem item = new ListViewItem();
            item.Text = ac.Name;
            item.SubItems.Add(ac.StartTime.ToString("yyyy/MM/dd"));
            item.SubItems.Add(ac.EndTime.ToString("yyyy/MM/dd"));
            item.SubItems.Add(ac.ActivityContent);
            if (DateTime.Now >= ac.StartTime && DateTime.Now <= ac.EndTime)
            {
                item.SubItems.Add("正在进行中");
            }
            else if (DateTime.Now < ac.StartTime)
            {
                item.SubItems.Add("还未开始");
            }
            else
            {
                item.SubItems.Add("活动结束");
            }
            list_active.Items.Add(item);

        }

        private void addItem(DateTime start,DateTime end)
        {
            ActivityDAL ad = new ActivityDAL();
            Activity[] acs;
            acs = ad.ListHistory(start, end);

            if (acs != null)
                foreach (Activity ac in acs)
                {
                    BindActivityItem(ac);
                }
        }

        private void addItem()
        {
            ActivityDAL ad = new ActivityDAL();
            Activity[] acs;
            acs = ad.ListAll();

            if (acs != null)
                foreach (Activity ac in acs)
                {
                    BindActivityItem(ac);
                }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            list_active.Items.Clear();
            addItem(Convert.ToDateTime(dateTimePicker_start.Text), Convert.ToDateTime(dateTimePicker_end.Text));
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            list_active.Items.Clear();
            addItem();
        }

        private void btn_watch_Click(object sender, EventArgs e)
        {
            if (list_active.SelectedItems.Count != 0)
            {
                ActivityDAL ad = new ActivityDAL();
                ListViewItem item = list_active.SelectedItems[0];
                AddActive addActive = new AddActive();
                addActive.FLAG = "Watch";
                addActive.activity = ad.Search(item.Text);
                addActive.ShowDialog();
            }
        }
    }
}
