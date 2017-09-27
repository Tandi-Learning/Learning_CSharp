using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learnin_Async
{
    public partial class StartCancel : Form
    {
        CancellationTokenSource cancelSource;

        public StartCancel()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            timer1.Stop();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            cancelSource = new CancellationTokenSource();
            string result = "Starting long task";
            lblTime.Text = result;
            try
            {
                result = await SuperLongTask(cancelSource.Token);
            }
            catch (OperationCanceledException c)
            {
                result = c.Message;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }            
            lblTime.Text = result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cancelSource != null)
                cancelSource.Cancel();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
        }

        private async Task<string> SuperLongTask(CancellationToken token)
        {
            await Task.Delay(4000, token);
            return "Complete SuperLongTask";
        }
    }
}