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
    class Punto
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Punto(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z; 
        }

        //sobrecargar el operator + 
        public static Punto operator +(Punto punto1,Punto punto2)
        {
            return new Punto(punto1.x+punto2.x,punto1.y+punto2.y,punto1.z+punto2.z); 
        }

        // sobrecargar el operador * 
        public static Punto operator *(Punto punto,Vector3 vector)
        {
            return new Punto(punto.x*vector.X,punto.y*vector.Y,punto.z*vector.Z);
        }



    }
}
