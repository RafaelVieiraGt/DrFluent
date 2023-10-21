import './exercicios.css';
import Header from '../../Components/Header'
import brilhoFooter from '../../Assets/brilhoExercicios.PNG';
import useAxios from '../../hooks/useAxios';
import { useSelector } from 'react-redux';
import { useState } from 'react';
import rootReducer from '../../redux/rootReducer';
import { useEffect } from 'react';
import { Link, useNavigate } from 'react-router-dom';

//toast
import { toast, ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';






export default function Exercicios(){

 const {exercicios} = useSelector(rootReducer => rootReducer.exercicios)
  

 


    let apiUrl = `/api.php?amount=6&category=${exercicios.question_category.question_category}&difficulty=${exercicios.question_difficulty.question_difficulty}&type=${exercicios.question_type.question_type}`
    
   
    const { response, loading } = useAxios({url: apiUrl})

    const [contador, setContador] = useState(0);
    const [contadorPags,setContadorPags] = useState(0)
    const [exe, setExe] = useState("");
    const [score, setScore] = useState(0);
    const [altCerta, setAltCerta] = useState("")
    const [alts, setAlts] = useState([]);
    const navigate = useNavigate()
 
    


   
    function shuffleArray(array) {
      for (let i = array.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
      }
    }

    useEffect(()=>{
      if(!loading && response && response.results){
        
        function loadApi(){
          const res = [...response.results]
          setExe(res[contador].question)
          setAlts([...res[contador].incorrect_answers, res[contador].correct_answer])
          setAltCerta(res[contador].correct_answer)
         
           
      }
      

      
      loadApi();
      
      
      }
      
      
        
    },[response, loading, contador])
    shuffleArray(alts)

    if(loading){
      return(
          <div className='container-settings'>
              <h1>Carregando Questões...</h1>
          </div>
      )
  }
    


  function submitAlt(event){
    const btn = event.id
    if(contador < 3 || contador > 3){
      if(btn === altCerta){
        setScore(score+10)
      }
      toast.info("Resposta registrada com sucesso!");
      setContador(contador+1);
      setContadorPags(contadorPags+1)
      
    }

    if (contador === 3){
      if(btn === altCerta){
        setScore(score+10)
      }
      toast.info("Resposta registrada com sucesso!");
      setContador(contador+1)
      setContadorPags(contadorPags+2)
      
    }
    
    
   
    
  }
  localStorage.setItem('@score',score)

  function handleProximo(){
    setContador(contador + 1)
    setContadorPags(contadorPags+1)
  }
  
    return(
        <div className='div-config'>
          <Header/>
          {contadorPags === 6 ? (
            <div className='finalizar-div'>
              <h1>Você chegou ao fim! We are all Fluent!</h1>
              <span>Deseja finalizar?</span>
              <Link to='/score'>Finalizar teste</Link>
            </div>
          ) : (
            <div className='container-exercicios'>
            <div className='titulo'>
                  <h1>{exe}</h1>
              </div>
              <div className='alternativas'>
                  {alts.map((alt)=>(
                    <div className='alt'>
                      <button onClick={(e) => {submitAlt(e.target)}} id={alt}>{alt}</button>
                    </div>
                  ))}
              </div>
          </div>
          )}
          
          <footer>
            <img src={brilhoFooter}/>
            <div className='botoes-proxAnt'>
              {contador === 0 ? (
                <span> </span>
              ) : (
                <button onClick={()=>{
                  setContador(contador - 1)
                  setContadorPags(contadorPags-1)
                }}>Anterior</button>
              )}
              
              {contadorPags < 4 ? (
                <button onClick={handleProximo}>Próximo</button>
              ) : (
                <span> </span>
              )}
              
            </div>
          </footer>
          <ToastContainer/>
        </div>
    );
}
