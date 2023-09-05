import { useState } from 'react';
import './selected.css';
import { useDispatch, useSelector } from 'react-redux';
import { changeCategory, changeDifficulty, changeType } from '../../../redux/exercise/slice';


 function SelectedField(props){
    const { label, options } = props;
    

    const [value, setValue] = useState("");
    const dispatch = useDispatch();
    
    function handleChange(e){
        setValue(e.target.value)
        switch(label) {
            case "Category":
                dispatch(changeCategory({
                    question_category: e.target.value
                }));
                break;
            case "Difficulty":
                dispatch(changeDifficulty({
                    question_difficulty: e.target.value
                }));
                break;
            case "Type":
                dispatch(changeType({
                    question_type: e.target.value
                }));
                break;

            default:
                return
            
        }
    }
    
    
    return(
        <div className='box'>
            <div className='inputarea'>
                <label> {label} </label>
                <select value={value} onChange={handleChange}>
                    {options.map(( {id, name} ) => (
                        <option value={id} key={id}>{name} </option>
                    ))}
                   
                </select>
            </div>
            
        </div>
    )
}

export default SelectedField;