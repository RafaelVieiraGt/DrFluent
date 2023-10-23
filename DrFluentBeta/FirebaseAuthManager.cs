using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;

namespace DrFluentBeta
{
    public class FirebaseAuthManager
    {
        private readonly FirebaseAuthProvider authProvider;

            public FirebaseAuthManager()
            {
                authProvider = new FirebaseAuthProvider(new FirebaseConfig("sua-chave-de-api-do-firebase"));
            }

            public async Task<string> CreateUserAsync(string email, string senha)
            {
                try
                {
                    var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(email, senha);

                    // O UID do usuário criado.
                    return auth.User.LocalId;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao criar o usuário: {ex.Message}");
                    return null;
                }
            }
    }
}
