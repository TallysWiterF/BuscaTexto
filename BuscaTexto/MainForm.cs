using BuscaTexto.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BuscaTexto
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private BuscarPalavraForm segundo = new BuscarPalavraForm();

        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Arquivo.Image = Resources.Collapse_Arrow_20px;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Arquivo.Image = Resources.Expand_Arrow_20px;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }

        }
        private void Arquivo_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Novo_Click(object sender, EventArgs e)
        {
            texto.Text = "";
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            // Caixa de diálogo de abrir arquivo com filtro para extensão txt e rtf 
            string nome;
            OpenFileDialog Escrita = new OpenFileDialog();
            Escrita.Title = "Open Text File";
            Escrita.Filter = "TXT files|*.txt|RTF files|*.rtf";
            if (Escrita.ShowDialog() == DialogResult.OK)
            {
                nome = Escrita.FileName;
                Stream fileEscrita = Escrita.OpenFile();

                if (fileEscrita != null)
                {
                    texto.Text = File.ReadAllText(nome, Encoding.Default);
                }
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isCollapsed2;
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                Pesquisar.Image = Resources.Collapse_Arrow_20px;
                panelDropDown2.Height += 10;
                if (panelDropDown2.Size == panelDropDown2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                Pesquisar.Image = Resources.Expand_Arrow_20px;
                panelDropDown2.Height -= 10;
                if (panelDropDown2.Size == panelDropDown2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }
        private void Pesquisar_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }


        private void Força_Bruta_Click(object sender, EventArgs e)
        {
            texto.SelectionStart = 0;
            texto.SelectionLength = texto.Text.Length;
            texto.SelectionBackColor = Color.FromArgb(45, 45, 47);
            segundo.ShowDialog();
            try
            {
                if (segundo.x == true)
                { 
                    ForcaBruta.forcaBruta(segundo.p.ToLower(), texto.Text.ToLower(), texto);
                }
                else
                { 
                    ForcaBruta.forcaBruta(segundo.p, texto.Text, texto);
                }
            }
            catch (Exception)
            {}
        }
        private void Rabin_Karp_Click(object sender, EventArgs e)
        {
            texto.SelectionStart = 0;
            texto.SelectionLength = texto.Text.Length;
            texto.SelectionBackColor = Color.FromArgb(45, 45, 47);
            segundo.ShowDialog(); 
            try
            {                      
                if (segundo.x == true)
                {                      //Inserindo " " na posição 0 para que o metodo funcione 
                    RabinKarp.RKSearch(segundo.p.ToLower(), texto.Text.Insert(0, " ").ToLower(), texto);
                }
                else
                {
                    RabinKarp.RKSearch(segundo.p, texto.Text.Insert(0, " "), texto);
                }
            }
            catch (Exception)
            {}
        }

        private void KMP_Click(object sender, EventArgs e)
        {
            texto.SelectionStart = 0;
            texto.SelectionLength = texto.Text.Length;
            texto.SelectionBackColor = Color.FromArgb(45, 45, 47);
            segundo.ShowDialog();
            try
            {
                if (segundo.x == true)
                {
                    KMP.KMPSearch(segundo.p.ToLower(), texto.Text.ToLower(), texto);
                }
                else
                {
                    KMP.KMPSearch(segundo.p, texto.Text, texto);
                }
            
            }
            catch (Exception)
            {}
        }

        private void Boyer_Moore_Click(object sender, EventArgs e)
        {
            texto.SelectionStart = 0;
            texto.SelectionLength = texto.Text.Length;
            texto.SelectionBackColor = Color.FromArgb(45, 45, 47);
            segundo.ShowDialog();
            try
            {
                if (segundo.x == true)
                {
                   BoyerMoore.BMSearch(segundo.p.ToLower(), texto.Text.ToLower(), texto);
                }
                else
                {
                    BoyerMoore.BMSearch(segundo.p, texto.Text, texto);
                }

            }
            catch (Exception)
            { }
        }

        private bool isCollapsed3;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                Ajuda.Image = Resources.Collapse_Arrow_20px;
                panelDropDown3.Height += 10;
                if (panelDropDown3.Size == panelDropDown3.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                Ajuda.Image = Resources.Expand_Arrow_20px;
                panelDropDown3.Height -= 10;
                if (panelDropDown3.Size == panelDropDown3.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed3 = true;
                }
            }
        }

        private void Ajuda_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
              "Busca em Texto - 2020/1\n\nDesenvolvido por:\n 71900624 -Matheus Henrique Moreira Braz \n 71900489 -Tallys Witer Fernandes dos Reis\nProf. Virgílio Borges de Oliveira\n\nAlgoritmos e Estruturas de Dados II\nFaculdade COTEMIG\nSomente para fins didáticos.",
              "Sobre o trabalho...",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
        }
    }
}
