using DinkToPdf;
using System;

namespace GerarHtml.Services.DinkToPdf;

public static class DinkToPdfExtension
{
    public static void AddDinkToPdf(this IServiceCollection services)
    {
        DinkToPdfEngineProvider dinktopdf = new DinkToPdfEngineProvider()
        {
            Converter = new SynchronizedConverter(new PdfTools())
        };
        services.AddSingleton(dinktopdf);
    }
}

