using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gest_oEstudante
{
    public partial class AtualizarDeletarEstudante : Form
    {
        Estudante Estudante = new Estudante();

        public AtualizarDeletarEstudante()
        {
            InitializeComponent();
        }

        private void AtualizarDeletarEstudante_Load(object sender, EventArgs e)
        {

        }

        private void ButonRemover(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Selecionar a foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
          // Estudante estudante = new Estudante();
            int id = Convert.ToInt32(textBoxID.Text);
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime nacimento = dateTimePickerNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string genero = "Feminino";

            if (radioButtonF.Checked)
            {
                genero = "masculino";
            }
            MemoryStream foto = new MemoryStream();
            int anoDenascimento = dateTimePickerNascimento.Value.Year;
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
                pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                if (Estudante.atualizarEstudante(id,nome, sobrenome, nacimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Informações atualizadas", "sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("erro", "inserir estudante",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            bool verificar()
            {
                if ((textBoxNome.Text.Trim() == "") ||
                    (textBoxSobrenome.Text.Trim() == "") ||
                    (textBoxTelefone.Text.Trim() == "") ||
                    (textBoxEndereco.Text.Trim() == "") ||
                    (pictureBoxFoto.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            MySqlCommand comando = new MySqlCommand("SELECT `id`,`nome`,`sobrenome`,`nascimento`,`genero`,`telefone`,`endereco`,`foto` FROM `estudantes id` WHERE `id` =" + id);



            DataTable tabela = Estudante.getEstudantes(comando);



            if (tabela.Rows.Count > 0)
            {
                textBoxNome.Text = tabela.Rows[0]["nome"].ToString();
                textBoxSobrenome.Text = tabela.Rows[0]["sobrenome"].ToString();
                dateTimePickerNascimento.Value = (DateTime)tabela.Rows[0]["nascimento"];
                textBoxTelefone.Text = tabela.Rows[0]["telefone"].ToString();
                textBoxEndereco.Text = tabela.Rows[0]["endereco"].ToString();
                if (tabela.Rows[0]["genero"].ToString() == "Feminino")
                {
                    radioButtonF.Checked = true;
                }
                else
                {
                    radioButtonM.Checked = false;
                }



                byte[] fotoDaTabela = (byte[])tabela.Rows[0]["foto"];
                MemoryStream fotoDaInterface = new MemoryStream(fotoDaTabela);
                pictureBoxFoto.Image = Image.FromStream(fotoDaInterface);
            }
        }
    }
}
