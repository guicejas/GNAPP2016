using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace APPWEB
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mensaje.Visible = false;
            if (Request.QueryString["msj"] != null)
            {
                mensaje.Visible = true;
                mensaje.Attributes.Add("class", "alert alert-dismissable alert-success");
                mensajeTexto.InnerHtml = Request.QueryString["msj"];
            }

            if (this.Context.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Garage/index.aspx");
            }
        }


        protected void LoginSistema_Authenticate(object sender, EventArgs e)
        {
            
            bool Autenticado = false;

            Autenticado = IniciarSesion(inputUsuario.Value, inputPassword.Value);
           
            if (Autenticado)
            {
                    FormsAuthentication.RedirectFromLoginPage(inputUsuario.Value, recordarme.Checked);
                    Response.Redirect("Garage/index.aspx");
            }
            else
            {
                mensaje.Visible = true;
                mensaje.Attributes.Add("class", "alert alert-dismissable alert-danger");
                mensajeTexto.InnerHtml = "Usuario o password incorrectos. IP:" + Request.UserHostAddress.ToString();
            }
        }

        private bool IniciarSesion(string Usuario, string Contrasena)
            {
                if (Usuario.Equals("admin") && Contrasena.Equals("guillote"))
            return true; return false;
            }


        
    }

    }