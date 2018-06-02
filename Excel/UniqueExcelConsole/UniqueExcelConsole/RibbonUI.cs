using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace UniqueExcelConsole
{
    public partial class RibbonUI
    {
        private void RibbonUI_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Connect_Click(object sender, RibbonControlEventArgs e)
        {
            //可以开始通信了
            SocketConnect.SocketBind();
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //CellSetFunctions.InsertRowData("A", "B", "C", "D");
        }
    }
}
