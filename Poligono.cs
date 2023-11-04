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

        Matrix4 translation = Matrix4.Identity;
        Matrix4 rotation = Matrix4.Identity;
        Matrix4 escalation = Matrix4.Identity;
        Matrix4 resultado = Matrix4.Identity;
        public Poligono(Color4 color)
        {
            vertice = new List<Punto>();
            
            this.color = color;
          
        }


        public void dibujar(Punto punto)
        {
            this.resultado = this.rotation * this.translation * this.escalation;
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(this.color);
          
            if (this.vertice.Count == 2)
            {
                dibujarRueda(punto.x+this.vertice[0].x,punto.y+this.vertice[0].y,punto.z+this.vertice[0].z,resultado);
                dibujarRueda(punto.x+this.vertice[1].x,punto.y+ this.vertice[1].y, punto.z+this.vertice[1].z,resultado);
            }
            else
            {
                foreach (var vertex in this.vertice)
                {
                    
                     Vector4 vector = Vector4.Transform(new Vector4(punto.x+ vertex.x, punto.x+vertex.y, punto.z+ vertex.z, 1),resultado);
                
                    
                     GL.Vertex3(vector.X, vector.Y, vector.Z);
                }
            }
            
            this.rotation = Matrix4.Identity;
            this.translation = Matrix4.Identity;
            this.escalation = Matrix4.Identity;
            GL.End();
           
           
        }

       

        public void dibujarRueda(float cmx,float cmy,float cmz,Matrix4 resultado)
        {

            GL.Begin(PrimitiveType.Polygon);
            for (int i = 0; i < 360; i++)
            {
                double angle = 2 * Math.PI * i / 360;
                double x = cmx + 0.5 * Math.Cos(angle);
                double y = cmy + 0.5 * Math.Sin(angle);
                Vector4 vector = Vector4.Transform(new Vector4((float)x,(float)y,cmz,1),resultado);
                GL.Vertex3(vector.X,vector.Y,vector.Z);
            }
            GL.End();
           
        }

        
        public void traslatar(float x, float y)
        {
            this.translation *= Matrix4.CreateTranslation(x,y,0);
        }


        public void rotar(String eje, float angle)
        {
           
            
            switch (eje)
            {
                case "x":

                     this.rotation *= Matrix4.CreateRotationX(angle);
                    
                   
                    break;
                case "y":

                     this.rotation *= Matrix4.CreateRotationY(angle);
                   


                    break;
                case "z":
                      this.rotation*= Matrix4.CreateRotationZ(angle);
                    
                    break;   
            }

           
            


        }
        
        public void escalar(float escala)
        {   
            this.escalation *= Matrix4.CreateScale(escala,escala,escala); 
        }
        
       
        Vector3 calcularCentroMasa()
        {
            Vector3 sum = Vector3.Zero;
            foreach (var vertex in vertice)
            {
                Vector3 aux = new Vector3(vertex.x,vertex.y,vertex.z);
                sum += aux;
            }
            return sum / vertice.Count;
        }
       
        
        public Vector3 sumaVertices()
        {
            Vector3 sum = Vector3.Zero;
            foreach (var vertex in this.vertice)
            {
                sum += new Vector3(vertex.x,vertex.y,vertex.z);
            }
            return sum; 
        }
     

    }


    

}
