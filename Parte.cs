using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace tarea1
{
    class Parte
    {
        Dictionary<String, Poligono> dictionaryPoligono;
        public Parte()
        {
            this.dictionaryPoligono = new Dictionary<string, Poligono>();
            
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

        public void dibujar(float cmx,float cmy,float cmz)
        {
            foreach (Poligono poligono in dictionaryPoligono.Values)
            {
                poligono.dibujar(cmx,cmy,cmz);
            }
        }

    }
}
