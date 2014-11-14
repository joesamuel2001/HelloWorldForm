using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World";
            lblHello.Text = "Hello World good morning";
            lblHello.Text = "Hello World, we're back";
            lblHello.Text = "Hello World, we're not done yet."; 
            lblHello.Text = "Hello World, text added from GitHub";
            lblHello.Text = "Hello World, another line added from GitHub";
            lblHello.Text = "Hello World, this line added from VS";
            lblHello.Text = "Hello World, another line added from VS 11:25am";       
            lblHello.Text = "Hello World, another line added from VS 11:35am";

        }
    }
}
