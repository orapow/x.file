using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace X.File
{
    public class DB : IDisposable
    {
        IWorkbook wb = null;
        string file = "";
        ISheet sheet = null;
        public DB(string filename)
        {
            file = filename;
            try
            {
                load_xls();
                if (wb == null) load_xlsx();
            }
            catch { }
        }

        void load_xls()
        {
            var fs = new FileStream(file, FileMode.Open);
            try
            {
                wb = new HSSFWorkbook(fs);
            }
            catch { }
            finally
            {
                fs.Close();
            }
        }
        void load_xlsx()
        {
            var fs = new FileStream(file, FileMode.Open);
            try
            {
                wb = new XSSFWorkbook(fs);
            }
            catch { }
            finally
            {
                fs.Close();
            }
        }
        public List<string> LoadTables()
        {
            if (wb == null) return null;
            var list = new List<string>();
            for (var i = 0; i < wb.NumberOfSheets; i++)
            {
                var st = wb.GetSheetAt(i);
                if (st != null) list.Add(st.SheetName);
            }
            return list;
        }

        public DataTable LoadData(string tname)
        {
            if (!string.IsNullOrEmpty(tname)) sheet = wb.GetSheet(tname);
            if (sheet == null) return null;
            var data = new DataTable();
            IRow firstRow = sheet.GetRow(0);
            if (firstRow == null) return null;
            int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数

            for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
            {
                ICell cell = firstRow.GetCell(i);
                if (cell != null)
                {
                    string cellValue = cell.StringCellValue;
                    if (cellValue != null)
                    {
                        DataColumn column = new DataColumn(cellValue);
                        data.Columns.Add(column);
                    }
                }
            }

            //最后一列的标号
            int rowCount = sheet.LastRowNum;
            for (int i = 1; i <= rowCount; ++i)
            {
                IRow row = sheet.GetRow(i);
                DataRow dataRow = data.NewRow();
                for (int j = firstRow.FirstCellNum; j < cellCount; ++j)
                {
                    if (row != null && row.GetCell(j) != null) dataRow[j] = row.GetCell(j).ToString();
                }
                data.Rows.Add(dataRow);
            }

            return data;
        }

        public void SetCellValue(int r, int c, string v)
        {
            if (sheet == null) return;
            IRow row = sheet.GetRow(r);
            if (row == null) row = sheet.CreateRow(r);
            ICell col = row.GetCell(c);
            if (col == null) col = row.CreateCell(c);
            col.SetCellValue(v);
            Save();
        }

        public void RemoveRow(int r)
        {
            if (sheet == null) return;
            IRow row = sheet.GetRow(r);
            if (row == null) return;
            if (r < sheet.LastRowNum) sheet.ShiftRows(r + 2, sheet.LastRowNum, -1);
            Save();
        }

        void Save()
        {
            var fs = new FileStream(file, FileMode.Open);
            wb.Write(fs);
            fs.Close();
        }

        public void Dispose()
        {
        }
    }
}
