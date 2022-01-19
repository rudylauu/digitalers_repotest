using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MiPaginaPresentacion
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //esto se ejecuta al iniciar la aplicacion, esto quiere decir se ejecuta una sola vez
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //cuando alguien inicia sesion o una persona ingresa a mi app
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //cuando empieza cualquier peticion a mi pagina
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            //cuando empieza el proceso de autentificacion
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //para guardar errores
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //cuando termino una sesion
        }

        protected void Application_End(object sender, EventArgs e)
        {
            //cuando se detenga la aplicacion
        }
    }
}