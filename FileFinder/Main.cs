using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class Main : Form
    {
        int rowindex = 0;
        string[] tempList;
        DataTable dt = new DataTable();
        DataRow dr;
        string fileExtOption = "<< Enter file extension like mp3, psd, etc...>>\n<< Leave it blank for ALL >>";
        string fileNameOption = "<< Enter file name or part of it >>\n<< Leave it blank for ALL >>";
        string folderNameOption = "<< Enter folder name or part of it >>\n<< Leave it blank for ALL >>";
        string sizeOption = "<< Enter desired size limit in Kbytes >>\n<< Leave it blank for ALL >>";
        string fExt;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            getCurDate();
            getCurrentPath();
            rdbByFileName.Checked = true;
            rdbByFileName.ForeColor = Color.FromArgb(192, 64, 0);
        }

        private void getCurDate()
        {
            DateTime dt = DateTime.Today;
            string stringDate = dt.ToString("dddd, dd MMMM yyyy");
            lblDate.Text = stringDate;
        }

        private void btnGetCurrentPath_Click(object sender, EventArgs e)
        {
            getCurrentPath();
        }
        private void getCurrentPath()
        {
            btnSearch.Focus();
            string path = Directory.GetCurrentDirectory();
            txtPath.Text = path;
        }
        //Filter for only Letter Or Digit
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Concat(txtSearch.Text.Where(char.IsLetterOrDigit));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Clearing Data Grid
            clearGrid();
            //validatePath();
            if (!isValidPath())
            {
                MessageBox.Show("Directory Path is not valid !!!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPath.Focus();
            }
            else
            {
                if (txtPath.Text.Trim() == "")
                {
                    MessageBox.Show("System path not specified !!!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtSearch.Text.Trim() == "")
                {
                    txtSearch.Text = "*" + txtSearch.Text;
                }
                //Search by Extention
                if (rdbByFileExt.Checked)
                {
                    searchFileByExt();
                }
                //Search by file name
                if (rdbByFileName.Checked)
                {
                    searchFileByName();
                }
                //Search by folder name
                if (rdbByFolderName.Checked)
                {
                    searchFolderByName();
                }
                //Search size < or > then size
                if (rdbFileLessThenSize.Checked || rdbFolderGreaterThenSize.Checked)
                {
                    searchFileBySize();
                }
            }
        }

        private void searchFileBySize()
        {

            resetDataTable();
            try
            {
                //Get Directory path
                tempList = Directory.GetFiles(@txtPath.Text.Trim(), "*", SearchOption.AllDirectories);

                //File Name, File Path, File Type, File size, create date
                for (int i = 0; i <= tempList.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        //Add Data Grid Columns with name
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Type");
                        dt.Columns.Add("Size <MB>", typeof(decimal));
                        dt.Columns.Add("Create_Date");
                        dt.Columns.Add("Path");
                    }
                    //Get each file information
                    FileInfo f = new FileInfo(tempList[i]);
                    dr = dt.NewRow();
                    //Get File name of each file name
                    dr["Name"] = f.Name;
                    //Get File path of each file name
                    dr["Path"] = f.FullName;
                    //Get File Type/Extension of each file 
                    dr["Type"] = f.Extension;
                    //Get File Size of each file in MB
                    dr["Size <MB>"] = getFormatedValue(f.Length / 1e+6);
                    //Get file Create Date and Time 
                    dr["Create_Date"] = f.CreationTime.Date.ToString("dd/MM/yyyy");


                    //Insert collected file details in Datatable
                    dt.Rows.Add(dr);

                    if (dt.Rows.Count < 1)
                    {
                        MessageBox.Show("No Files found with specified request !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        //Add DataTable into DataGridView
                        dgrList.DataSource = dt;
                        //Format DataTable
                        formatDataTable();
                        //Size filter                  
                    }
                }

            }
            catch (UnauthorizedAccessException) { MessageBox.Show("Access denied !!! \nHidden files or folders detected !", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            if (rdbFileLessThenSize.Checked)
            {
                getLessThenSize();
            }
            if (rdbFolderGreaterThenSize.Checked)
            {
                getGreaterThenSize();
            }
        }

        private bool isValidPath()
        {
            return Directory.Exists(txtPath.Text);
        }

        private void clearGrid()
        {
            dt.Columns.Clear();

            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dt.Rows[i];
                if (row.RowState == DataRowState.Deleted) { dt.Rows.RemoveAt(i); }
            }
        }

        private void searchFileByName()
        {
            resetDataTable();
            try
            {
                //Get Directory path
                tempList = Directory.GetFiles(@txtPath.Text.Trim(), txtSearch.Text.Trim() + "*", SearchOption.AllDirectories);

                //File Name, File Path, File Type, File size, create date
                for (int i = 0; i <= tempList.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        //Add Data Grid Columns with name
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Type");
                        dt.Columns.Add("Size <MB>", typeof(decimal));
                        dt.Columns.Add("Create_Date");
                        dt.Columns.Add("Path");
                    }
                    //Get each file information
                    FileInfo f = new FileInfo(tempList[i]);
                    FileSystemInfo f1 = new FileInfo(tempList[i]);
                    dr = dt.NewRow();
                    //Get File name of each file name
                    dr["Name"] = f1.Name;
                    //Get File path of each file name
                    dr["Path"] = f1.FullName;
                    //Get File Type/Extension of each file 
                    dr["Type"] = f1.Extension;
                    //Get File Size of each file in MB
                    dr["Size <MB>"] = getFormatedValue(f.Length / 1e+6);
                    //Get file Create Date and Time 
                    dr["Create_Date"] = f1.CreationTime.Date.ToString("dd/MM/yyyy");
                    //Insert collected file details in Datatable
                    dt.Rows.Add(dr);

                    if (dt.Rows.Count < 1)
                    {
                        MessageBox.Show("No Files found with specified extension !!!", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        //Add DataTable into DataGridView
                        dgrList.DataSource = dt;
                        //Format DataTable
                        formatDataTable();
                    }
                }
            }
            catch (UnauthorizedAccessException) { MessageBox.Show("Access denied !!! \nHidden files or folders detected !", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void searchFileByExt()
        {
            resetDataTable();
            try
            {
                if (txtSearch.Text.ToLower().Equals(""))
                {
                    fExt = "*";
                }
                else
                {
                    fExt = "*." + txtSearch.Text.ToLower();
                }
                //Get Directory path
                tempList = Directory.GetFiles(@txtPath.Text.Trim(), fExt, SearchOption.AllDirectories);

                //File Name, File Path, File Type, File size, create date
                for (int i = 0; i <= tempList.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        //Add Data Grid Columns with name
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Type");
                        dt.Columns.Add("Size <MB>", typeof(decimal));
                        dt.Columns.Add("Create_Date");
                        dt.Columns.Add("Path");
                    }
                    //Get each file information
                    FileInfo f = new FileInfo(tempList[i]);
                    FileSystemInfo f1 = new FileInfo(tempList[i]);
                    dr = dt.NewRow();
                    //Get File name of each file name
                    dr["Name"] = f1.Name;
                    //Get File path of each file name
                    dr["Path"] = f1.FullName;
                    //Get File Type/Extension of each file 
                    dr["Type"] = f1.Extension;
                    //Get File Size of each file in MB
                    dr["Size <MB>"] = getFormatedValue(f.Length / 1e+6);
                    //Get file Create Date and Time 
                    dr["Create_Date"] = f1.CreationTime.Date.ToString("dd/MM/yyyy");


                    //Insert collected file details in Datatable
                    dt.Rows.Add(dr);

                    if (dt.Rows.Count > 0)
                    {
                        //Add DataTable into DataGridView
                        dgrList.DataSource = dt;
                        //Format DataTable
                        formatDataTable();
                    }
                }
            }
            catch (UnauthorizedAccessException) { MessageBox.Show("Access denied !!! \nHidden files or folders detected !", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void searchFolderByName()
        {
            resetDataTable();
            try
            {
                //Get Directories
                tempList = Directory.GetDirectories(@txtPath.Text.Trim(), txtSearch.Text.Trim() + "*", SearchOption.AllDirectories);

                //Folder Name, Folder path, Folder Type, Folder size, create date
                for (int i = 0; i <= tempList.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        //Add Data Grid Columns with name
                        dt.Columns.Add("Name");
                        dt.Columns.Add("Create_Time");
                        dt.Columns.Add("Size <MB>", typeof(decimal));
                        dt.Columns.Add("Create_Date");
                        dt.Columns.Add("Path");
                    }
                    //Get each folder information
                    DirectoryInfo d = new DirectoryInfo(tempList[i]);
                    dr = dt.NewRow();
                    //Get Folder name of each folder
                    dr["Name"] = d.Name;
                    //Get folder absolute path of each folder
                    dr["Path"] = d.FullName;
                    //Get folder Create Time
                    DateTime tempTime = d.CreationTime;
                    string strTime = tempTime.ToString("HH:mm:ss");
                    dr["Create_Time"] = strTime;
                    //Get Folder size of each folder in MB
                    dr["Size <MB>"] = getFormatedValue(d.EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(file => file.Length) / 1e+6);
                    //Get folder Create Date 
                    dr["Create_Date"] = d.CreationTime.Date.ToString("dd/MM/yyyy");


                    //Insert collected folder details in Datatable
                    dt.Rows.Add(dr);

                    if (dt.Rows.Count > 0)
                    {
                        //Add DataTable into DataGridView
                        dgrList.DataSource = dt;
                        //Format DataTable
                        formatDataTable();
                    }
                }
            }
            catch (UnauthorizedAccessException) { MessageBox.Show("Access denied !!! \nHidden files or folders detected !", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //DataTable reset
        private void resetDataTable()
        {
            dt = new DataTable();
        }
        /// <summary>
        /// Radio buttons Status on change
        /// </summary>
        private void rdbByFileName_CheckedChanged_1(object sender, EventArgs e)
        {
            rdbColorReset();
            lblOption.Text = fileNameOption;
            rdbByFileName.ForeColor = Color.FromArgb(192, 64, 0);
            btnSearch.Focus();
            dgrList.DataSource = null;
            //resetDataTable();
            txtSearch.Text = String.Empty;
        }
        private void rdbByFileExt_CheckedChanged_1(object sender, EventArgs e)
        {
            rdbColorReset();
            lblOption.Text = fileExtOption;
            rdbByFileExt.ForeColor = Color.FromArgb(192, 64, 0);
            btnSearch.Focus();
            dgrList.DataSource = null;
            //resetDataTable();
            txtSearch.Text = String.Empty;
        }
        private void rdbByFolderName_CheckedChanged_1(object sender, EventArgs e)
        {
            rdbColorReset();
            lblOption.Text = folderNameOption;
            rdbByFolderName.ForeColor = Color.FromArgb(192, 64, 0);
            btnSearch.Focus();
            dgrList.DataSource = null;
            //resetDataTable();
            txtSearch.Text = String.Empty;
        }
        private void rdbFileLessThenSize_CheckedChanged(object sender, EventArgs e)
        {
            rdbColorReset();
            lblOption.Text = sizeOption;
            btnSearch.Focus();
            rdbFileLessThenSize.ForeColor = Color.FromArgb(192, 64, 0);
            dgrList.DataSource = null;
            //resetDataTable();
            txtSearch.Text = String.Empty;
        }
        private void rdbFileGreaterThenSize_CheckedChanged(object sender, EventArgs e)
        {
            rdbColorReset();
            lblOption.Text = sizeOption;
            btnSearch.Focus();
            rdbFileGreaterThenSize.ForeColor = Color.FromArgb(192, 64, 0);
            dgrList.DataSource = null;
            //resetDataTable();
            txtSearch.Text = String.Empty;
        }
        private void rdbFolderLessThenSize_CheckedChanged(object sender, EventArgs e)
        {
            rdbColorReset();
            lblOption.Text = sizeOption;
            btnSearch.Focus();
            rdbFolderLessThenSize.ForeColor = Color.FromArgb(192, 64, 0);
            dgrList.DataSource = null;
            //resetDataTable();
            txtSearch.Text = String.Empty;
        }
        private void rdbFolderGreaterThenSize_CheckedChanged(object sender, EventArgs e)
        {
            rdbColorReset();
            lblOption.Text = sizeOption;
            btnSearch.Focus();
            rdbFolderGreaterThenSize.ForeColor = Color.FromArgb(192, 64, 0);
            dgrList.DataSource = null;
            //resetDataTable();
            txtSearch.Text = String.Empty;
        }

        //Reset radio Buttons color
        private void rdbColorReset()
        {
            rdbByFileName.ForeColor = Color.FromArgb(0, 64, 0);
            rdbByFolderName.ForeColor = Color.FromArgb(0, 64, 0);
            rdbByFileExt.ForeColor = Color.FromArgb(0, 64, 0);
            rdbFileLessThenSize.ForeColor = Color.FromArgb(0, 64, 0);
            rdbFileGreaterThenSize.ForeColor = Color.FromArgb(0, 64, 0);
            rdbFolderLessThenSize.ForeColor = Color.FromArgb(0, 64, 0);
            rdbFolderGreaterThenSize.ForeColor = Color.FromArgb(0, 64, 0);
        }
        private void formatDataTable()
        {
            dgrList.Visible = true;
            dgrList.AllowUserToAddRows = false;

            for (int j = 0; j < dgrList.ColumnCount - 1; j++)
            {
                this.dgrList.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private double getFormatedValue(double v)
        {
            return Math.Round(v, 3);
        }

        //private void btnDelRows_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        foreach (DataGridViewRow row in dgrList.Rows)
        //        {
        //            double size = Convert.ToDouble(dgrList.Rows[rowindex].Cells[2].Value);
        //            if (size > Convert.ToDouble(txtSearch.Text))
        //            {
        //                if (!row.IsNewRow)
        //                {
        //                    dgrList.Rows.Remove(row);
        //                }
        //            }
        //            rowindex++;
        //        }
        //     }catch (ArgumentOutOfRangeException) { }
        //}

        //Filter less then specified size
        private void getLessThenSize()
        {
            try
            {
                foreach (DataGridViewRow row in dgrList.Rows)
                {
                    double fileSize = Convert.ToDouble(dgrList.Rows[rowindex].Cells[2].Value);
                    if (fileSize > Convert.ToDouble(txtSearch.Text))
                    {
                        dgrList.Rows.Remove(row);
                    }
                }
            }
            catch (ArgumentOutOfRangeException) { }
        }
        //Filter greater then specified size
        private void getGreaterThenSize()
        {
            try
            {
                foreach (DataGridViewRow row in dgrList.Rows)
                {
                    double fileSize = Convert.ToDouble(dgrList.Rows[rowindex].Cells[2].Value);
                    if (fileSize < Convert.ToDouble(txtSearch.Text))
                    {
                        dgrList.Rows.Remove(row);
                    }
                }
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void btnDelRows_Click(object sender, EventArgs e)
        {
            //if(dgrList.RowCount > 0)
            //{ 
            //    for(int i = dgrList.RowCount - 1; i >= 17; i--)
            //    {
            //        double fileSize = Convert.ToDouble(dgrList.Rows[rowindex].Cells[2].Value);
            //        MessageBox.Show(" " + dgrList.RowCount + "row num " + i);

            //        if (fileSize < Convert.ToDouble(txtSearch.Text))
            //        {
            //            dgrList.Rows[i].Delete();
            //            MessageBox.Show("deleting row num " + i);
            //        }
            //    }
            //}
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                int fileSize = Convert.ToInt32(dgrList.Rows[rowindex].Cells[2].Value);
                if (fileSize < Convert.ToInt32(txtSearch.Text))
                {
                    dt.Rows[i].Delete();
                }
            }
            //dt.AcceptChanges();
            //dgrList.Refresh();
        }
        //private void delSelectedFile()
        //{
        //    foreach(DataTable )
        //}

        private void dgrList_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgrList.SelectedRows)
            {
                string value1 = row.Cells[4].Value.ToString();
                MessageBox.Show(value1, "Path", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgrList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgrList.SelectedRows)
            {
                string value1 = row.Cells[4].Value.ToString();
                MessageBox.Show(value1, "Path", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgrList.Rows)
            {
                string path = dgrList.Rows[rowindex].Cells[4].Value.ToString();
                MessageBox.Show(path, "Path", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //if (File.Exists(@path))
                //{
                //    File.Delete(@path);
                //}
                rowindex++;
            }

        }
    }
}
