using DinkToPdf;

namespace Services.DinkToPdf;

public class DinkToPdfService
{
    public byte[] ConvertTest()
    {
        var converter = new SynchronizedConverter(new PdfTools());
        var doc = new HtmlToPdfDocument()
        {
            GlobalSettings = {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings() { Top = 10 },
               // Out = @"test.pdf",
            },
            Objects = {
                new ObjectSettings()
                {
                    Page = "http://google.com/",
                },
            }
        };
        //Console.WriteLine(converter.Convert(doc)); 
        byte[] pdf = converter.Convert(doc);
        return pdf;
    }
}

