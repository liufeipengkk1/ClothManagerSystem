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
    public partial class ActivityMgr : Form
    {
        SaleActive saleAction = new SaleActive();
        HistoryActive historyActive = new HistoryActive();

        public ActivityMgr()
        {
            InitializeComponent();
            InnerFormHelper.InitInnerPanelForm(pal_fill, saleAction,historyActive);
            
        }

        private void ActivityMgr_Load(object sender, EventArgs e)
        {
            saleAction.Show();
        }

        private void btn_activity_Click(object sender, EventArgs e)
        {
            historyActive.Hide();
            saleAction.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            saleAction.Hide();
            historyActive.Show();
        }
    }
}
