import { useState } from 'react';
import './selected.css';

 const SelectedField = (props) => {
    const { label, options } = props;

    const [value, setValue] = useState("");

    function handleChange(e){
        setValue(e.target.value)
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