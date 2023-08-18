import { useState } from 'react';
import './selected.css';

 const SelectedField = (props) => {
    const { label } = props;

    const [value, setValue] = useState("");

    function handleChange(e){
        setValue(e.target.value)
    }
    return(
        <div className='box'>
            <div className='inputarea'>
                <label> {label} </label>
                <select value={value} onChange={handleChange}>
                    <option>option 1 </option>
                    <option>option 2 </option>
                    <option>option 3 </option>
                </select>
            </div>
            
        </div>
    )
}

export default SelectedField;