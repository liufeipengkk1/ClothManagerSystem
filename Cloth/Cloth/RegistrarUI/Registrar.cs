using ClothDAL;
using ClothModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeOpenXml.Style;
using OfficeOpenXml;


namespace RegistrarUI
{
    public partial class Registrar : Form
    {
        
        private string _ID;
        private Person _person;
        private PersonDAL personDal = new PersonDAL();
        private int currentRowIndex = -1;
        private int dealRowIndex = 0;  //已处理过的行记录，初始状态为-1行
        private int currentColIndex = -1;
        private int clothCount = 0;
        private bool uploadContrl = false;
        private List<int> failedList = new List<int>();

        private string cellValue;
        private bool modifyFlag = false;//修改标志

        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

            progressBar_upload.Minimum = 0;
            lbl_uploadNum.Text = "0";

            _person = personDal.SearchById(_ID);
            lbl_userName.Text = _person.Name;
            //load the photo
            if (_person.Photo != null)
            {
                MemoryStream stream = new MemoryStream(_person.Photo);
                picture_header.Image = Image.FromStream(stream);
            }

            Control.CheckForIllegalCrossThreadCalls = false; //线程可访问
        }


        public void SetID(string id)
        {
            _ID = id;
        }

        //记录点击的单元格位置
        private void dataGridView_data_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentRowIndex = e.RowIndex;
            currentColIndex = e.ColumnIndex;
        }

        /// <summary>
        /// 删除有两种情况：上传完成后删除
        /// 未上传或上传失败删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            if (currentRowIndex != -1 && currentRowIndex < dataGridView_data.Rows.Count)
            {
                if((Convert.ToString(dataGridView_data.Rows[currentRowIndex].Cells[10].Value)) == "完成")
                {

                    CClothDAL clothDAL = new CClothDAL();
                    if(clothDAL.DeleteClothById(Convert.ToString(dataGridView_data.Rows[currentRowIndex].Cells[0].Value)) != 1)
                    {
                        return;
                    }
                    progressBar_upload.Value--;
                }
                dataGridView_data.Rows.RemoveAt(currentRowIndex);
                lbl_uploadNum.Text = (int.Parse(lbl_uploadNum.Text) - 1).ToString();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            uploadContrl = true;
            //保证当有任务需要处理的时候才启动线程：dealRowIndex < clothCount
            if(backgroundWorker.IsBusy == false && dealRowIndex < clothCount)
                backgroundWorker.RunWorkerAsync();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
            uploadContrl = false;
            backgroundWorker.CancelAsync();
        }

        private bool uploadArow(CClothDAL clothDal, DataGridViewRow row)
        {
            Cloth cloth = new Cloth();
            cloth.ID = Convert.ToString(row.Cells[0].Value);
            cloth.Name = Convert.ToString(row.Cells[1].Value);
            cloth.Style = Convert.ToString(row.Cells[2].Value);
            cloth.Color = Convert.ToString(row.Cells[3].Value);
            cloth.Size = Convert.ToString(row.Cells[4].Value);
            cloth.Price = float.Parse(Convert.ToString(row.Cells[5].Value));
            //cloth.SaleState = Convert.ToString(dataGridView_data.Rows[i].Cells[6].Value);

            // cloth.Logo = File.ReadAllBytes("C:\\Users\\LIU\\Desktop\\2.png");

            cloth.SaleState = SALESTATE.warehouse;
            cloth.Standard = Convert.ToString(row.Cells[6].Value);
            cloth.ClothLevel = Convert.ToString(row.Cells[7].Value);
            cloth.ManufacturerInfo = Convert.ToString(row.Cells[8].Value);
            cloth.CheckCode = Convert.ToString(row.Cells[9].Value);


            if (clothDal.InsertCloth(cloth) == 1)
            {
                //上传完成
                row.Cells[10].Style.BackColor = Color.Red;
                row.Cells[10].Value = "完成";
                return true;
            }
            else
            {
                //数据库异常
                row.Cells[10].Style.BackColor = Color.Blue;
                row.Cells[10].Value = "失败";
                return false;
            }
        }
        /// <summary>
        /// 后台上传，上传过程中会发生两种情况：
        /// 上传完成后取消，没响应
        /// 上传中途点击取消：使用dealrowIndex记录状态实现了续传
        /// 当发生了删除之后 dealRowIndex参数做相应的-1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = dataGridView_data.Rows.Count - 1;
            CClothDAL clothDal = new CClothDAL();

            //先上传上次上传失败的
            if(failedList.Count != 0)
            {
                foreach(int i in failedList)
                {
                    if(uploadArow(clothDal,dataGridView_data.Rows[i]))
                    {
                        failedList.Remove(i);
                    }
                }
            }
            
            for (int i = dealRowIndex; i < count && uploadContrl; i++)
            {
                if(!uploadArow(clothDal,dataGridView_data.Rows[i]))
                {
                    failedList.Add(i);
                }
                progressBar_upload.Value++;
                lbl_uploadNum.Text = progressBar_upload.Value.ToString();
                dealRowIndex = i;
            }

            dealRowIndex++;//下次执行线程的时候，所上传的行数开始点
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           // MessageBox.Show("zhong duan");
            uploadContrl = false;
        }

        private void dataGridView_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            clothCount++;
            //progressBar_upload.Maximum至于行数有关
            progressBar_upload.Maximum = clothCount;
            lbl_count.Text = "共" + clothCount.ToString() + "件";
        }

        private void dataGridView_data_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            clothCount--;
            progressBar_upload.Maximum = clothCount; 
            //如果删除的行在处理过的之内，那么，将受理的行数起始点-1
            if (e.RowCount <= dealRowIndex)
            {
                dealRowIndex--;
            }
            lbl_count.Text = "共" + clothCount.ToString() + "件";
        }

        //全局快捷键设置
        //以及文件的导入与导出
        private void Registrar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "导入清单";
                op.Filter = "xls文件|*.xls;*.xlsx";
                
                if(op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = op.FileName;
                    FileInfo existFile = new FileInfo(fileName);
                    using (ExcelPackage package = new ExcelPackage(existFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                        //批量导入从datagridview最新的一行开始插入
                        int colStart = worksheet.Dimension.Start.Column;  //工作区开始列
                        int colEnd = worksheet.Dimension.End.Column;       //工作区结束列
                        int rowStart = worksheet.Dimension.Start.Row;       //工作区开始行号
                        int rowEnd = worksheet.Dimension.End.Row;       //工作区结束行号
                        for (rowStart++; rowStart <= rowEnd; rowStart++)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView_data);
                            for (int col = colStart; col <= colEnd; col++)
                            {
                                //combox 里面的值会出问题
                                row.Cells[col - 1].Value = worksheet.Cells[rowStart, col].Value;
                            }
                            dataGridView_data.Rows.Add(row);
                        }
                            
                    }
                }
                
            }
            else if(e.KeyCode == Keys.F8)
            {
                Alterpaswd ap = new Alterpaswd();
                ap.ID = _ID;
                ap.ShowDialog();
            }
            else if(e.KeyCode == Keys.F2)
            {
                SaveFileDialog sp = new SaveFileDialog();
                sp.Filter = "xls文件|*.xls;*.xlsx";
                sp.Title = "导出清单";
                if(sp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String fileName = sp.FileName;
                    FileInfo newFile = new FileInfo(fileName);
                    if (newFile.Exists)
                    {
                        if(MessageBox.Show("文件已经存在，是否要替换") == System.Windows.Forms.DialogResult.OK)
                        {
                            newFile.Delete();  // ensures we create a new workbook
                        }
                    }
                    newFile = new FileInfo(fileName);
                    using (ExcelPackage package = new ExcelPackage(newFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("进货清单");
                        
                        //add header
                        worksheet.Cells[1, 1].Value = "条纹码";
                        worksheet.Cells[1, 2].Value = "品牌";
                        worksheet.Cells[1, 3].Value = "款式";
                        worksheet.Cells[1, 4].Value = "颜色";
                        worksheet.Cells[1, 5].Value = "尺码";
                        worksheet.Cells[1, 6].Value = "定价";
                        worksheet.Cells[1, 7].Value = "标准";
                        worksheet.Cells[1, 8].Value = "衣服等级";
                        worksheet.Cells[1, 9].Value = "出产商";
                        worksheet.Cells[1, 10].Value = "校验码";

                        //add the items
                        int row = 0 ;
                        int col = 0 ;
                        for(row = 0;row < clothCount;row++)
                        {
                            for(col = 0 ;col < 10;col++)
                            {
                                worksheet.Cells[row + 2, col + 1].Value = dataGridView_data.Rows[row].Cells[col].Value;
                            }
                        }
                      //  worksheet.Cells["A1:K11"].Style.Font.Color.SetColor(Color.Red);
                        package.Save();
                    }
                }
            }
        }

        //暂时不做“修改项的代码”
        private void dataGridView_data_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if(Convert.ToString(dataGridView_data.Rows[e.RowIndex].Cells[10].Value) == "完成")
            //{
            //    if(cellValue != Convert.ToString(dataGridView_data.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
            //    {
            //        //update数据
            //    }
            //}
        }

        private void dataGridView_data_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //string CurrentCellValue = Convert.ToString(dataGridView_data.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //if( CurrentCellValue != "")
            //{
            //    if(Convert.ToString(dataGridView_data.Rows[e.RowIndex].Cells[10].Value) == "完成")
            //    {
            //        if(MessageBox.Show("此项已经上传，是否要做修改") == System.Windows.Forms.DialogResult.OK)
            //        {
            //            cellValue = CurrentCellValue;
            //        }
            //    }
            //}
        }

    }
}
