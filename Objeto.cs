using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
//using Newtonsoft.Json;
namespace tarea1
{
    [Serializable]
    class Objeto
    {
       
        public Dictionary<String, Parte> dictionaryParte {get;set;}

       
        public Punto centroMasa { get; set; }
        public Objeto()
        {
            this.dictionaryParte = new Dictionary<string, Parte>();
            this.centroMasa = new Punto(0.0f,0.0f,0.0f); 
        }

        public Punto get()
        {
            return this.centroMasa;
        }

        public void set(float x, float y, float z)
        {
            this.centroMasa = new Punto(x, y, z);
        }


        public void add(String key,Parte parte)
        {
            this.dictionaryParte.Add(key,parte);
        }

        public Parte get(String key)
        {
            return this.dictionaryParte[key];
        }

        public void del(String key)
        {
            this.dictionaryParte.Remove(key);
        }


        public void dibujar(Punto centroEscenario)
        {
            Punto centroObjeto = centroEscenario + this.centroMasa; 
            foreach (Parte parte in dictionaryParte.Values)
            {
                parte.dibujar(centroObjeto);
            }
        }

        public void traslatar(float x, float y)
        {
            foreach (Parte parte in dictionaryParte.Values)
            {
                parte.traslatar(x, y);
            }
        }

       public void rotar( string eje,float angle)
        {
            foreach (Parte parte in dictionaryParte.Values)
            {
                parte.rotar(eje,angle);
            }
        }


        public void escalar( float escala)
        {
           
            foreach (Parte parte in dictionaryParte.Values)
            {
                parte.escalar(escala);
            }
        }

    }
}
