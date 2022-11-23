using POOEntidades.Ortoedros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOrtoedros.Datos
{
    public class RepositorioDeOrtoedros
    {
        private List<Ortoedros> listaOrtoedros;
        private bool hayCambios = false;
        public RepositorioDeOrtoedros()
        {
            listaOrtoedros = new List<Ortoedros>();
            listaOrtoedros = ArchivoSecuencial.LeerArchivo();
        }

        public void Agregar(Ortoedros ortoedros)
        {
            hayCambios = true;
            listaOrtoedros.Add(ortoedros);
        }
        public int GetCantidad()
        {
            return listaOrtoedros.Count;
        }

        public void Borrar(Ortoedros ortoedros)
        {
            hayCambios = true;
            listaOrtoedros.Remove(ortoedros);
        }

        public void Editar(Ortoedros ortoedros)
        {
            hayCambios = true;
        }

        public List<Ortoedros> GetLista()
        {
            return listaOrtoedros;
        }

        public void Guardar()
        {
            if (hayCambios)
            {
                ArchivoSecuencial.GuardarEnArchivo(listaOrtoedros);
            }
        }
    }
}
