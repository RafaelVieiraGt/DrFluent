import {createSlice} from '@reduxjs/toolkit'

const initialState = {
       exercicios: {
        question_category: "",
        question_difficulty: "",
        question_type: "",
       }
    }


export const exerciseSlice = createSlice({
    name: "exercicios",
    initialState,
    reducers: {
        changeCategory: (state, action) => {
    
            console.log(action.payload)
            return {
                ...state,
                exercicios:{
                    ...state.exercicios,
                    question_category: action.payload
                }
                
            }
        },
        changeDifficulty: (state, action) => {
            console.log(action.payload)
            
            return {
                ...state,    
                exercicios:{
                    ...state.exercicios,
                    question_difficulty:action.payload
                }
        
            }
        },
        changeType: (state, action) => {
            console.log(action.payload)
            
            return {
                ...state,
                exercicios:{
                    ...state.exercicios,
                    question_type: action.payload
                }
                
                
            }
        },
       
        }
    }
)

export default exerciseSlice.reducer;

export const {changeCategory, changeDifficulty, changeType, score} = exerciseSlice.actions