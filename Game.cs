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
    class Game :GameWindow
    {
        float scale;
        Escenario escenario;

     public Game(int width,int height):base(width,height,GraphicsMode.Default,"DIBUJANDO OBJETOS CON COORDENADAS RELATIVAS")
     {

            WindowState = WindowState.Maximized;
            this.scale = 30.0f;
            this.escenario = new Escenario();

           


        }
        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
          
            GL.Enable(EnableCap.DepthTest);
            GL.ClearColor(Color4.Pink);
           
            Console.WriteLine("ancho : "+Width);
            Console.WriteLine("alto : "+Height); 
            
           
            
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            // 4 puntos 
            GL.PointSize(5.0f);
            GL.Begin(PrimitiveType.Points);
            GL.Color4(Color4.Black);
            GL.Vertex2(15.0, 15.0);
            GL.Vertex2(-15.0, 15.0);
            GL.Vertex2(0,0);
            GL.Vertex2(-15.0, -15.0);
            GL.Vertex2(15.0, -15.0);
            GL.End();
            /////////////////////////////
            this.escenario.Dibujar(15,15,0);
            this.escenario.Dibujar(-15, 15,0);
            this.escenario.Dibujar(-15, -15,0);
            this.escenario.Dibujar(15, -15,0);

            ////////////////////////////////////
            SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0,0,Width,Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            
         
            GL.Ortho(-scale, scale , -scale, scale, -scale,scale);


            GL.MatrixMode(MatrixMode.Modelview);
            

        }


    }
}
