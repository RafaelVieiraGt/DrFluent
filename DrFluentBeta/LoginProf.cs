using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrFluentBeta
{
    public partial class LoginProf : Form
    {
        public LoginProf()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private async void EnviarButton2_Click(object sender, EventArgs e)
        {
            RegistroForm alunos = new RegistroForm();
            alunos.Username = usernameBox.Text.Trim();

            ExibirAlunos exibirAlunos = new ExibirAlunos();
            exibirAlunos.ProfName = usernameBox.Text.Trim();

            string nome = usernameBox.Text.Trim();
            string senha = senhaBox.Text;

            var db = FireStoreHelper.Database;

            try
            {

                DocumentReference docRef = db.Collection(nome).Document("profData");
                UserData1 data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData1>();

                if (data != null)
                {
                    if (senha == data.Senha && nome == data.Nome)
                    {
                        MessageBox.Show($"Bem-Vindo/a de volta, {nome}");
                        alunos.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Nome ou senha incorreto!\nTente Novamente...");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
            catch
            {
                MessageBox.Show("Usuário não encontrado");
            }
            


           
            
        }

        private void cadastroProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            RegistroProf form = new RegistroProf();
            form.ShowDialog();
            Close();
        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            RegistroForm form = new RegistroForm();
            form.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void senhaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
