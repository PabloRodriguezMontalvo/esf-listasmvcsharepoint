using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionTareasWeb.Models
{
    public class MiTarea
    {
        public int ID { get; set; }
        public String Tarea { get; set; }
        public String Descripcion { get; set; }
        public DateTime Vencimiento { get; set; }
        public Boolean Finalizada { get; set; }

    }
}