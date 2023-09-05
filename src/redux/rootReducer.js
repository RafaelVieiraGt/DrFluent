import { combineReducers } from "redux";
import  exerciseSlice  from "./exercise/slice";

const rootReducer = combineReducers({
    exercicios: exerciseSlice
})

export default rootReducer