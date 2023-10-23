using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrFluentBeta
{

    [FirestoreData]
    public class UserData1
    {
        
        
            [FirestoreProperty]
            public string Nome { get; set; }
            [FirestoreProperty]
            public string Email { get; set; }
            [FirestoreProperty]
            public string Senha { get; set; }



        
    }
}
