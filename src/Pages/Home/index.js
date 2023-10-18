import './home.css';
import 'react-toastify/dist/ReactToastify.css';
import Header from '../../Components/Header';
import figura1 from '../../Assets/nuvemHome.JPG';
import brilho from '../../Assets/BrilhoHome.JPG';

import { Link } from 'react-router-dom';
import { useEffect } from 'react';
import { toast, ToastContainer } from 'react-toastify';
export default function Home(){
    useEffect(()=>{
           toast.success("Bem vindo ao DrFluent!")
    },[])
    return(
        <div className='body-home'>
            <Header/>
            <main>
                <div className='conteudo-home'>
                    <div className='txt-home'>
                        <h1>Aprenda <br/>inglês de forma <br/>didática e divertida</h1>
                        <span>Treine seu conhecimento com diversos temas atuais!</span>
                        <Link to='/settings' className='btn-exercicios'>Começar teste</Link>
                    </div>
                    <div className='img-brilho'>
                        <img src={brilho} alt='brilho'/>
                    </div>
                </div>
                <div className='nuvem-img'>
                    <img src={figura1} alt='figura de nuvem'/>
                </div>
            </main>
            <ToastContainer/>
        </div>
    );
}