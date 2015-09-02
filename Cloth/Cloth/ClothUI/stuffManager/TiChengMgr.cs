using ClothDAL;
using ClothModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI.stuffManager
{
    public partial class TiChengMgr : Form
    {
        TiChengDAL tcd = new TiChengDAL();
        private int currentRow = -1;
        public TiChengMgr()
        {
            InitializeComponent();
        }


        private void TiChengMgr_Load(object sender, EventArgs e)
        {
            MTiCheng[] tcs = tcd.ListAll();
            foreach(MTiCheng tc in tcs)
            {
                BindTiCheng(tc);
            }
        }

        private void BindTiCheng(MTiCheng tc)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView_TiCheng);
            row.Cells[0].Value = tc.Name;
            row.Cells[1].Value = tc.Ways;
            row.Cells[2].Value = tc.Down;
            row.Cells[3].Value = tc.Up;
            row.Cells[4].Value = tc.Money;
            dataGridView_TiCheng.Rows.Add(row);
        }

        private void ToolStripMenuItem_modify_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuIte_delete_Click(object sender, EventArgs e)
        {
            TiChengDAL tcd = new TiChengDAL();
            DataGridViewRow row = dataGridView_TiCheng.Rows[currentRow];
            if(tcd.Delete(Convert.ToString(row.Cells[0].Value)) != 1)
            {
                return;
            }
            dataGridView_TiCheng.Rows.Remove(row);
        }

        private void ToolStripMenuItem_insert_Click(object sender, EventArgs e)
        {
            AddTiCheng ad = new AddTiCheng();
            if(ad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MTiCheng tc = ad.tc;
                TiChengDAL tcd = new TiChengDAL();
                if(tcd.Insert(tc) != 1)
                {
                    MessageBox.Show("检查联网");
                    return;
                }
                BindTiCheng(tc);
            }
        }

        private void dataGridView_TiCheng_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
