﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Draw_Click(object sender, RibbonControlEventArgs e)
        {
            //画图功能已经做好了
            //已经做成一个静态类，只需调用DrawX就可以了
            UniqueExcelConsole.Draw.DrawX();
        }

        private void UploadQing_Click(object sender, RibbonControlEventArgs e)
        {
            //开一个新线程
            //for循环将 数据一条一条的上传

            for (int i = 2; i < 50; i++)
            {
                string[] data = CellSetFunctions.IndexForUploading(i);
                PostManToWeChat.PostDataToQing(data[0], data[1], data[2], data[3]);
                
            }
            Debug.WriteLine("所以数据上传完成");

        }
        

        private void CarMove_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void CarStop_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
