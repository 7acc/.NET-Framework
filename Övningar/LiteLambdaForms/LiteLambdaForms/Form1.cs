using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteLambdaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += async (sender, e) =>
            {
                await ExampleMethodAsync();
                textBox1.Text += "\r\nControl Returned To Click Event handler.\r\n";
            };
        }
        async Task ExampleMethodAsync()
        {
            await Task.Delay(1000);
        }
        
    }
}
