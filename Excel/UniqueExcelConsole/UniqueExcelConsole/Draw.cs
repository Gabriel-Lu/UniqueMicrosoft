using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace UniqueExcelConsole
{
    public static class Draw
    {
        static Excel.Range range;

        /// <summary>
        /// 测试按钮：我选的啥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public static void DrawX()
        {

            range = Globals.Sheet1.Application.Selection;
            //把边上的颜色都涂成红色
            //range.Rows.Count
            //range.Columns.Count

            //先涂第一排
            //Colum用的是ABC，Row用的是数字
            DrawHorizon();
            DrawVertical();
        }

        //这是横着画
        static void DrawHorizon()
        {
            for (int i = range.Column; i < range.Columns.Count + range.Column; i++)
            {
                //Row(数字)不变，Colum用的字母（需要转化）

                string cellTop = Convert.ToChar(i + 64) + range.Row.ToString();

                //Globals.Sheet1.Range[cellTop]

                //BUG 当横行超过Z的时候，+64就直接变了。需要看到哪是Z然后减掉，再给后面用加上下一个字母
                Globals.Sheet1.Range[cellTop].Interior.Color = Color.Gold;

                string cellBottom = Convert.ToChar(i + 64) + (range.Rows.Count + range.Row - 1).ToString();
                Globals.Sheet1.Range[cellBottom].Interior.Color = Color.Gold;
            }
        }

        //这是画竖着的（缺头尾两格）
        static void DrawVertical()
        {
            for (int i = range.Row + 1; i < range.Rows.Count + range.Row - 1; i++)
            {
                //Row(数字)不变，Colum用的字母（需要转化）

                string cellLeft = Convert.ToChar(range.Column + 64) + i.ToString();
                Globals.Sheet1.Range[cellLeft].Interior.Color = Color.Gold;
                string cellRight = Convert.ToChar((range.Columns.Count + range.Column - 1) + 64) + i.ToString();
                Globals.Sheet1.Range[cellRight].Interior.Color = Color.Gold;
            }
        }


    }
}
