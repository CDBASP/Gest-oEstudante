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

namespace Gest_oEstudante
{
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void FormInserirEstudante_Load(object sender, EventArgs e)
        {
            //FormInserirEstudante inserirEstudante = new FormInserirEstudante();
            // inserirEstudante.Show(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Selecionar a foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
            string nome = textboxNome.Text;
            string sobrenome = textboxSobrenome.Text;
            DateTime nacimento = dateTimePickerNacimento.Value;
            string telefone = textboxTelefone.Text;
            string endereco = textboxEndereco.Text;
            string genero = "Feminino";
            
            if (radioButtonFeminino.Checked)
            {
                genero = "masculino";
            }
            MemoryStream foto = new MemoryStream();
            int anoDenascimento = dateTimePickerNacimento.Value.Year;
            int anoAtual = DateTime.Now.Year;
            if ((anoAtual - anoDenascimento) < 10 ||
                (anoAtual - anoDenascimento) > 100
                )
            {
                MessageBox.Show("A idade precisa ser entre 10 e 100 anos!",
                    "idade invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificar())
            {
                pictureFoto.Image.Save(foto, pictureFoto.Image.RawFormat);
                if (estudante.inserirEstudantes(nome, sobrenome, nacimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Novo estudante cadastrado", "sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("erro", "inserir estudante",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

      

        bool verificar() 
        {
            if ((textboxNome.Text.Trim() == "") ||
                (textboxSobrenome.Text.Trim() == "") ||
                (textboxTelefone.Text.Trim() == "") ||
                (textboxEndereco.Text.Trim() == "") ||
                (pictureFoto.Image == null))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButtonMaculino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
