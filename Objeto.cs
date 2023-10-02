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
    class Objeto
    {
        Dictionary<String, Parte> dictionaryParte;
         

        public Objeto()
        {
            this.dictionaryParte = new Dictionary<string, Parte>();
            
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


        public void dibujar(float cmx,float cmy,float cmz)
        {
            foreach (Parte parte in dictionaryParte.Values)
            {
                parte.dibujar(cmx,cmy,cmz);
            }
        }


    }
}
