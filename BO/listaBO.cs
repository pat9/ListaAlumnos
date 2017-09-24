using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class listaBO
    {
        private int id;

        private DateTime fecha;
        private int id_alumno;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int Id_alumno
        {
            get
            {
                return id_alumno;
            }

            set
            {
                id_alumno = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
