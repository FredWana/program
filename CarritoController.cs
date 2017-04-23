
using System;
using System.Collection.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Librerias.EntidadesNegocio;
using Northwind.Librerias.ReglasNegocio;
using Carrito.Filters;
using General.Librerias.CodigoUsuario;
using General.Librerias.EntidadesNegocio;
  
namespace CarritoController:Controller
{
  public class Controller:Controller
  {
    public ActionResult Login()
    {
      return View();
    }
    public string CrearCaptcha()
    {
      beCaptcha obeCaptcha = ucCaptcha.CrearCaptcha();
      TemData["Copdigo"]=obeCaptcha.Imagen;
      return(Convert.ToBase64String(obeCaptcha.Imagen));
    }
    
    public string Validar(string usuario,string clave)
    {
    string rpta="";
    brUsuario obrUsuario = new brUsuario();
    beCliente obeCliente = obrUsuaurio.ValidarLogin(usuario,clave);
      if (obeCliente !=null)
      {
      Session ["Cliente"]=obeCliente;
      rpta="Bienvenido"+obeCliente.Nombre;
      }
      else rpta="Login invalido Intenta denuevo";
      return rpta;
      
      [FiltroAutenticacion]
      Public ActionResult Categorias()
      {
        return View();
      }
      
    }
    

}
