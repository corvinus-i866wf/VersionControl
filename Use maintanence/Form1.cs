using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_maintanence
{
    public partial class Form1 : Form
    {
        BindingList<Entities.User> users = new BindingList<Entities.User>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.FirstName;
            label2.Text = Resource1.LastName;
            button1.Text = Resource1.Add;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new Entities.User()
            {
                LastName = textBox2.Text,
                FirstName = textBox1.Text
            };
            users.Add(u);
        }
    }
}
