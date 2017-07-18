using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X.File.Ctrl
{
    public partial class DocView : UserControl
    {
        public DocView()
        {
            InitializeComponent();
        }


        ///// <summary>
        ///// 读取Word内容
        ///// </summary>
        ///// <param name="fileName"></param>
        ///// <returns></returns>
        //public string ReadWordText(string fileName)
        //{
        //    var doc = new StringBuilder();

        //    #region 打开文档
        //    XWPFDocument document = null;
        //    try
        //    {
        //        using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
        //        {
        //            document = new XWPFDocument(file);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        //LogHandler.LogWrite(string.Format("文件{0}打开失败，错误：{1}", new string[] { fileName, e.ToString() }));
        //    }
        //    #endregion

        //    #region 页眉、页脚
        //    doc.AppendLine("Capture Header Begin");
        //    foreach (XWPFHeader xwpfHeader in document.HeaderList)
        //    {
        //        doc.AppendLine(string.Format("{0}", new string[] { xwpfHeader.Text }));
        //    }
        //    doc.AppendLine("Capture Header End");


        //    doc.AppendLine("Capture Footer Begin");
        //    foreach (XWPFFooter xwpfFooter in document.FooterList)
        //    {
        //        doc.AppendLine(string.Format("{0}", new string[] { xwpfFooter.Text }));
        //    }
        //    doc.AppendLine("Capture Footer End");
        //    #endregion

        //    #region 表格
        //    doc.AppendLine("Capture Table Begin");
        //    foreach (XWPFTable table in document.Tables)
        //    {
        //        //循环表格行
        //        foreach (XWPFTableRow row in table.Rows)
        //        {
        //            foreach (XWPFTableCell cell in row.GetTableCells())
        //            {
        //                doc.Append(cell.GetText());
        //                //
        //                doc.Append("\r\n");//WordTableCellSeparator
        //            }

        //            doc.Append("\r\n");
        //        }
        //        doc.Append("\r\n");//WordTableSeparator
        //    }
        //    doc.AppendLine("Capture Table End");
        //    #endregion

        //    #region 图片
        //    doc.AppendLine("Capture Image Begin");
        //    foreach (XWPFPictureData pictureData in document.AllPictures)
        //    {
        //        string picExtName = pictureData.SuggestFileExtension();
        //        string picFileName = pictureData.FileName;
        //        byte[] picFileContent = pictureData.Data;
        //        string picTempName = string.Format("{0}", new string[] { Guid.NewGuid().ToString() + "_" + picFileName + "." + picExtName });
        //        using (FileStream fs = new FileStream(picTempName, FileMode.Create, FileAccess.Write))
        //        {
        //            fs.Write(picFileContent, 0, picFileContent.Length);
        //            fs.Close();
        //        }
        //        doc.AppendLine(picTempName);
        //    }
        //    doc.AppendLine("Capture Image End");
        //    #endregion

        //    //正文段落
        //    doc.AppendLine("Capture Paragraph Begin");
        //    foreach (XWPFParagraph paragraph in document.Paragraphs)
        //    {
        //        doc.AppendLine(paragraph.ParagraphText);
        //    }
        //    doc.AppendLine("Capture Paragraph End");

        //    return doc.ToString();
        //}
    }
}
