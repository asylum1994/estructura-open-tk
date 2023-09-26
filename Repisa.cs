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
    class Repisa
    {
        
        Color4 color; 

        public Repisa(Color4 color)
        {
            
            this.color = color; 
        }

        public void Dibujar(float cmx,float cmy,float cmz)
        {
             GL.Begin(PrimitiveType.Quads);
             GL.Color4(Color4.DarkGreen);

             GL.Vertex3(cmx - 5, cmy + 3, cmz);
             GL.Vertex3(cmx + 5, cmy + 3, cmz);
             GL.Vertex3(cmx + 7, cmy - 3, cmz);
             GL.Vertex3(cmx - 3, cmy - 3, cmz);

            GL.End();
          
        }

    }
}
