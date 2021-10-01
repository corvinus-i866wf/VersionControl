using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            button2.Text = Resource1.Write;
            button3.Text = Resource1.Del;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new Entities.User()
            {
                FullName = string.Join(textBox1.Text, textBox2.Text)
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using(StreamWriter sw= new StreamWriter(sfd.FileName,false,Encoding.UTF8))
            {
                foreach(var s in users)
                {
                    sw.Write(s.ID);
                    sw.Write(";");
                    sw.Write(s.FullName);
                    sw.Write(";");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                
                foreach (var s in users)
                {
                    users.Remove(s);
                }
            }

        }
    }
}
