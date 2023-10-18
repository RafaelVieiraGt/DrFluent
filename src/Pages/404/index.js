import './404.css';
import { Link } from 'react-router-dom';
//Images
import brilho from '../../Assets/brilho404.PNG';
import nuvemTriste from '../../Assets/NuvemTriste404.PNG';


export default function Erro404(){
    return(
        <div className='pagError'>
            <div className='error-content'>
                <div className='imagem'>
                    <h1>404</h1>
                    <img src={nuvemTriste} alt='Fluent triste'/>
                </div>
                <span>Ops... Pagina não encontrada</span>
                <Link to={'/'}>Voltar para o início</Link>
            </div>
            
            <footer>
                <img src={brilho} alt='brilho'/>
            </footer>
        </div>
    );
}