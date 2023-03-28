using RazorLight;

namespace GerarHtml.Services.RazorLight
{
    public static class RazorLightExtensions
    {
        public static void AddRazorLight(this IServiceCollection services)
        {
            var razorProvider = new RazorEngineProvider
            {
                RazorLightEngine = new RazorLightEngineBuilder()
                    .UseEmbeddedResourcesProject(typeof(Program).Assembly, "GerarHtml.Views.Templates")
                    .UseMemoryCachingProvider()
                    .Build()
            };
            services.AddSingleton(razorProvider);
            //Console.WriteLine("Embeded");
        }
    }

}
