using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace testconsolforms
{
    class MainWindow : Form
    {
        private MenuStrip mnuMainMenu = new MenuStrip();
        private ToolStripMenuItem mnuFile = new ToolStripMenuItem();
        private ToolStripMenuItem mnuExit = new ToolStripMenuItem();

        public MainWindow() { }
        public MainWindow(string title, int height, int width)
        {
            Text = title;
            Width = width;
            Height = height;
            CenterToScreen();

            BuildMenuSystem();
        }
        private void BuildMenuSystem()
        {
            mnuFile.Text = "&File";
            mnuMainMenu.Items.Add(mnuFile);


            mnuExit.Text = "&Exit";
            mnuFile.DropDownItems.Add(mnuExit);
            mnuExit.Click += (o, s) => Application.Exit();

            Controls.Add(this.mnuMainMenu);
            MainMenuStrip = this.MainMenuStrip;
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new MainWindow("MyLittleWindow", 300, 500));
        }
    }


}
