using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tapai.Service.WinForm
{
    public partial class Main : Form
    {
        private static ServiceController serviceController = new ServiceController("TapaiUserPoint");

        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var text = this.btnStart.Text;
                if (text == "启动服务")
                {
                    this.btnStart.Text = "停止服务";
                    serviceController.Start();
                    this.txtResult.Text = "服务已启动~";
                }
                else
                {
                    this.btnStart.Text = "启动服务";
                    serviceController.Stop();
                    this.txtResult.Text += "服务已停止~";
                }
            }
            catch (Exception ex)
            {
                this.btnStart.Text = "启动服务";
                this.txtResult.Text += ex.Message;
            }
        }
    }
}
