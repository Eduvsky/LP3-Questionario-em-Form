using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Handling
{
    public partial class Index : Form
    {
        string lp3path = @"C:\Users\skyem\Documents\Code Projects\Visual studio\File Handling\Source\Linguagem de Programação III";
        string lp4path = @"C:\Users\skyem\Documents\Code Projects\Visual studio\File Handling\Source\Linguagem de Programação IV";
        string bdpath = @"C:\Users\skyem\Documents\Code Projects\Visual studio\File Handling\Source\Banco de Dados";
        string pokemonspath = @"C:\Users\skyem\Documents\Code Projects\Visual studio\File Handling\Source\Pokemon";

        public Index()
        {
            InitializeComponent();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SendCadastroButton_Click(object sender, EventArgs e)
        {
            string disciplina = CadastroDisciplina.SelectedItem.ToString();
            string enunciado = CadastroEnunciadoBox.Text;
            string resolucao = ResolucaoTextBox.Text;
            string alternativacorreta = "";
            int aux = 1;
            string count = Convert.ToString(aux);

            foreach(Control x in AlternativaCorreta.Controls)
            {
                if (((RadioButton)x).Checked)
                    alternativacorreta = x.Text;
            }

            var dados = new List<string> { enunciado, TextBoxA.Text, TextBoxB.Text, TextBoxC.Text, TextBoxD.Text, TextBoxE.Text, resolucao, "", "", alternativacorreta };

            switch (disciplina)
            {
                case "Linguagem de Programação III":
                    {
                        if (!File.Exists(lp3path + @"\00" + count + ".txt"))
                        {
                            FileStream fs = File.Create(lp3path + @"\00" + count + ".txt");
                            File.WriteAllLines(lp3path + @"\00" + count + ".txt", dados);
                            aux++;
                        }
                        else
                        {
                            while (File.Exists(lp3path + @"\00" + count + ".txt"))
                            {
                                aux++;
                            }

                            FileStream fs = File.Create(lp3path + @"\00" + count + ".txt");
                            File.WriteAllLines(lp3path + @"\00" + count + ".txt", dados);
                        }
                        break;
                    }

                case "Linguagem de Programação IV":
                    {
                        if (!File.Exists(lp4path + @"\00" + count + ".txt"))
                        {
                            FileStream fs = File.Create(lp4path + @"\00" + count + ".txt");
                            File.WriteAllLines(lp4path + @"\00" + count + ".txt", dados);
                            aux++;
                        }
                        else
                        {
                            while (File.Exists(lp4path + @"\00" + count + ".txt"))
                            {
                                aux++;
                            }

                            FileStream fs = File.Create(lp4path + @"\00" + count + ".txt");
                            File.WriteAllLines(lp4path + @"\00" + count + ".txt", dados);
                        }
                        break;
                    }

                case "Banco de Dados":
                    {
                        if (!File.Exists(bdpath + @"\00" + count + ".txt"))
                        {
                            File.Create(bdpath + @"\00" + count + ".txt");
                            File.WriteAllLines(bdpath + @"\00" + count + ".txt", dados);
                            aux++;
                        }
                        else
                        {
                            while (File.Exists(bdpath + @"\00" + count + ".txt"))
                            {
                                aux++;
                            }

                            File.Create(bdpath + @"\00" + count + ".txt");
                            File.WriteAllLines(bdpath + @"\00" + count + ".txt", dados);
                        }
                        break;
                    }

                case "Pokemon":
                    {
                        if (!File.Exists(pokemonspath + @"\00" + count + ".txt"))
                        {
                            using(File.Create(pokemonspath + @"\00" + count + ".txt"))
                            {
                                File.WriteAllLines(pokemonspath + @"\00" + count + ".txt", dados);
                            }
                            aux++;
                        }
                        else
                        {
                            while ((File.Exists(pokemonspath + @"\00" + count + ".txt")) == true)
                            {
                                aux++;
                            }

                            using (File.Create(pokemonspath + @"\00" + count + ".txt"))
                            {
                                File.WriteAllLines(pokemonspath + @"\00" + count + ".txt", dados);
                            }
                        }
                        break;
                    }
            }

        }
    }
}
