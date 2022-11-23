using POOEntidades.Ortoedros;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOrtoedros.Datos
{
    public static class ArchivoSecuencial
    {
        private static string archivo = "Ortoedros.txt";
        public static void GuardarEnArchivo(List<Ortoedros> lista)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var ortoedros in lista)
                {
                    string linea = ConstruirLinea(ortoedros);
                    escritor.WriteLine(linea);
                }
            }

        }

        private static string ConstruirLinea(Ortoedros ortoedros)
        {
            return $"{ortoedros.aristasA}|{ortoedros.aristaB}|{ortoedros.aristaC}|{(int)ortoedros.colorRelleno}";
        }

        public static List<Ortoedros> LeerArchivo()
        {
            List<Ortoedros> lista = new List<Ortoedros>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Ortoedros ortoedros = ConstruirOrtoedro(linea);
                        lista.Add(ortoedros);
                    }
                }

            }
            return lista;
        }

        private static Ortoedros ConstruirOrtoedro(string linea)
        {
            var campos = linea.Split('|');
            Ortoedros ortoedros = new Ortoedros()
            {
                aristasA = int.Parse(campos[0]),
                aristaB = int.Parse(campos[1]),
                aristaC = int.Parse(campos[2]),
                colorRelleno = (ColorRelleno)int.Parse(campos[3]),
                
            };
            return ortoedros;
        }
    }
}
