using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI.stuffManager._4
{
    public partial class DepartmentMgr : Form
    {
        

        public DepartmentMgr()
        {
            InitializeComponent();
        }

        private void DepartmentMgr_Load(object sender, EventArgs e)
        {
            list_data.Columns.Add("部门",200);
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDepartment addDep = new AddDepartment();
            addDep.ShowDialog();
            if(addDep.DepartmentName != "")
            {
                list_data.Items.Add(addDep.DepartmentName);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in list_data.SelectedItems)
            {
                item.Remove();
            }

            list_data.Refresh();
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartment addDep = new AddDepartment();
            addDep.ShowDialog();
            if (addDep.DepartmentName != "")
            {
                list_data.Items.Add(addDep.DepartmentName);
            }

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_data.SelectedItems)
            {
                item.Remove();
            }

            list_data.Refresh();
        }
        
    }
}
