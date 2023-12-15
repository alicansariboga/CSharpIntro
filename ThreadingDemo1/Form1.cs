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

namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Islem 1 calisti.");
            // For testing the system
            // example blocking the thread for 5 second and at this time, we can not do another thing.
            System.Threading.Thread.Sleep(5000);
            MessageBox.Show($"Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Islem 2 calisti.");
            MessageBox.Show($"Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
