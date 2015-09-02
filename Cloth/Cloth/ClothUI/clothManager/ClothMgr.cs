using ClothUI.clothManager;
using ClothUI.clothManager._4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI
{
    public partial class ClothMgr : Form
    {
        private UCloth cloth = new UCloth();
        private SaleSituation sale = new SaleSituation();

        public ClothMgr()
        {
            InitializeComponent();
            InnerFormHelper.InitInnerPanelForm(pal_right, cloth, sale);
            cloth.Show();
            sale.Hide();
        }

        private void btn_clothMgr_Click(object sender, EventArgs e)
        {
            sale.Hide();
            cloth.Show();
        }

        private void btn_saleMgr_Click(object sender, EventArgs e)
        {
            cloth.Hide();
            sale.Show();
        }

        private void btn_logoMgr_Click(object sender, EventArgs e)
        {
            LogoMgr lMgr = new LogoMgr();
            lMgr.ShowDialog();
        }
    }
}
