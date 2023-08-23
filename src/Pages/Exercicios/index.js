import './exercicios.css';
import Header from '../../Components/Header'


export default function Exercicios(){
    
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
        </div>
    );
}
