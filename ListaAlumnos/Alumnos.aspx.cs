using System;
using System.Web.UI.WebControls;
using DAO;
using BO;
namespace ListaAlumnos
{
    public partial class Alumnos : System.Web.UI.Page
    {
        alumnosDAO alumno = new alumnosDAO();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refrescar();
            }



            }
        public void refrescar()
        {
            gvAlumnos.DataSource = alumno.mostrarlista().Tables[0];
            gvAlumnos.DataBind();
        }

        public alumnoBO  recuperar()
        {
            alumnoBO obj = new alumnoBO();
            int id = 0;int.TryParse(txtID. Text,out id);
            obj.Apellidos = txtapellidos.Text;
            obj.Nombres = txtnombres.Text;
            obj.Id = id;
            obj.Grado = txtGrado.Text;
            obj.Grupo = txtGrupo.Text;
            return obj; 
                
        }

        protected void gvAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="btn_sele")
            {

                int fila = Convert.ToInt32(e.CommandArgument);
                txtID.Text = gvAlumnos.Rows[fila].Cells[1].Text;
                txtnombres.Text = gvAlumnos.Rows[fila].Cells[2].Text;
                txtapellidos.Text = gvAlumnos.Rows[fila].Cells[3].Text;
                txtGrado.Text = gvAlumnos.Rows[fila].Cells[4].Text;
                txtGrupo.Text = gvAlumnos.Rows[fila].Cells[5].Text;

          
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            alumno.agregar(recuperar());
            txtapellidos.Text = "";
            txtGrado.Text = "";
            txtGrupo.Text = "";
            txtnombres.Text = "";
            
            refrescar();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            alumno.actualizar(recuperar());
            txtapellidos.Text = "";
            txtGrado.Text = "";
            txtGrupo.Text = "";
            txtnombres.Text = "";
            refrescar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            alumno.eliminar(recuperar());
            txtapellidos.Text = "";
            txtGrado.Text = "";
            txtGrupo.Text = "";
            txtnombres.Text = "";
            refrescar();
        }
    }
}