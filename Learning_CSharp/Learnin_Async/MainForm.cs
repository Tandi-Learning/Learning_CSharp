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

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{ShowDate()} Case A - getting message ... ");

            string message1 = await TaskReturnsStringAsync("Abby", 3);
            string message2 = await TaskReturnsStringAsync("Bob", 2);
            string message3 = await TaskReturnsStringAsync("Chris", 1);

            listBox1.Items.Add($"{ShowDate()} message received = {message1}");
            listBox1.Items.Add($"{ShowDate()} message received = {message2}");
            listBox1.Items.Add($"{ShowDate()} message received = {message3}");
            listBox1.Items.Add("---------------------------------------------");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{ShowDate()} Case B - getting message ... ");

            Task<string> t1 = TaskReturnsStringAsync("Abby", 3);
            Task<string> t2 = TaskReturnsStringAsync("Bob", 2);
            Task<string> t3 = TaskReturnsStringAsync("Chris", 1);

            await Task.WhenAll(t1, t2, t3);

            listBox1.Items.Add($"{ShowDate()} message received = {t1.Result}");
            listBox1.Items.Add($"{ShowDate()} message received = {t2.Result}");
            listBox1.Items.Add($"{ShowDate()} message received = {t3.Result}");
            listBox1.Items.Add("---------------------------------------------");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{ShowDate()} Case C - doing long task ... ");
            Task t = TaskReturnsNothingAsync();
            await t;

            listBox1.Items.Add($"{ShowDate()} Case C - finished long task ... ");
            listBox1.Items.Add("---------------------------------------------");

            listBox1.Items.Add("start DoSomethingAsync");
            // DoSomethingAsync returns void (fire and forget function) so don't need to be await-ed.
            TaskNotAwaitable();
            listBox1.Items.Add("return from DoSomethingAsync");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Abby Start. {DateTime.Now: hh:mm:ss.fff}");
            Task<string> t1 = TaskReturnsStringAsync("Abby", 6);
            listBox1.Items.Add($"Abby Return. {DateTime.Now: hh:mm:ss.fff}");

            listBox1.Items.Add($"Barbie Start. {DateTime.Now: hh:mm:ss.fff}");
            Task<string> t2 = TaskReturnsStringAsync("Barbie", 3);
            listBox1.Items.Add($"Barbie Return. {DateTime.Now: hh:mm:ss.fff}");
        }

        private async Task<string> TaskReturnsStringAsync(string sender, int delay)
        {
            await Task.Run(() => Thread.Sleep(delay * 1000)); //or await Task.Delay(delay * 1000);
            listBox1.Items.Add($"{sender} Finish. {DateTime.Now: hh:mm:ss.fff}");
            return $"Hello {sender}";
        }

        private Task TaskReturnsNothingAsync()
        {
            Task t = Task.Run(() => Thread.Sleep(2000));
            return t;
        }

        private async void TaskNotAwaitable()
        {            
            await Task.Run(() => Thread.Sleep(2000));
            listBox1.Items.Add("finished DoSomethingAsync");
            listBox1.Items.Add("---------------------------------------------");
        }

        private string ShowDate()
        {
            return $"{DateTime.Now.ToString("hh:mm:ss.fff")}";
        }
    }
}