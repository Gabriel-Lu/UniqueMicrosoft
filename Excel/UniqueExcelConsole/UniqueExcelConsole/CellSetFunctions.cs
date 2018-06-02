using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace UniqueExcelConsole
{
    public static class CellSetFunctions
    {
        public static void InsertSheet2RowData(int AirHumi, int AirTemp, int Light)
        {
            Globals.Sheet2.Range["A2"].EntireRow.Insert(XlInsertShiftDirection.xlShiftDown);
            Globals.Sheet2.Range["A2"].Value2 = AirTemp;
            Globals.Sheet2.Range["B2"].Value2 = AirHumi;
            Globals.Sheet2.Range["C2"].Value2 = Light;
        }
        public static void InsertSheet3RowData(string data)
        {
            string[] str = data.Split(',');
            if(str[0]==""||str[1]=="")
            {
                return;
            }
            Globals.Sheet3.Range["B2"].EntireRow.Insert(XlInsertShiftDirection.xlShiftDown);
            Globals.Sheet3.Range["B2"].Value2 = str[0];
            Globals.Sheet3.Range["D2"].Value2 = str[1];
            
        }


    }
}
