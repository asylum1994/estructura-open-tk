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
    class Auto
    {
      
        Color4 color; 

        public Auto(Color4 color)
        {
            this.color = color; 
        }

        public void Dibujar(float cmx,float cmy,float cmz)
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color4.Brown);
            // cuerpo del auto
             GL.Vertex3(cmx - 1.5, cmy + 1.5, cmz);
             GL.Vertex3(cmx + 1.5, cmy + 1.5, cmz);
             GL.Vertex3(cmx + 1.5, cmy - 1, cmz);
             GL.Vertex3(cmx - 1.5, cmy - 1, cmz);
            //
            GL.End();
            
            //rueda delantera/////////////////
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color4(Color4.Black);
           
           
            for (int i=0;i<=360;i++)
            {
                double angle = 2 * Math.PI * i / 180;
                double x = (cmx-1) + 0.4 * Math.Cos(angle);
                double y = (cmy-1.2) + 0.4 * Math.Sin(angle);
                GL.Vertex3(x, y,0);
            }
            GL.End();
            //////////////////////////////////////////////
            /// rueda trasera ////////
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color4(Color4.Black);
           

            for (int i = 0; i <= 360; i++)
            {
                double angle = 2 * Math.PI * i / 180;
                double x = (cmx + 1) + 0.4 * Math.Cos(angle);
                double y = (cmy - 1.2) + 0.4 * Math.Sin(angle);
                GL.Vertex3(x, y,0);

            }
            GL.End();

        }
    }
}
