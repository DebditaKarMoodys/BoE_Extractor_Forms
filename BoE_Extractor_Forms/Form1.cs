using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MsgBox = System.Windows.Forms;
using IvyPdf;

namespace BoE_Extractor_Forms
{
    public partial class Form1 : Form
    {
        Generate gen = new Generate();
        public Form1()
        {
            InitializeComponent();
            IvyPdf.License.SetSessionLicense("BUQ8gFDYRT3sPM4Wpu3XAb7ROgRHNlf3QL4sK6iGXYW1QPtfFyuGembKagr1zOazsvVgH1APf6N9JXpuJUnW3LD7WSYIOa/8MgWSIHL2qOU=");
        }

        private void btnTlPath_Click(object sender, EventArgs e)
        {
            MsgBox.FolderBrowserDialog fbdSave = new MsgBox.FolderBrowserDialog();
            fbdSave.RootFolder = Environment.SpecialFolder.Desktop;
            fbdSave.ShowNewFolderButton = true;
            if (fbdSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTlPath.Text = fbdSave.SelectedPath;
                SaveTlPath(sender, e);
            }
        }

        private void btnExcelPath_Click(object sender, EventArgs e)
        {
            MsgBox.FolderBrowserDialog fbdSave = new MsgBox.FolderBrowserDialog();
            fbdSave.RootFolder = Environment.SpecialFolder.Desktop;
            fbdSave.ShowNewFolderButton = true;
            if (fbdSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtExcelPath.Text = fbdSave.SelectedPath;
                SaveExcelPath(sender, e);
            }
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            MsgBox.FolderBrowserDialog fbdSave = new MsgBox.FolderBrowserDialog();
            fbdSave.RootFolder = Environment.SpecialFolder.Desktop;
            fbdSave.ShowNewFolderButton = true;
            if (fbdSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOutputFolder.Text = fbdSave.SelectedPath;
                SaveOutputFolder(sender, e);
            }
        }

        private void btnGenerate_Click(object sende, EventArgs er)
        {
            gen.GenerateExcel(GlobalVar.TlPath, GlobalVar.ExcelPath, GlobalVar.OutputFolder);
        }

        private void SaveTlPath(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTlPath.Text))
                {
                    if (Directory.Exists(txtTlPath.Text))
                    {
                        GlobalVar.TlPath = txtTlPath.Text;
                    }
                    else
                    {
                        Directory.CreateDirectory(txtTlPath.Text);
                        GlobalVar.TlPath = txtTlPath.Text;
                    }
                }
                else
                {
                    MsgBox.MessageBox.Show("Path Cannot Be Blank");
                }
            }
            catch (Exception ex)
            {
                MsgBox.MessageBox.Show("Cannot Create Directory , Please check the Path Name or Permission .Error ");
                //lblInfo.Text = ex.ToString();
                txtTlPath.Text = GlobalVar.TlPath;
            }
        }

        private void SaveExcelPath(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtExcelPath.Text))
                {
                    if (Directory.Exists(txtExcelPath.Text))
                    {
                        GlobalVar.ExcelPath = txtExcelPath.Text;
                    }
                    else
                    {
                        Directory.CreateDirectory(txtExcelPath.Text);
                        GlobalVar.ExcelPath = txtExcelPath.Text;
                    }
                }
                else
                {
                    MsgBox.MessageBox.Show("Path Cannot Be Blank");
                }
            }
            catch (Exception ex)
            {
                MsgBox.MessageBox.Show("Cannot Create Directory , Please check the Path Name or Permission .Error ");
                //lblInfo.Text = ex.ToString();
                txtExcelPath.Text = GlobalVar.ExcelPath;
            }
        }

        private void SaveOutputFolder(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtOutputFolder.Text))
                {
                    if (Directory.Exists(txtOutputFolder.Text))
                    {
                        GlobalVar.OutputFolder = txtOutputFolder.Text;
                    }
                    else
                    {
                        Directory.CreateDirectory(txtOutputFolder.Text);
                        GlobalVar.OutputFolder = txtOutputFolder.Text;
                    }
                }
                else
                {
                    MsgBox.MessageBox.Show("Path Cannot Be Blank");
                }
            }
            catch (Exception ex)
            {
                MsgBox.MessageBox.Show("Cannot Create Directory , Please check the Path Name or Permission .Error ");
                txtOutputFolder.Text = GlobalVar.OutputFolder;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
