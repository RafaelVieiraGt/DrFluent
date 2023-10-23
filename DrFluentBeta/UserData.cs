using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrFluentBeta
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string NomeAluno {  get; set; }
        [FirestoreProperty]
        public string EmailAluno { get; set; }
        [FirestoreProperty]
        public long TelefoneAluno { get; set; }
        [FirestoreProperty]
        public string NvlIng { get; set; }
        [FirestoreProperty]
        public int score { get; set; }
    }
}
