using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HeavyBoot.ServiceHost
{
    public partial class HBServiceHost : ServiceBase
    {
        private System.ServiceModel.ServiceHost host;
        public HBServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (host != null)
            {
                host.Close();
                host = null;
            }
            host = new System.ServiceModel.ServiceHost(typeof(WCFService.Service));

            Uri address = new Uri("http://localhost:8080/heavyboot");
            WSHttpBinding binding = new WSHttpBinding();
            Type connract = typeof(HeavyBoot.WCFService.IService);

            host.AddServiceEndpoint(connract, binding, address);

            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
                host.Close();
        }
    }
}
