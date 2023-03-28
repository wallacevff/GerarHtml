using GerarHtml.Services.Template;

namespace GerarHtml.Models;

public class ViewModel : ITemplate
{
    public string Key { get; set; }
    public string Name { get; set; }

    public ViewModel(string Key, string name)
    {
        this.Key = Key;
        Name = name;
    }
}
