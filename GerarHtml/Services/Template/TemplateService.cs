using GerarHtml.Services.RazorLight;
namespace GerarHtml.Services.Template;

public class TemplateService : ITemplateService
{
    private readonly RazorEngineProvider _razorEngineProvider;
    public TemplateService(RazorEngineProvider razorEngineProvider)
    {
        _razorEngineProvider = razorEngineProvider;
    }
    public async Task<string> Parse<T>(T model)
        where T : ITemplate
    {
        return await _razorEngineProvider.RazorLightEngine.CompileRenderAsync(
            model.Key,
            model);
    }
}