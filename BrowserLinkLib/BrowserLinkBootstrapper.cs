using Nancy;
using Nancy.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falys.BrowserLinkLib
{
	public class BrowserLinkBootstrapper : DefaultNancyBootstrapper
	{
		protected override void ConfigureConventions(NancyConventions nancyConventions)
		{
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts", @"Scripts"));
			base.ConfigureConventions(nancyConventions);
		}
	}

}
