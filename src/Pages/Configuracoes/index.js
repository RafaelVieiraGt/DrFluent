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
    
    
    const category = exercicios.question_category.question_category;
    const difficulty = exercicios.question_difficulty.question_difficulty;
    const type = exercicios.question_type.question_type
    console.log(category, difficulty, type)

    const navigate = useNavigate();
    
    
   

   

    function handleSubmit(e) {
        e.preventDefault();
       
        if( category && difficulty && type != "undefined" ){
            navigate('/exercicios')
        }else{
            alert("Preencha todos os campos!")
        }
        
    }
   
    /*if(loading){
        return(
            <div className='container-settings'>
                <h1>Carregando opções...</h1>
            </div>
        )
    }*/
    const categories = [
        {id: "any", name: " "},
        {id: "simple_present", name: "Simple Present"},
        {id: "present_continuous", name: "Present Continuous"},
        {id: "present_perfect", name: "Present Perfect"},
        {id: "simple_past", name: "Simple Past"},
        {id: "past_continuous", name: "Past Continuous"},

    ]
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