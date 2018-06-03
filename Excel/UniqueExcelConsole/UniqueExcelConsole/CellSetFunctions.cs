using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
            if (str[0] == "" || str[1] == "")
            {
                return;
            }
            Globals.Sheet3.Range["B2"].EntireRow.Insert(XlInsertShiftDirection.xlShiftDown);
            Globals.Sheet3.Range["B2"].Value2 = str[0];
            Globals.Sheet3.Range["D2"].Value2 = str[1];//小车离墙的距离
            int dis = int.Parse(str[1]);

            switch(dis/8)
            {
                case 0:
                    Globals.Sheet1.Range["B18", "C18"].Interior.Color = Color.Blue;
                    break;
                case 1:
                    Globals.Sheet1.Range["E18", "G18"].Interior.Color = Color.Blue;
                    break;
                case 2:
                 
                    Globals.Sheet1.Range["H18", "J18"].Interior.Color = Color.Blue;
                    break;
                case 3:
                 
                    Globals.Sheet1.Range["K18", "M18"].Interior.Color = Color.Blue;
                    break;
                case 4:
                 
                    Globals.Sheet1.Range["N18", "P18"].Interior.Color = Color.Blue;
                    break;
                default:
                    Debug.WriteLine("Sth wrong happend");
                    break;
            }
           

        }
        public static string[] IndexForUploading(int index)
        {
            string[] data = new  string[4];
            //横排的字母不变依然是ABCD
            //Sheet2的ABC，Sheet3的B

            string s0 = Globals.Sheet2.Range[string.Concat("A", index)].FormulaR1C1;
            string s1 = Globals.Sheet2.Range[string.Concat("B", index)].FormulaR1C1;
            string s2 = Globals.Sheet2.Range[string.Concat("C", index)].FormulaR1C1;
            string s3 = Globals.Sheet3.Range[string.Concat("B", index)].FormulaR1C1;

            data[0] = s0;
            data[1] = s1;
            data[2] = s2;
            data[3] = s3;
            return data;
        }


    }
}
