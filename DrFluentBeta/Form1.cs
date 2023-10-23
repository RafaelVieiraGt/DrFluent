using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;

namespace DrFluentBeta
{
    public partial class RegistroForm : Form
    {

        public string Username { get; set; }
        


        public RegistroForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

       

       


        private async void EnviarButton_Click(object sender, EventArgs e)
        {
            var db = FireStoreHelper.Database;
            var data = GetWriteData();

            

           DocumentReference docRef = db.Collection(Username).Document(data.NomeAluno);
            docRef.SetAsync(data);

           

            MessageBox.Show($"Aluno/a {data.NomeAluno} foi cadastrado com sucesso!");


           

            
        }

        private UserData GetWriteData()
        {
            string nome = NomeBox.Text.Trim();
            string email = EmailBox.Text.Trim();
            long telefone = Convert.ToInt64(TelefoneBox.Text);
            string nvlIng = nvlingBox.Text.Trim();
            int scoreAluno = 0;

            return new UserData()
            {
                NomeAluno = nome,
                EmailAluno = email,
                TelefoneAluno = telefone,
                NvlIng = nvlIng,
                score = scoreAluno

            };
        }

        

        private void nvlingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TelefoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            RegistroProf form = new RegistroProf();
            form.ShowDialog();
            Close();
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cadastroProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RegProf = new RegistroProf();
            RegProf.Show();
        }

        private void exibirAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exibirAlunos = new ExibirAlunos();
            exibirAlunos.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExibirAlunos exibirAlunos = new ExibirAlunos();
            exibirAlunos.ProfName = Username;

            exibirAlunos.Show();
        }

        private void buttonAlunos_Click(object sender, EventArgs e)
        {
            ExibirAlunos exibirAlunos = new ExibirAlunos();
            exibirAlunos.ProfName = Username;

            exibirAlunos.Show();
        }
    }
}
