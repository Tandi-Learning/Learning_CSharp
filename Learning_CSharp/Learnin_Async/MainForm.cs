using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learnin_Async
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudyCaseA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudyCaseB();
        }

        private async void StudyCaseA()
        {
            listBox1.Items.Add($"{DateTime.Now.ToString("hh:mm:ss.fff")} getting message ... ");
            string message1 = await GetMessagesAsync("Abby", 3);
            string message2 = await GetMessagesAsync("Bob", 2);
            string message3 = await GetMessagesAsync("Chris", 1);
            listBox1.Items.Add($"{DateTime.Now.ToString("hh:mm:ss.fff")} message received = {message1}");
            listBox1.Items.Add($"{DateTime.Now.ToString("hh:mm:ss.fff")} message received = {message2}");
            listBox1.Items.Add($"{DateTime.Now.ToString("hh:mm:ss.fff")} message received = {message3}");
            listBox1.Items.Add("---------------------------------------------");
        }

        private async void StudyCaseB()
        {
            listBox1.Items.Add($"{DateTime.Now.ToString("hh:mm:ss.fff")} getting message ... ");
            Task<string> t1 = GetMessagesAsync("Abby", 3);
            Task<string> t2 = GetMessagesAsync("Bob", 2);
            Task<string> t3 = GetMessagesAsync("Chris", 1);
            await t1;
            await t2;
            await t3;
            listBox1.Items.Add($"{DateTime.Now.ToString("hh:mm:ss.fff")} message received = {t1.Result}");
            listBox1.Items.Add($"{DateTime.Now.ToString("hh:mm:ss.fff")} message received = {t2.Result}");
            listBox1.Items.Add($"{DateTime.Now.ToString("hh:mm:ss.fff")} message received = {t3.Result}");
            listBox1.Items.Add("---------------------------------------------");
        }

        private async Task<string> GetMessagesAsync(string sender, int delay)
        {
            //await Task.Delay(delay * 1000);
            Task t = new Task(() => Thread.Sleep(delay * 1000));
            t.Start();
            await t;
            return $"Hello {sender}";
        }
    }
}