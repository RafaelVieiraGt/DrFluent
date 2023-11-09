import './register.css';
import 'react-toastify/dist/ReactToastify.css';


import nuvemFeliz from '../../Assets/nuvemFeliz-removebg-preview 1.svg';
import nuvemGrande from '../../Assets/nuvemChapeu.jpeg';
import { Link, useNavigate } from 'react-router-dom';
import { useState, useEffect } from 'react';
import { FaRegEyeSlash } from 'react-icons/fa';
import { toast, ToastContainer } from 'react-toastify';
import { setDoc, doc, getDoc, getDocs, collection} from 'firebase/firestore';


//autenticação
import { auth, db } from '../../Services/firebaseConnection';
import { createUserWithEmailAndPassword } from 'firebase/auth';



export default function Register(){
    const[nome, setNome] = useState("");
    const[nomeProf, setNomeProf] = useState("");
    const[nomesProfSelect, setNomesProfSelect] = useState([]);
    const[valueSelect, setValueSelect] = useState("");
    const[email, setEmail] = useState("");
    const[senha, setSenha] = useState("");
    const[view, setView] = useState("password");
    const navigate = useNavigate();

  useEffect(()=>{
    async function getNomeProf(){
       const nomesProfRef = collection(db, "nomesProf")
       
       await getDocs(nomesProfRef).then((querySnapshot)=>{
        const nomesList = [];
        querySnapshot.forEach((prof)=>{
            nomesList.push(prof.data().NomeProf)
        })
        setNomesProfSelect(nomesList)
       })
        
    }

    getNomeProf()
  },[])
console.log(nomesProfSelect)
    
    async function handleRegister(e){
        e.preventDefault();
        if(email !== '' && senha !== '' && valueSelect !== ''){
            await createUserWithEmailAndPassword(auth ,email, senha)
            .then(async (value)=>{
                let uid = value.user.uid
                await setDoc(doc(db, 'users', uid), {
                    nome: nome,
                    email: value.user.email,
                    nomeProf: valueSelect
                })
                .then(()=>{
                    
                    localStorage.setItem('@nome', nome);
                    localStorage.setItem('@nomeprof', valueSelect);
                    navigate('/landing')
                })
            })
            .catch((error)=>{

                const errorCode = error.code
                if(errorCode === "auth/email-already-in-use"){
                    toast.error("Esse email já é fluent! Faça login.")
                }
                if(errorCode === "auth/weak-password"){
                    toast.error("A sua senha deve haver pelo menos 6 caracteres")
                }
                if(errorCode === "auth/invalid-email"){
                    toast.error("Email inválido!")
                }
                console.log(error)
            })
        }else{
            toast.error('Preencha todos os campos!')
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
                        Entre pro time! <br/>Cadastre-se para ser Fluent!
                    </span>
                    <form onSubmit={handleRegister}>
                        <div className='inputarea'>
                            <label>Nome</label>
                            <input 
                            type='text'
                            placeholder='Seu Nome completo'
                            value={nome}
                            onChange={(e) => setNome(e.target.value)}
                            />
                        </div>
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
                        <div className='inputarea'>
                            <label>Nome da sua professora</label>
                            <select value={valueSelect} onChange={(e)=> setValueSelect(e.target.value)}>
                                <option value=''></option>
                                {nomesProfSelect.map((prof)=>(
                                    <option value={prof}>{prof}</option>
                                ))}
                            </select>
                        </div>
                        
                        <div>
                            <button type='submit'>Registrar</button>
                        </div>
                        <Link to='/' className='link-login'>Já possui uma conta? Faça Login!</Link>
                        
                    </form>
                
            </div>
            <div className='imagem-nuvem'>
                <img src={nuvemGrande} width={400} height={400} alt='Nuvem com chapéu'/>
            </div>
            <ToastContainer/>
        </div>
    );
}