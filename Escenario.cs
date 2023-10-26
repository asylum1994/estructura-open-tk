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


        public Escenario()
        {
            dictionaryObjeto = new Dictionary<string, Objeto>();

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
            foreach (Objeto objeto in dictionaryObjeto.Values)
            {
                objeto.dibujar(cmx, cmy, cmz);
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
