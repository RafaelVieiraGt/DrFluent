import './login.css';
//IMAGES
import nuvemFeliz from '../../Assets/nuvemFeliz-removebg-preview 3.png';
import nuvemGrande from '../../Assets/nuvemChapeu.jpeg';
import { Link } from 'react-router-dom';
import { useState } from 'react';

export default function Login(){
    const [email, setEmail] = useState("");
    const [senha, setSenha] = useState("");
    return(
        <div className='container-login'>
            <div className='menu-login'>
                <div className='h1-login'>
                    <h1 id='nome1'>Fluent</h1>
                    <img src={nuvemFeliz} width={90} height={90} alt='Nuvem feliz'/>
                    <h1 id='nome2'>U</h1>
                </div>
                <span>
                    Bem-vindo/a de volta! <br/>Por favor faça login/Signup na sua conta.
                </span>
                <form>
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
                        <input 
                        type='password'
                        placeholder='******'
                        value={senha}
                        onChange={(e) => setSenha(e.target.value)}
                        />
                    </div>
                    <div>
                        <button type='submit'>Login</button>
                        <Link to='/register' className='register-btn'>Registrar</Link>
                    </div>
                    
                </form>
                
            </div>
            <div className='imagem-nuvem'>
                <img src={nuvemGrande} width={400} height={400} alt='Nuvem com chapéu'/>
            </div>
        </div>
    );
}
