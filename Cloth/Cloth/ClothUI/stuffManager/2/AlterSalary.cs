using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI.stuffManager._2
{
    public partial class AlterSalary : Form
    {
        public String Name { get; set; }
        public String oldSalary { get; set; }
        public String Reason { get; set; }
        public float Salary { get; set; }
        public AlterSalary()
        {
            InitializeComponent();
        }

        private void AlterSalary_Load(object sender, EventArgs e)
        {
            this.Text = "更改工资" + Name;
            lbl_oldSalary.Text = oldSalary;
            Salary = -1;
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                Salary = float.Parse(txt_sa.Text);
                Reason = txt_reason.Text;
            }
            catch
            {
                MessageBox.Show("请输入正确的格式");
                Salary = -1;
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
