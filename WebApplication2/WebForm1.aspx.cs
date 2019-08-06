using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.text;
using org.apache.pdfbox.io;
using java.io;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String savePath = @"C:\upload";
            if (FileUpload1.HasFile)
            {
                String fileName = FileUpload1.FileName;
                savePath += fileName;
                FileUpload1.SaveAs(savePath);
            }

            java.io.File mfile = new File(savePath);
            PDDocument doc = PDDocument.load(mfile, MemoryUsageSetting.setupMainMemoryOnly());
            PDFTextStripper Stripper = new PDFTextStripper();
            Stripper.setSortByPosition(true);
            TextBox1.Text = (Stripper.getText(doc));
        }
    }
}