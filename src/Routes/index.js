import { Routes, Route } from "react-router-dom";

import Home from "../Pages/Home";
import Login from "../Pages/Login";
import Register from "../Pages/Register";
import Exercicios from "../Pages/Exercicios";
import Configuracoes from "../Pages/Configuracoes";
import Score from "../Pages/Score";
import Erro404 from "../Pages/404";

import Private from "./private";


export default function RoutesApp(){
    return(
        <Routes>
            <Route path="/" element={ <Login/> }/> 
            <Route path="/register" element={ <Register/> }/>
            <Route path="/landing" element={ <Private><Home/></Private> }/>
            <Route path="/settings" element={ <Private><Configuracoes/></Private> }/>
            <Route path="/exercicios" element={ <Private><Exercicios/></Private> }/>
            <Route path="/score" element={ <Private><Score/></Private> }/>



            <Route path="*" element={ <Erro404/> }/>
        </Routes>
    );
}