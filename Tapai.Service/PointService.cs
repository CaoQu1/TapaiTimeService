using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Tapai.Service
{
    public partial class PointService : ServiceBase
    {
        public PointService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Current.Instance.Start();
        }

        protected override void OnStop()
        {
            Current.Instance.Stop();
        }
    }
}
