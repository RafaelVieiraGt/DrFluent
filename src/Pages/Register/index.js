import './register.css';

import nuvemFeliz from '../../Assets/nuvemFeliz-removebg-preview 3.png';
import nuvemGrande from '../../Assets/nuvemChapeu.jpeg';
import { Link } from 'react-router-dom';
import { useState } from 'react';

export default function Register(){
    const[nome, setNome] = useState("");
    const[email, setEmail] = useState("");
    const[senha, setSenha] = useState("");
    return(
        <div className='container-login'>
            <div className='menu-login'>
                <div className='h1-login'>
                    <h1 id='nome1'>Fluent</h1>
                    <img src={nuvemFeliz} width={90} height={90} alt='Nuvem feliz'/>
                    <h1 id='nome2'>U</h1>
                </div>
                <span>
                    Entre pro time! <br/>Cadastre-se para ser um Fluent!
                </span>
                <form>
                    <div className='inputarea'>
                        <label>Nome</label>
                        <input 
                        type='text'
                        placeholder='Seu Nome'
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
                        <input 
                        type='password'
                        placeholder='******'
                        value={senha}
                        onChange={(e) => setSenha(e.target.value)}
                        />
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
        </div>
    );
}