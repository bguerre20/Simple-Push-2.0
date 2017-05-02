using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePush
{
    public partial class NotifyWindow : Form
    {
        string message = "";
        public NotifyWindow(string Text)
        {
            InitializeComponent();
            this.richTextBox1.Text += Text + "\r\n\r\n";
            this.message = Text;
        }

        private void NotifyWindow_Load(object sender, EventArgs e)
        {
            //this.richTextBox1.Text += this.message;
        }

        private void parseMessage()
        {

        }
    }
}
