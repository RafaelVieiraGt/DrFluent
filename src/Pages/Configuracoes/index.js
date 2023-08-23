import './config.css';
import SelectedField from '../../Components/Header/SelectedField';
import Header from '../../Components/Header';
import useAxios from '../../hooks/useAxios';
import { Link } from 'react-router-dom';
//PAG EM DESENVOLVIMENTO
export default function Settings(){
    const { response, error, loading } = useAxios({ url: "/api_category.php"})
    if(loading){
        return(
            <div className='container-settings'>
                <h1>Carregando opções...</h1>
            </div>
        )
    }

    if(error){
        console.log("algo deu errado")
    }
    function handleSubmit(e) {
        e.preventDefault();
    }

    const difficultyOptions = [
        {id: "easy", name: "Easy"},
        {id: "medium", name: "Medium"},
        {id: "hard", name: "Hard"},
    ]

    const typeOption = [
        {id: "multiple", name: "MultipleChoice"},
        {id: "boolean", name: "True/False"},
    ]
    return(
        <div className='div-config'>
            <Header/>
            <div className='container-settings'>
                <h1>Defina o melhor Quiz para você hoje!</h1>
                <form onSubmit={handleSubmit}>
                    <SelectedField options={response.trivia_categories} label="Categoria"/>
                    <SelectedField options={difficultyOptions} label="Dificuldade"/>
                    <SelectedField options={typeOption} label="Modalidade"/>
                </form>
                <Link to='/exercicios' className='btn-exercicios'>Começar</Link>
            </div>
        </div>
    )
}