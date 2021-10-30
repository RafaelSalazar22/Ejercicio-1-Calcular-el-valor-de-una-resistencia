using Microsoft.AspNetCore.Mvc;
using Resistencia.Domain.Entities;
namespace Resistencia.Controllers
{
    /* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 2 Ejercicio 1 – Calcular el valor de una resistencia
    Nombre del alumno: Rafael Salazar Perera
    Cuatrimestre: 4
    Grupo: A
    Parcial: 2
    */

    [ApiController]
    [Route("api/[controller]")]
    public class Resistenciascontroller : ControllerBase
    {
        [HttpGet]
        [Route("Calcula")]
        public IActionResult Calcula(string _Color1 ,string _Color2,string _Color3,string _Color4)
        {
            var Calcular = new Bandas_Colores();
            Calcular.PrimerColor(_Color1);
            if(_Color1.ToLower() != "negro" && _Color1.ToLower() != "cafe" && _Color1.ToLower() != "rojo" && _Color1.ToLower() != "amarillo" &&_Color1.ToLower() != "gris" 
            &&_Color1.ToLower() != "verde" && _Color1.ToLower()!= "azul" && _Color1.ToLower() != "violeta" && _Color1.ToLower() != "blanco" && _Color1.ToLower()!= "naranja" )
            {
                return Ok( "Error en la bandeja 1 : Color incorrecto, intente de nuevo");
            }
            Calcular.SegundoColor(_Color2);
            if(_Color2.ToLower() != "negro" && _Color2.ToLower() != "cafe" && _Color2.ToLower() != "rojo" && _Color2.ToLower() != "amarillo" &&_Color2.ToLower() != "gris" 
            &&_Color2.ToLower() != "verde" && _Color2.ToLower()!= "azul" && _Color2.ToLower() != "violeta" && _Color2.ToLower() != "blanco" && _Color2.ToLower()!= "naranja" )
            {
                return Ok("Error en la bandeja 2 :  color incorrecto, intente de nuevo.");
            }
            Calcular.TercerColor(_Color3);
            if(_Color3.ToLower() =="violeta" || _Color3.ToLower() =="gris" || _Color3.ToLower() =="blanco")
            {
                 return Ok(" Error en la bandeja 3 :  no puedes poner los colores violeta, gris y blanco intente de nuevo.");
            }
            if(_Color3.ToLower() != "negro" && _Color3.ToLower() != "cafe" && _Color3.ToLower() != "rojo" && _Color3.ToLower() != "amarillo" 
            &&_Color3.ToLower() != "verde" && _Color3.ToLower()!= "azul"&&_Color3.ToLower()!= "naranja" )
            {
                return Ok("Error en la bandeja 3 :  Color incorrecto , intente de nuevo.");
            }
            Calcular.CuartoColor(_Color4);
            if(_Color4.ToLower() != "plata" && _Color4.ToLower() != "dorado")
            {
                return Ok("Error en la bandeja 4 : en la bandeja cuatro solo puedes poner plata o dorado.");
            }
            Calcular.RetornarCalculos();
            return Ok(Calcular.RetornarCalculos());
        }
    }
}