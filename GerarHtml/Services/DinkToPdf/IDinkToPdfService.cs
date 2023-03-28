namespace GerarHtml.Services.DinkToPdf;

public interface IDinkToPdfService
{
    public byte[] ConvertToPdf(string htmlContent);
}
