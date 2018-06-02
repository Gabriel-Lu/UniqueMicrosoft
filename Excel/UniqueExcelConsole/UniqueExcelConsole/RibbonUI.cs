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
            AIActionPane aiAction = new AIActionPane();
            Globals.ThisWorkbook.ActionsPane.Controls.Add(aiAction);
            Globals.ThisWorkbook.ActionsPane.Name = "Acc";

        }

        private void Connect_Click(object sender, RibbonControlEventArgs e)
        {
            //可以开始通信了
            SocketConnect.SocketBind();
        }

       

        private void AI_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = !Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane;
        }
    }
}
