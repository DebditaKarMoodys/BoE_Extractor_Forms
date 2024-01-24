using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MsgBox = System.Windows.Forms;

namespace BoE_Extractor_Forms
{
    public class Generate
    {
        #region Global Variables
        GlobalVar GV = new GlobalVar();
        #endregion
        public void GenerateExcel(string tlPath, string excelPath, string outputPath)
        {
            try
            {
                #region Local Variables
                string[] tlFiles = Directory.GetFiles(tlPath);
                string[] excelFiles = Directory.GetFiles(excelPath);
                string tlFileName;
                string excelFileName;
                #endregion

                #region Warning
                if (MsgBox.DialogResult.No == MsgBox.MessageBox.Show("We are about to close all the excel. Do you still want to proceed?", "Warning!!!", MsgBox.MessageBoxButtons.YesNo, MsgBox.MessageBoxIcon.Warning, MsgBox.MessageBoxDefaultButton.Button2))
                {
                    return;
                }
                else
                {
                    GV.KillExcel();
                }
                #endregion

                foreach (string tlFile in tlFiles)
                {
                    tlFileName = tlFile.Replace(tlPath + "\\", "");
                    excelFileName = "";
                    foreach (string excelFile in excelFiles)
                    {
                        if (excelFile.Replace(excelPath + "\\", "").StartsWith(tlFileName.Replace("_AR.tl", "")))
                        {
                            excelFileName = excelFile.Replace(excelPath + "\\", "");
                        }
                    }
                    if (!string.IsNullOrEmpty(excelFileName))
                    {
                        GV.Extract(tlPath, excelPath, tlFileName, excelFileName);
                    }

                }
            }
            catch { }

        }
    }
}
