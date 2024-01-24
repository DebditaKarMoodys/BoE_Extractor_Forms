using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using IvyTemplateLib;
using IvyPdf;

namespace BoE_Extractor_Forms
{
    public class GlobalVar
    {
        static string _strTlPath;
        static string _strExcelPath;
        static string _strOutputFolder;

        public static string TlPath
        {
            get { return _strTlPath; }
            set { _strTlPath = value; }
        }

        public static string ExcelPath
        {
            get { return _strExcelPath; }
            set { _strExcelPath = value; }
        }

        public static string OutputFolder
        {
            get { return _strOutputFolder; }
            set { _strOutputFolder = value; }
        }

        public void KillExcel()
        {
            try
            {
                Process[] processArr = Process.GetProcessesByName("EXCEL");
                if (processArr.Length > 0)
                {
                    foreach (Process pr in processArr)
                    {
                        pr.Kill();
                        pr.WaitForExit();
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }

        public void Extract(string tlFilePath, string excelFilePath, string tlFileName, string excelFileName)
        {
            try
            {
                #region
                bool IVY = true;
                int i = 0;
                bool err = false;
                string TL_File_Path = tlFilePath;
                if (true) 
                {
                    string strError = string.Empty;
                    try
                    {
                        if (IVY)
                        {
                            #region IVY DATA EXTRACTION

                            if (excelFileName.ToUpper().Contains(".XLS") || excelFileName.ToUpper().Contains(".XLSX"))
                            {
                                #region Ivy Extraction For Excel

                                #region Table Required For Process Data Data
                                DataTable dtOutput = new System.Data.DataTable();
                                #endregion

                                string SourceTlPath = tlFilePath + "\\" + tlFileName.ToString();
                                string sourceFolderPath = excelFilePath + "\\" + excelFileName.ToString();
                                //SourceFileName = fi.Name.ToString();
                                TemplateLibrary tl = TemplateLibrary.LoadTemplateLibrary(SourceTlPath);
                                tl.StaticCodeMode = true;
                                DirectoryInfo TlFolder = new DirectoryInfo(SourceTlPath);
                                DataSetParser d = new DataSetParser(DataSetReader.ReadExcel(sourceFolderPath));
                                List<FieldResult> results = new List<FieldResult>();
                                try
                                {
                                    tl.RunTemplate(tl.Templates[0], d, out results);
                                    for (int c = 0; c < results.Count(); c++)
                                    {
                                        string FieldName = string.Empty;
                                        try
                                        {
                                            FieldName = results[c].FieldName;
                                            dtOutput = results[c].GetResultAsDataTable();
                                        }
                                        catch (Exception Ex_)
                                        {
                                            err = true;
                                            continue;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    err = true;
                                }
                                #endregion
                            }

                            #endregion


                        }
                    }
                    catch (Exception ex)
                    {
                        err = true;
                    }

                }
                i++;
                
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }
    }
}
