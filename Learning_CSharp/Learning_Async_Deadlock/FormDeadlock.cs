using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Async_Deadlock
{
    public partial class FormDeadlock : Form
    {
        public FormDeadlock()
        {
            InitializeComponent();
        }

        private void FormDeadlock_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private async void btnGetName_Click(object sender, EventArgs e)
        {
            var text = await ReadTextAsync();
            lblName.Text = text;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            var text = ReadHelloWorldAsync("world");
            lblBlockName.Text = text.Result;
        }

        private async Task<string> ReadTextAsync()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(6000));
            return "async succintly";
        }

        private static async Task<String> ReadHelloWorldAsync(string value)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(6000));
            return $"hello {value}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
        }


    }
}
