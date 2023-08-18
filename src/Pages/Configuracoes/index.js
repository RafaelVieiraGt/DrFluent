import './config.css';
import SelectedField from '../../Components/Header/SelectedField';
import Header from '../../Components/Header';
import useAxios from '../../hooks/useAxios';
import { Link } from 'react-router-dom';
//PAG EM DESENVOLVIMENTO
export default function Settings(){
    const { response, error, loading } = useAxios({ url: "/api_category.php"})
    console.log(response) 
    function handleSubmit(e) {
        e.preventDefault();
    }
    return(
        <div id='div-config'>
            <Header/>
            <div className='container-settings'>
                <h1>Defina o melhor Quiz para você hoje!</h1>
                <form onSubmit={handleSubmit}>
                    <SelectedField label="Categoria"/>
                    <SelectedField label="Dificuldade"/>
                    <SelectedField label="Modalidade"/>
                </form>
                <Link to='/exercicios' className='btn-exercicios'>Começar</Link>
            </div>
        </div>
    )
}