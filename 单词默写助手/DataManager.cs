using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace 单词默写助手
{
    class DataManager
    {
        private string language;
        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        public bool readData(string filePath,string tableName,out string message)
        {
            try
            {
                string strConn = "";
                if (Regex.IsMatch(filePath, @"\.xlsx"))
                {
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + filePath + ";Extended Properties=Excel 12.0";
                }
                else if(Regex.IsMatch(filePath,@"\.xls"))
                {
                    strConn = "Provider=Microsoft.ACE.OLEDB.4.0;" + "Data Source=" + filePath + ";Extended Properties=Excel 4.0";
                }
                OleDbConnection connection = new OleDbConnection(strConn);
                connection.Open();
                OleDbDataAdapter command = new OleDbDataAdapter("select * from [" + tableName + "$]", strConn);
                DataSet db = new DataSet();
                command.Fill(db, "table1");
                Factory.createWordSet(db.Tables[0],language);
                message = "success";
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                message = e.Message;
                return false;
            }
        }
        public bool exportData(string filePath,Word[] wordSet)
        {
            //try
            //{
                object missing = System.Reflection.Missing.Value;
                dynamic newExcel = new Application();
                newExcel.Application.Workbooks.Add(true);
                if (newExcel == null)
                {
                    return false;
                }
                newExcel.Visible = false;
                newExcel.UserControl = true;
                dynamic workbook = newExcel.ActiveWorkbook;
                dynamic worksheet = workbook.ActiveSheet;
                if (worksheet == null)
                {
                    return false;
                }
                int index = 2;
                if(language == "English")
                {
                    worksheet.Cells[1, 1] = "外文";
                    worksheet.Cells[1, 2] = "中文";
                    foreach (EnglishWord word in wordSet)
                    {
                        worksheet.Cells[index, 1] = word.Foreign;
                        worksheet.Cells[index, 2] = word.Chinese;
                        index++;
                    }
                }
                else if(language == "日本語")
                {
                    worksheet.Cells[1, 1] = "外文";
                    worksheet.Cells[1, 2] = "假名";
                    worksheet.Cells[1, 3] = "中文";
                    foreach (JapaneseWord word in wordSet)
                    {
                        worksheet.Cells[index, 1] = word.Foreign;
                        worksheet.Cells[index, 2] = word.Hiragana;
                        worksheet.Cells[index, 3] = word.Chinese;
                        index++;
                    }
                }   
                worksheet.Columns.AutoFit();
                workbook.SaveAs(filePath);
                workbook.Close(false,missing,missing);
                newExcel.Quit();
                return true;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    return false;
            //}
        }
        public static DataManager dataManager = new DataManager();
    }
}
