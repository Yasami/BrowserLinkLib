using Nancy;

namespace Falys.BrowserLinkLib
{
    public class ViewsModule : NancyModule
    {
        public ViewsModule()
        {
            var model = new LinkedPageModel { Title = "This is sample" };
            Get["/"] = parameters => new LinkedPage(model).TransformText();
        }
    }
}