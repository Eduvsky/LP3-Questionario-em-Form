using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Handling
{

    public partial class LoginInterface : Form
    {
        List<string> Names = File.ReadAllLines(@"C:\Users\skyem\Documents\Code Projects\Visual studio\File Handling\Source\Users\Names.txt").ToList();
        List<string> Passwords = File.ReadAllLines(@"C:\Users\skyem\Documents\Code Projects\Visual studio\File Handling\Source\Users\Passwords.txt").ToList();
        Index x = new Index();

        public LoginInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questões x = new Questões();
            this.Hide();
            x.ShowDialog();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (Names.IndexOf(NameBox.Text) == Passwords.IndexOf(PasswordBox.Text) && Names.Contains(NameBox.Text))
            {
                MessageBox.Show("You're loged in");
                this.Hide();
                x.ShowDialog();
            }
                
            if (Names.IndexOf(NameBox.Text) != Passwords.IndexOf(PasswordBox.Text) || !Names.Contains(NameBox.Text))
                MessageBox.Show("Something went wrong try again");

            NameBox.Text = "";
            PasswordBox.Text = "";
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (Names.Contains(NameBox.Text))
            {
                MessageBox.Show("Nome Já usado");
            }

            if (!Names.Contains(NameBox.Text))
            {
                File.AppendAllText(@"C:\Users\skyem\Documents\Code Projects\Visual studio\File Handling\Source\Users\Names.txt", "\n" + NameBox.Text);
                File.AppendAllText(@"C:\Users\skyem\Documents\Code Projects\Visual studio\File Handling\Source\Users\Passwords.txt", "\n" + PasswordBox.Text); 
                MessageBox.Show("Pronto !");
            }
            NameBox.Text = "";
            PasswordBox.Text = "";
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }
    }
}
