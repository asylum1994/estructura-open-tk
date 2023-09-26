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
    class Pared
    {
       
        private Color4 color;
       
        public Pared(Color4 color)
        {
            
            this.color = color;
          
        }

        public void Dibujar(float cmx,float cmy,float cmz)
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color4.Red);
            GL.Vertex3(cmx- 10, cmy + 8,cmz);
            GL.Vertex3(cmx + 10, cmy + 12, cmz);
            GL.Vertex3(cmx + 7, cmy - 6, cmz);
            GL.Vertex3(cmx - 13, cmy  -10, cmz);
            GL.End();
        }


    }

     
}
