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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Firebase.Auth;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System.IO;
using Google.Cloud.Storage.V1;


namespace DrFluentBeta
{

    
    public partial class RegistroProf : Form
    {

        private FirebaseAuthProvider authProvider;
        private FirebaseAuthLink authlink;
        private FirebaseConfig firebaseconfig;
       



        public RegistroProf()
        {
            InitializeComponent();

            this.MaximizeBox = false;


        }

        

        private void buttonAqui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            RegistroForm form = new RegistroForm();
            form.ShowDialog();
            Close();
        }

        private async void EnviarButton2_Click(object sender, EventArgs e)
        {
            string nome = NomeBoxProf.Text.Trim();
            string email = EmailBox.Text.Trim();
            string senha = senhaBox.Text;

            

            

           

            var db = FireStoreHelper.Database;
            if(CheckIfUserAlreadyExist() == true)
            {
                MessageBox.Show("Usuário já existe");
                return;
            }
            var data = GetWriteData();
            var nomeProf = GetNomeData();


            DocumentReference docRef = db.Collection(data.Nome).Document("profData");
            DocumentReference docRef2 = db.Collection("nomesProf").Document(nomeProf.NomeProf);

          
            
            docRef.SetAsync(data);
            docRef2.SetAsync(nomeProf);




            
            MessageBox.Show($"Bem-Vindo/a, {nome}");
        }

        



       
        private bool CheckIfUserAlreadyExist()
        {
            string nome = NomeBoxProf.Text.Trim();
            string email = EmailBox.Text.Trim();
            string senha = senhaBox.Text;

            var db = FireStoreHelper.Database;
            DocumentReference docRef = db.Collection(nome).Document("profData");
            UserData1 data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData1>();

            if (data != null)
            {
                return true;

            }
            else
            {
                return false;
            }
            
        }

        private void NomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private NomeData GetNomeData()
        {
            string nome = NomeBoxProf.Text.Trim();

            return new NomeData()
            {
                NomeProf= nome,
            };
        }
        private UserData1 GetWriteData()
        {




            string nome = NomeBoxProf.Text.Trim();
            string email = EmailBox.Text.Trim();
            string senha = senhaBox.Text;
            

            return new UserData1()
            {
                Nome = nome,
                Email = email,
                Senha = senha,
                
            };
        }


        private void loginProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LoginProf form = new LoginProf();
            form.ShowDialog();
            Close();
        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RegistroProf_Load(object sender, EventArgs e)
        {

        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }

    

}
