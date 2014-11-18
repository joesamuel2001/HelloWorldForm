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
            lblHello.Text = "Hello World, another line added from VS at 11:40";
            lblHello.Text = "Hello World, another line added from GitHub 11:50am";
            lblHello.Text = "Hello World, another line added from VS at 11:55am";
            lblHello.Text = "Hello World, adding another line of code from home VS clone @ 5:15pm";
            lblHello.Text = "Hello World, adding line from Git to home VS @ 5:21pm";
            lblHello.Text = "Hello World, adding line from VS to Git @ 10:55am";
            lblHello.Text = "Hello World, adding line from VS to Git @ 11:38am";
            lblHello.Text = "Hello World, adding line from Git to VS from home @ 9:14pm";     
        }        
    }
}
