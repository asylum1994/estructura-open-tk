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
    class Poligono
    {
        public List<Vector3> vertice;
        public Color4 color; 
        public Poligono(Color4 color)
        {
            this.vertice = new List<Vector3>();
            
            this.color = color; 
        }


        public void dibujar(float cmx,float cmy, float cmz)
        {
            GL.LineWidth(4);
            GL.Begin(PrimitiveType.Lines);
            GL.Color4(this.color);
            foreach (var vertex in this.vertice)
            {
                GL.Vertex3(cmx+vertex.X,cmy+vertex.Y,cmz+vertex.Z); 
            }
            GL.End(); 
        }

       /* public void dibujarLineQuads(Color4 color,List<Vector3> vertices)
        {
           
            GL.LineWidth(4);
            GL.Begin(PrimitiveType.Lines);
            GL.Color4(color);

            foreach (var vertex in vertices)
            {

                GL.Vertex3(vertex.X, vertex.Y, vertex.Z);
            }

            GL.End();

        }

        public void DibujarCirculo(Color4 color, Vector3 vertice)
        {
           
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color4(color);

            for (int i = 0; i < 360; i++)
            {
                double angle = 2 * Math.PI * i / 360;
                double x = vertice.X + 0.5 * Math.Cos(angle);
                double y = vertice.Y + 0.5 * Math.Sin(angle);
                GL.Vertex3(x, y, vertice.Z);
            }
            GL.End();
        }*/


       


    }

}
