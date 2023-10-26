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

    class Poligono
    {
        
        public List<Punto> vertice { get; set;}
       
        public Color4 color { get; set;}

        Matrix4 modelview = Matrix4.Identity;
       
        public Poligono(Color4 color)
        {
            vertice = new List<Punto>();
            
            this.color = color; 
        }


        public void dibujar(float cmx,float cmy, float cmz)
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview); 
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(this.color);
            if (this.vertice.Count == 2)
            {
                dibujarRueda(cmx+this.vertice[0].x,cmy+this.vertice[0].y,cmz+this.vertice[0].z);
                dibujarRueda(cmx+this.vertice[1].x,cmy+ this.vertice[1].y, cmz+this.vertice[1].z);
            }
            else
            {
                foreach (var vertex in this.vertice)
                {
                    GL.Vertex3(cmx + vertex.x, cmy + vertex.y, cmz + vertex.z);
                }
            }
           
            GL.End();
           
            this.modelview = Matrix4.Identity;
        }

       

        public void dibujarRueda(float cmx,float cmy,float cmz)
        {

            GL.Begin(PrimitiveType.Polygon);
            for (int i = 0; i < 360; i++)
            {
                double angle = 2 * Math.PI * i / 360;
                double x = cmx + 0.5 * Math.Cos(angle);
                double y = cmy + 0.5 * Math.Sin(angle);
                GL.Vertex3(x, y, cmz);
            }
            GL.End();
           
        }


        public void traslatar(float x, float y)
        {
            this.modelview *= Matrix4.CreateTranslation(x,y,0); 
        }



        public void rotar(String eje, float angle)
        {
              Punto centroMasa = calcularCentroMasa(this.vertice);

            this.modelview = Matrix4.CreateTranslation(-centroMasa.x, -centroMasa.y, -centroMasa.z);
            Matrix4 rotationMatrix; 
            switch (eje)
            {
                case "x":
                     rotationMatrix = Matrix4.CreateRotationX(angle);
                    this.modelview=rotationMatrix * Matrix4.CreateTranslation(centroMasa.x, centroMasa.y, centroMasa.z);
                    break;
                case "y":
                     rotationMatrix = Matrix4.CreateRotationY(angle);
                    this.modelview = rotationMatrix * Matrix4.CreateTranslation(centroMasa.x, centroMasa.y, centroMasa.z);
                    break;
                case "z":
                     rotationMatrix = Matrix4.CreateRotationZ(angle);
                    this.modelview = rotationMatrix * Matrix4.CreateTranslation(centroMasa.x, centroMasa.y, centroMasa.z);
                    break;
              
            }
            GL.MultMatrix(ref modelview);
           
        }

        public void escalar(float escala)
        {
            this.modelview *= Matrix4.CreateScale(escala,escala,escala); 
        }
        
        public Punto calcularCentroMasa(List<Punto> vertices)
        {
            float sumX = 0.0f;
            float sumY = 0.0f;
            float sumZ = 0.0f;

            foreach (var punto in vertices)
            {
                sumX += punto.x;
                sumY += punto.y;
                sumZ += punto.z; 
            }
            float centerX = sumX / vertices.Count;
            float centerY = sumY / vertices.Count;
            float centerZ = sumZ / vertices.Count;

            return new Punto(centerX,centerY,centerZ); 
        }


        public void mostrar()
        {
            int i = 0;
            foreach (var vertex in this.vertice)
            {
                Console.WriteLine(i+": "+"( "+vertex.x+","+vertex.y+","+vertex.z+")");
                i++;
            }
        }

    }


    

}
