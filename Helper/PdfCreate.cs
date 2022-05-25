using Entity.Concrete;
using Helper.FilePaths;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class PdfCreate
    {
        public static void CreatePdf(List<PolicePdfModel> data)
        {
            try { 
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(FilePath.PDFPATH+"Police.pdf", FileMode.Create));
            document.Open();
            Image image = Image.GetInstance(FilePath.FILEPATH+"logo.jpg");
            image.Alignment = Image.ALIGN_CENTER;
            document.Add(image);
                //BaseFont bf = BaseFont.CreateFont(
                //            BaseFont.TIMES_ROMAN,
                //            BaseFont.CP1257,
                //            BaseFont.EMBEDDED);

            BaseFont bf = BaseFont.CreateFont(
                        BaseFont.HELVETICA,
                        BaseFont.CP1252,
                        BaseFont.EMBEDDED);
            Font font = new Font(bf, 7);
            PdfPTable table = new PdfPTable(8);
            table.SpacingBefore = 25f;
            table.SpacingAfter = 25f;
            foreach (var item in data)
            {
                table.AddCell(new Phrase(item.KimlikNo, font));
                table.AddCell(new Phrase(item.Ad, font));
                table.AddCell(new Phrase(item.Soyad, font));
                table.AddCell(new Phrase(item.DogumYeri, font));
                table.AddCell(new Phrase(item.Uyruk, font));
                table.AddCell(new Phrase(item.UlkeAd, font));
                table.AddCell(new Phrase(item.UzunAd, font));
                table.AddCell(new Phrase(item.ZeylTip, font));
            }
            document.Add(table);
            document.Add(new Paragraph("©2021 Türkiye Hayat Emeklilik"));
            document.Add(new Paragraph("Telefon : +90(850) 202 20 20"));
            document.Add(new Paragraph("Levent Mah.Çayır Çimen Sok.No:7 34330 Levent - Beşiktaş / İSTANBUL"));
            document.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
