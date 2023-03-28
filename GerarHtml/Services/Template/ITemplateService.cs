namespace GerarHtml.Services.Template;

public interface ITemplateService
{
    public Task<string> Parse<T>(T model) where T : ITemplate;
}
