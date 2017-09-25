using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

namespace ListaAlumnos
{
    public partial class Lista : System.Web.UI.Page
    {
        alumnosDAO dao = new alumnosDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                che.DataSource = dao.mostrarlista1().Tables[0];
                che.DataTextField = "nom";
                che.DataBind();
            }
        }
    }
}