using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WinFormsTP.Entidades;

namespace WinFormsTP.Datos
{
    public class RepositorioDeCuadrados
    {
        private readonly string _archivo = Environment.CurrentDirectory + "//Esferas.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "//Esferas.bak";

        private List<Rectangulo> listaEsfera;
        public RepositorioDeCuadrados()
        {
            listaEsfera = new List<Rectangulo>();
            LeerDatos();
        }

        private void LeerDatos()
        {
            listaEsfera.Clear();
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Rectangulo esfera = ConstruirEsfera(lineaLeida);
                    listaEsfera.Add(esfera);
                }
                lector.Close();
            }
        }

        public void Editar(Rectangulo esfViejo, Rectangulo esferaEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Rectangulo esfera = ConstruirEsfera(lineaLeida);
                        if (esfera.GetRadio()==esfViejo.GetRadio())
                        {
                            lineaLeida = ConstruirLinea(esferaEditar);
                            escritor.WriteLine(lineaLeida);

                        }
                        else
                        {
                            escritor.WriteLine(lineaLeida);

                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }
        private Rectangulo ConstruirEsfera(string lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            int radio = int.Parse(campos[0]);
            string borde = (campos[1]);
            string color = (campos[2]);
            Rectangulo r = new Rectangulo(radio, borde, color);

            return r;
        }

        public void Agregar(Rectangulo esfera)
        {
            using (var escritor = new StreamWriter(_archivo, true))
            {
                string lineaEscribir = ConstruirLinea(esfera);
                escritor.WriteLine(lineaEscribir);
            }
            listaEsfera.Add(esfera);
        }

        private string ConstruirLinea(Rectangulo esfera)
        {
            return $"{esfera.GetRadio()}|{esfera.GetBorde()}|{esfera.GetColor()}";
        }

        public int GetCantidad(int? valorFiltro = 0)
        {
            if (valorFiltro > 0)
            {
                return listaEsfera.Count(c => c.Radio > valorFiltro);
            }
            return listaEsfera.Count();
        }
        public void Borrar(Rectangulo rectanguloBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Rectangulo rectanguloLeido = ConstruirEsfera(lineaLeida);
                        if (rectanguloBorrar.GetRadio() != rectanguloLeido.GetRadio())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaEsfera.Remove(rectanguloBorrar);
        }
        public List<Rectangulo> GetLista()
        {
            LeerDatos();
            return listaEsfera;
        }

        public List<Rectangulo> Filtrar(int valorFiltro)
        {
            return listaEsfera.Where(l => l.GetRadio() >= valorFiltro).ToList();
        }

        public List<Rectangulo> OrdenarAscL1()
        {
            return listaEsfera.OrderBy(l => l.GetRadio()).ToList();
        }

        public List<Rectangulo> OrdenarDescL1()
        {
            return listaEsfera.OrderByDescending(l => l.GetRadio()).ToList();
        }

        public List<Rectangulo> OrdenarAscL2()
        {
            return listaEsfera.OrderBy(l => l.GetVolumen()).ToList();
        }

        public List<Rectangulo> OrdenarDescL2()
        {
            return listaEsfera.OrderByDescending(l => l.GetVolumen()).ToList();
        }

        public bool Existe(Rectangulo esfera)
        {
            listaEsfera.Clear();
            LeerDatos();
            bool existe = false;
            foreach (var itemEsfera in listaEsfera)
            {
                if (itemEsfera.GetRadio() == esfera.GetRadio() && itemEsfera.GetVolumen() == esfera.GetVolumen())
                {
                    return true;
                }
            }
            return false;
        }
    }
}