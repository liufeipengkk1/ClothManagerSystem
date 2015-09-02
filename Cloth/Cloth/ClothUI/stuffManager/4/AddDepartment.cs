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
    public partial class AddDepartment : Form
    {

        public String DepartmentName
        {
            get
            {
                return txt_name.Text;
            }
            set { }
        }
        public AddDepartment()
        {
            InitializeComponent();
            DepartmentName = "";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DepartmentName = txt_name.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DepartmentName = "";
            this.Close();
        }
    }
}
