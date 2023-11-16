import './score.css'
import 'react-toastify/dist/ReactToastify.css';

import Header from '../../Components/Header';
import brilho from '../../Assets/BrilhoHome.JPG';
import nuvem from '../../Assets/nuvemFeliz-removebg-preview 1.svg'

import { db } from '../../Services/firebaseConnection';
import { updateDoc, doc, getDoc } from 'firebase/firestore';
import { useEffect } from 'react';
import { toast, ToastContainer } from 'react-toastify';

export default function Score(){
    const score = parseInt(localStorage.getItem('@score'))
    const nome = localStorage.getItem('@nome')
    const nomeProf = localStorage.getItem('@nomeprof')
    

    useEffect(()=>{
        async function setScore(){
            const docRef = doc(db, nomeProf, nome);
            const docSnap = await getDoc(docRef);
            let scoreAtual = docSnap.data().score;
            await updateDoc(docRef, {
                score: (score + scoreAtual)
            })
            .then(()=> console.log("Score Computado"))
            .catch(()=> console.log("deu errado"))
        }

        setScore();
    },[])
    return( 
        <div className='div-config'>
            <Header/>
            <div className='cont-central'>
                <div className='title'>
                    <h1> Pontos de </h1>
                    <h1 id='nome'>{nome}</h1>
                </div>
                <div className='score'>
                    <div className='box-score'>
                        <span>Sua pontuação foi de: </span>
                        <h1>{score}</h1>
                    </div>
                
                <footer>
                    <img src={brilho} alt='brilho'/>
                    <img width={240} height={190} src={nuvem} alt='nuvem feliz'/>
                </footer>
                    
                </div>
            </div>
            <ToastContainer/>
        </div>
    );
}