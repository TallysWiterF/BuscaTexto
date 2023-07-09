using MaterialSkin;
using System;

namespace BuscaTexto
{
    public partial class BuscarPalavraForm : MaterialSkin.Controls.MaterialForm
    {
        public BuscarPalavraForm()
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);


        }
        public string p;
        public bool x;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (Case_Sensitive.Checked)
            {
                x = false;
            }
            else
            {
                x = true;
            }
            p = materialSingleLineTextField1.Text;
            Close();
        }

    }
}
