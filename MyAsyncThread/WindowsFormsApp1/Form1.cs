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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thread_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Thread start");
            ThreadStart theStart = () => this.DoSomethingLong("btn_threadClick");
            theStart.Invoke();
        }

        private void DoSomethingLong(string name)
        {
            Console.WriteLine($"{name} start {Thread.CurrentThread.ManagedThreadId.ToString("00")}{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            long lResult = 0;
            for (int i = 0; i < 10000000; i++)
            {
                lResult += i;
            }
            Console.WriteLine($"{name} end {Thread.CurrentThread.ManagedThreadId.ToString("00")}{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
        }
    }
}
