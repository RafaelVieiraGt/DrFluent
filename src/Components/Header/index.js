import './header.css';
import nuvemFeliz from '../../Assets/nuvemFeliz-removebg-preview 3.png';
import iconPessoa from '../../Assets/Group.svg';

export default function Header(){
    return(
       <header>
            <div className='header'>
                <div className='h1-login'>
                    <h1 id='nomeHeader'>Dr</h1>
                    <img src={nuvemFeliz} width={45} height={45} alt='Nuvem feliz'/>
                    <h1 id='nomeHeader2'>Fluent</h1>
                </div>
                <div className='nome-perfil'>
                    <img src={iconPessoa} alt='Ícone de pessoa'/>
                    <span>Nome</span>
                </div>
            </div>
            <div className='line'></div>
       </header>
    );
}