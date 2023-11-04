using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Newtonsoft.Json;
namespace tarea1
{
    [Serializable]
    class Parte
    {
        public Dictionary<String, Poligono> dictionaryPoligono { get; set; }

        public Punto centroMasa { get; set; }
        public Parte()
        {
            dictionaryPoligono = new Dictionary<string, Poligono>();
            this.centroMasa = new Punto(0.0f, 0.0f, 0.0f);
        }

        public Punto get()
        {
            return this.centroMasa;
        }

        public void set(float x, float y, float z)
        {
            this.centroMasa = new Punto(x, y, z);
        }

        public void add(String key,Poligono poligono)
        {
            dictionaryPoligono.Add(key, poligono); 
        }

        public Poligono get(String key)
        {
            return dictionaryPoligono[key];
        }
        public void del(String key)
        {
            dictionaryPoligono.Remove(key);
        }

        public void dibujar(Punto centroObjeto)
        {
            Punto centroParte = centroObjeto + this.centroMasa; 
            foreach (Poligono poligono in dictionaryPoligono.Values)
            {
                poligono.dibujar(centroParte);
            }
        }

        public void traslatar( float x, float y)
        {
            foreach (Poligono poligono in dictionaryPoligono.Values)
            {
                poligono.traslatar(x, y);
            }
        }


        public void rotar( String eje,float angle)
        {
            foreach (Poligono poligono in dictionaryPoligono.Values)
            {
                poligono.rotar(eje,angle);
            }
        }

        public void escalar( float escala)
        {
            foreach (Poligono poligono in dictionaryPoligono.Values)
            {
                poligono.escalar(escala);
            }
        }

       

    }
}
