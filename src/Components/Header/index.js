import './header.css';
import nuvemFeliz from '../../Assets/nuvemFeliz-removebg-preview 3.png';
import iconPessoa from '../../Assets/Group.svg';
import { signOut } from 'firebase/auth';
import { auth } from '../../Services/firebaseConnection';
import { useNavigate } from 'react-router-dom';

export default function Header(){
    const user = localStorage.getItem('@nome')
    const navigate = useNavigate();

    async function handleLogout(){
        await signOut(auth)
        localStorage.clear()
    }

    function backMenu(){
        navigate('/landing')
    }
    return(
       <header>
            <div className='header'>
                <div className='h1-login' onClick={backMenu}>
                    <h1 id='nomeHeader'>Dr</h1>
                    <img id='img-header' src={nuvemFeliz} width={45} height={45} alt='Nuvem feliz'/>
                    <h1 id='nomeHeader2'>Fluent</h1>
                </div>
                <div className='nome-perfil'>
                    <img src={iconPessoa} alt='Ícone de pessoa'/>
                    <span>{user}</span>
                    <button onClick={handleLogout}>Encerrar sessão</button>
                </div>
            </div>
            <div className='line'></div>
       </header>
    );
}