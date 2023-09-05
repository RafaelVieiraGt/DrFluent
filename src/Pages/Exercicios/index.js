import './exercicios.css';
import Header from '../../Components/Header'
import brilhoFooter from '../../Assets/brilhoExercicios.PNG';
import useAxios from '../../hooks/useAxios';
import { useSelector } from 'react-redux';
import rootReducer from '../../redux/rootReducer';




export default function Exercicios(){

 const {exercicios} = useSelector(rootReducer => rootReducer.exercicios)
  
 console.log(exercicios);
 


    let apiUrl = `/api.php?amount=5&category=${exercicios.question_category.question_category}&difficulty=${exercicios.question_difficulty.question_difficulty}&type=${exercicios.question_type.question_type}`
    

    const { response, loading } = useAxios({url: apiUrl})
    console.log (response)


    
    return(
        <div className='div-config'>
          <Header/>
          <div className='container-exercicios'>
            <div className='titulo'>
                <h1>Titulo da pergunta</h1>
            </div>
            <div className='alternativas'>
                <div className='alt'>
                  <span>Alternativa 1</span>
                </div>
                <div className='alt'>
                  <span>Alternativa 1</span>
                </div>
                <div className='alt'>
                  <span>Alternativa 1</span>
                </div>
                <div className='alt'>
                  <span>Alternativa 1</span>
                </div>
            </div>
          </div>
          <footer>
            <img src={brilhoFooter}/>
            <div className='botoes-proxAnt'>
              <button>Anterior</button>
              <button>Próximo</button>
            </div>
          </footer>
        </div>
    );
}
