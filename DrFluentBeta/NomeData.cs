using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrFluentBeta
{
    [FirestoreData]
    internal class NomeData
    {
        [FirestoreProperty]
        public string NomeProf { get; set; }
        

    }
}
