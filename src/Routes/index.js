import { Routes, Route } from "react-router-dom";

import Home from "../Pages/Home";
import Login from "../Pages/Login";
import Register from "../Pages/Register";


export default function RoutesApp(){
    return(
        <Routes>
            <Route path="/" element={ <Login/> }/> 
            <Route path="/register" element={ <Register/> }/>
            <Route path="/landing" element={ <Home/> }/>
        </Routes>
    );
}