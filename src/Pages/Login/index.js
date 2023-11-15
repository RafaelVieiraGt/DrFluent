import './login.css';
import 'react-toastify/dist/ReactToastify.css';
//IMAGES
import nuvemFeliz from '../../Assets/nuvemFeliz-removebg-preview 1.svg';
import nuvemGrande from '../../Assets/nuvemChapeu.png';
import { Link, useNavigate } from 'react-router-dom';
import { useState } from 'react';
import { doc, getDoc } from 'firebase/firestore';
import { FaRegEyeSlash } from 'react-icons/fa';
//autenticação
import { auth, db } from '../../Services/firebaseConnection';
import { signInWithEmailAndPassword } from 'firebase/auth';
import { toast, ToastContainer } from 'react-toastify';


export default function Login(){
    const [email, setEmail] = useState("");
    const [senha, setSenha] = useState("");
    const [view, setView] = useState("password")
    const navigate = useNavigate()

    async function handleLogin(e){
        e.preventDefault();

        if(email !== '' && senha !== ''){
            await signInWithEmailAndPassword(auth, email, senha)
            .then(async (value)=>{
                let uid = value.user.uid
                const docRef = doc(db, "users", uid);
                const docSnap = await getDoc(docRef);
                let data = docSnap.data().nome
                let nomeProf = docSnap.data().nomeProf
                localStorage.setItem('@nome', data)
                localStorage.setItem('@nomeprof', nomeProf)
                navigate('/landing')
                
            })
            .catch(()=>{
                toast.error("Erro ao entrar! Verifique suas credenciais.")
            })
        }else{
            toast.error("Preencha todos os campos!")
        }
    }

    function viewPasswd(){
        if(view === 'password'){
            setView("text")
        }
        if(view === 'text'){
            setView("password")
        }
    }
   
    return(
        <div className='container-login'>
            <div className='menu-login'>
                <div className='h1-login'>
                    <h1 id='nome1'>Dr</h1>
                    <img src={nuvemFeliz} width={115} height={115} alt='Nuvem feliz'/>
                    <h1 id='nome2'>Fluent</h1>
                </div>
                <span>
                    Bem-vindo/a de volta! <br/>Por favor faça login/Signup na sua conta.
                </span>
                <form onSubmit={handleLogin}>
                    <div className='inputarea'>
                        <label>E-mail</label>
                        <input 
                        type='text'
                        placeholder='Digite seu Email'
                        value={email}
                        onChange={(e) => setEmail(e.target.value)}
                        />
                    </div>
                    <div className='inputarea'>
                        <label>Senha</label>
                        <div className='inputSenha'>
                            <input 
                                type={view}
                                placeholder='******'
                                value={senha}
                                onChange={(e) => setSenha(e.target.value)}
                                />
                                <FaRegEyeSlash color='#235789' onClick={viewPasswd} size={20} cursor='pointer' />
                       </div>
                        
                    </div>
                    <div className='btnRespo'>
                        <button type='submit'>Login</button>
                        <Link to='/register' className='register-btn'>Registrar</Link>
                    </div>
                    
                </form>
                
            </div>
            <div className='imagem-nuvem'>
                <img src={nuvemGrande} width={400} height={400} alt='Nuvem com chapéu'/>
            </div>
            <ToastContainer/>
        </div>
    );
}
