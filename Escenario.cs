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
    class Escenario
    {
        public Dictionary<String, Objeto> dictionaryObjeto { get; set; }

        public Punto centroMasa { get; set;}
        public Escenario()
        {
            dictionaryObjeto = new Dictionary<string, Objeto>();
            this.centroMasa = new Punto(0.0f,0.0f,0.0f);
            
        }

        public Punto get()
        {
            return this.centroMasa;
        }

        public void set(float x,float y,float z)
        {
            this.centroMasa = new Punto(x, y, z); 
        }

        public void add(String key, Objeto parte)
        {
            dictionaryObjeto.Add(key, parte);
        }

        public void del(String key)
        {
            dictionaryObjeto.Remove(key);
        }

        public Objeto get(String key)
        {
            return dictionaryObjeto[key];
        }

        public void dibujar(float cmx, float cmy, float cmz)
        {
            Punto centroEscenario = new Punto(cmx,cmy,cmz)+this.centroMasa;

            foreach (Objeto objeto in dictionaryObjeto.Values)
            {
                objeto.dibujar(centroEscenario);
            }
        }


        public void traslatar(float x, float y)
        {
            foreach (Objeto objeto in dictionaryObjeto.Values)
            {
                objeto.traslatar(x, y);
            }
        }


        public void rotar(string eje,float angle)
        {
            foreach (Objeto objeto in dictionaryObjeto.Values)
            {
                objeto.rotar(eje,angle);
            }
        }

        public void escalar( float escala)
        {
            foreach (Objeto objeto in dictionaryObjeto.Values)
            {
                objeto.escalar(escala);
            }
        }

    }
}
