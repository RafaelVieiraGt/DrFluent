import './config.css';
import SelectedField from '../../Components/Header/SelectedField';
import Header from '../../Components/Header';
import useAxios from '../../hooks/useAxios';
import { useNavigate } from 'react-router-dom';
import { useSelector } from 'react-redux';
import rootReducer from '../../redux/rootReducer';
import { useEffect, useState } from 'react';


export default function Settings(){
    const { exercicios } = useSelector(rootReducer => rootReducer.exercicios)
    const { response, error, loading } = useAxios({ url: "/api_category.php"})
    

    
    const category = exercicios.question_category.question_category;
    const difficulty = exercicios.question_difficulty.question_difficulty;
    const type = exercicios.question_type.question_type
    console.log(category, difficulty, type)
const navigate = useNavigate();
    const objectToAdd = { id: "any", name: " " };
    const [categories, setCategories] = useState([]);
    

    useEffect(() => {

        function loadApi(){
        if (!loading && !error && response && response.trivia_categories) {
           
                const categoryList = [...response.trivia_categories];
                categoryList.unshift(objectToAdd);
                setCategories(categoryList);
           
            }
        }
        loadApi();
        
    }, [loading, error, response])

    

    if(error){
        console.log("algo deu errado" + error)
    }

    function handleSubmit(e) {
        e.preventDefault();
       
        if( category && difficulty && type != "undefined" ){
            navigate('/exercicios')
        }else{
            alert("Preencha todos os campos!")
        }
        
    }
   
    if(loading){
        return(
            <div className='container-settings'>
                <h1>Carregando opções...</h1>
            </div>
        )
    }

    const difficultyOptions = [
        {id: "any", name: " "},
        {id: "easy", name: "Easy"},
        {id: "medium", name: "Medium"},
        {id: "hard", name: "Hard"},
    ]

    const typeOption = [
        {id: "any", name: " "},
        {id: "multiple", name: "MultipleChoice"},
        //{id: "boolean", name: "True/False"},
    ]
    
    return(
        <div className='div-config'>
            <Header/>
            <div className='container-settings'>
                <h1>Defina o melhor Quiz para você hoje!</h1>
                <form onSubmit={handleSubmit}>
                    <SelectedField options={categories} label="Category"/>
                    <SelectedField options={difficultyOptions} label="Difficulty"/>
                    <SelectedField options={typeOption} label="Type"/>
                    <button type='submit' className='btn-exercicios'>Começar</button>
                </form>
            </div>
        </div>
    )
}