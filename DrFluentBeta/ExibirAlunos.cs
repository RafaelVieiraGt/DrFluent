using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace DrFluentBeta
{
    public partial class ExibirAlunos : Form
    {

        public string ProfName { get; set; }
        private Panel panel;
        private int CurrentTop = 10;


        public ExibirAlunos()
        {
            InitializeComponent();
            InitializePanel();

            this.MaximizeBox = false;
        }

        private void InitializePanel()
        {
            panel = new Panel
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(280, 300),
                AutoScroll = true
            };
            this.Controls.Add(panel);
        }

        private async void ExibirAlunos_Load(object sender, EventArgs e)
        {
            

            var db = FireStoreHelper.Database;
            CollectionReference alunosRef = db.Collection(ProfName);

            QuerySnapshot querySnapshot = await alunosRef.GetSnapshotAsync();



            foreach(DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.Exists)
                {
                    UserData data  = documentSnapshot.ConvertTo<UserData>();
                    ListBox listbox = new ListBox()
                    {
                        Location = new System.Drawing.Point(10, CurrentTop),
                        Size = new System.Drawing.Size(250,150),
                    };

                    Font font = new Font("Poppins", 10, FontStyle.Regular);
                    listbox.Font = font;

                        listbox.Items.Add($"Nome: {data.NomeAluno}");
                        listbox.Items.Add($"Email: {data.EmailAluno}");
                        listbox.Items.Add($"Telefone: {data.TelefoneAluno}");
                        listbox.Items.Add($"Nivel de Inglês: {data.NvlIng}");
                        listbox.Items.Add($"Score: {data.score}");
                        panel.Controls.Add(listbox);
                        CurrentTop += listbox.Height + 10;


                

                    
                }
            } 


        }
    }
}
