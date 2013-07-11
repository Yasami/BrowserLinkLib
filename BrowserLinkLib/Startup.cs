using Microsoft.AspNet.SignalR;
using Owin;

namespace Falys.BrowserLinkLib
{
	internal class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// Turn cross domain on 
			var config = new HubConfiguration
			{
				EnableCrossDomain = true,
				EnableJavaScriptProxies = true,
				EnableDetailedErrors = true
			};
			// This will map out to http://localhost:8080/signalr by default
			app.MapHubs(config);
			app.UseNancy();
		}
	}
}
