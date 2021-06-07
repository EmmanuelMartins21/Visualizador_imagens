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

namespace Visualizador_imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //jogo para um arquivo imagens de um diretorio
            string[] arquivos = Directory.GetFiles(@"C:\Users\marti\Desktop\EMMANUEL", "*.jpg*", SearchOption.AllDirectories);
            Image_ListBox1.Items.AddRange(arquivos);

            //Lendo arquivos favoritos
            string path = ObterNomeArquivoConfig();
            if(File.Exists(path))
            {
                var reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string arquivo = reader.ReadLine();
                    Fvoritos_ListBox1.Items.Add(arquivo);
                }
                reader.Close();
            }
        }

        private void Image_ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Image_ListBox1.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string ObterNomeArquivoConfig()
        {
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "imagensConfig.txt";
            string path = Path.Combine(pasta, arquivo);
            return path;
        }

        private void AdicionarFavoritos_Button1_Click(object sender, EventArgs e)
        {
            Fvoritos_ListBox1.Items.Add(Image_ListBox1.Text);
            // criando o arquivo com os favoritos
            string path = ObterNomeArquivoConfig();
            var writer = new StreamWriter(path);

            foreach(string arquivo in Fvoritos_ListBox1.Items)
            {
                writer.WriteLine(arquivo);//percorre o arquivo de favoritos e mostra no campus
            }
            writer.Close();

        }

        private void Fvoritos_ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Fvoritos_ListBox1.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fvoritos_ListBox1.SelectedItem != null)
            {
                string ItemSelecionado = Fvoritos_ListBox1.SelectedItem.ToString();
                Fvoritos_ListBox1.Items.Remove(ItemSelecionado);
            }
            else
            {
                Console.WriteLine("Favor selecione a imagem");
            }
           
        }
    }
}
