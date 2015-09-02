using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI.stuffManager._1
{
    public partial class Leave : Form
    {
        public String Flag { get; set; }
        public String Time{get;set;}
        public String Days { get; set; }
        public String Reason { get; set; }

        public Leave()
        {
            InitializeComponent();
        }

        private void Leave_Load(object sender, EventArgs e)
        {
            if (Flag == null)
                return; 
            if(Flag != "Leave")
            {
                lbl_days.Hide();
                txt_days.Hide(); 
            }
        }

        private void BindInfo()
        {
            Time = dateTimePicker.Text;
            Days = txt_days.Text;
            Reason = txt_reason.Text;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            BindInfo();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
