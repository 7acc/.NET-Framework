using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anonymous_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Button btnhello = new Button();
            btnhello.Text = "Get in hes face!";
            btnhello.Width = 200;

            btnhello.Click +=
                delegate
                {
                    if(btnhello.Text != "Hello")
                    {
                        Environment.Exit(1);
                    }
                    MessageBox.Show("Get out of my face!");                 
                    btnhello.Text = "get out of hes face!";            
                };
            
            Controls.Add(btnhello);
        
        }
    }
}
