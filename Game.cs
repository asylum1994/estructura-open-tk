using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.IO;
using Newtonsoft.Json;
//using System.Xml.Serialization;

namespace tarea1
{
    class Game :GameWindow
    {
        float scale;
        float escala = 1f; // variable para escalar el objeto
        public float rotationAngle = 0.0f; // variables para la rotacion
      
        float x=0; float y=0; // variables traslacion

        Serializable serializable;
        Escenario escenario;
        bool traslacion = true; 
        Objeto pared;
        Objeto repisa;
        Objeto auto;

        Parte partePared;
        Parte parteRepisa;
        Parte parteAuto; 

        public Game(int width,int height):base(width,height,GraphicsMode.Default,"DIBUJANDO OBJETOS CON COORDENADAS RELATIVAS")
     {
              
            WindowState = WindowState.Maximized;
            this.scale = 30.0f;
            serializable = new Serializable();
           
            this.escenario = serializable.deserializarObjeto("figuras.txt");



            //            serializable.serializarObjeto(escenario,"figuras.txt");
          
        }

        




        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);

            GL.Enable(EnableCap.DepthTest);
            GL.ClearColor(Color4.Pink);

            Console.WriteLine("ancho : " + Width);
            Console.WriteLine("alto : " + Height);

           
        }
             
      

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            // Rotar el objeto
            //  rotationAngle += 0.3f; // Ajusta la velocidad de rotación según sea necesario
             
            var keyboard = Keyboard.GetState(); 
            if (keyboard.IsKeyDown(Key.Right))
            {
                x += 1f;
              
              
            }else if (keyboard.IsKeyDown(Key.Left))
            {
                x -= 1f;
                
            }
            else if (keyboard.IsKeyDown(Key.Up))
            {
                y += 1f;

                
            }
            else if (keyboard.IsKeyDown(Key.Down))
            {
                y -=1f;
               
            }

            if (keyboard.IsKeyDown(Key.A))
            {
                rotationAngle += 0.01f;
                
            }
            else if (keyboard.IsKeyDown(Key.D))
            {
                rotationAngle -= 0.01f;  
            }

           


            if (keyboard.IsKeyDown(Key.W))
            {
                escala += 0.01f;

            }
            else if (keyboard.IsKeyDown(Key.S))
            {
                escala -= 0.01f;

            }

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);


            // 4 puntos 
            
            GL.PointSize(5.0f);
            GL.Begin(PrimitiveType.Points);
            GL.Color4(Color4.Black);
            GL.Vertex3(15.0, 15.0, 15.0);
            GL.Vertex3(-15.0, 15.0, 15.0);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(-15.0, -15.0, 15.0);
            GL.Vertex3(15.0, -15.0, 15.0);
            GL.End();

            //  this.escenario.dibujar(15,15,15);
            // this.escenario.dibujar(-15, 15,15);
            //     this.escenario.dibujar(-15, -15, 15);
            //    this.escenario.dibujar(15, -15,15);



            // escenario.rotar("y" , rotationAngle);
            //     escenario.traslatar(x, y);
           
            escenario.get("auto").rotar("y", rotationAngle);
            escenario.get("auto").traslatar(x, y);
            // escenario.get("auto").get("parteAuto").get("parteAutoRuedasIzq").traslatar(x,y);
            //  escenario.get("auto").escalar(escala); 
            //  escenario.escalar(escala);





            this.escenario.dibujar(0.0f,0.0f,0.0f); 


            ////////////////////////////////////
            SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            
            GL.Viewport(0,0,Width,Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            GL.Ortho(-scale, scale , -scale, scale, -scale,scale);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);

        }


    }
}
