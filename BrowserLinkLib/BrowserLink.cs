using System;
using Microsoft.Owin.Hosting;
using Microsoft.AspNet.SignalR;

namespace Falys.BrowserLinkLib
{
    public class BrowserLink : IDisposable
    {
        private const string DefaultScheme = @"http";

        private const string DefaultHost = @"localhost";

        private const int DefaultPort = 8080;

        private readonly int _port;
        private IDisposable _webApp;

        public Uri Url { get; private set; }

        public BrowserLink(string scheme = DefaultScheme, string host = DefaultHost, int port = DefaultPort)
        {
            _port = port;
            Url = new Uri(scheme + "://" + host + ":" + port);
        }

        public void Start()
        {
            var startOptions = new StartOptions() { Port = _port };
            _webApp = WebApp.Start<Startup>(startOptions);
        }

        public void Send(string msg)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<BrowserLinkHub>();
            context.Clients.All.SendMessage(msg);
        }

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing && (_webApp != null))
            {
                _webApp.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
