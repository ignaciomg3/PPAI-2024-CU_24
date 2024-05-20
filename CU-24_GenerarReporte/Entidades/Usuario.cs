using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public Perfil Perfil { get; set; }

        public Usuario(string nombre, string email, Perfil perfil)
        {
            Nombre = nombre;
            Email = email;
            Perfil = perfil;
        }



    }
}
