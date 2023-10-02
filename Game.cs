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
        private float rotationAngle = 20.0f;

        Escenario escenario;
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
            this.escenario = new Escenario();
            this.pared = new Objeto();
            this.repisa = new Objeto();
            this.auto = new Objeto();

            this.partePared = new Parte();
            this.parteRepisa = new Parte();
            this.parteAuto = new Parte(); 

        }
        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
          
            GL.Enable(EnableCap.DepthTest);
            GL.ClearColor(Color4.Pink);
           
            Console.WriteLine("ancho : "+Width);
            Console.WriteLine("alto : "+Height);

            //PARTES DEL OBJETO PARED

            Poligono parteParedFrontal = new Poligono(Color4.Green);
            List<Vector3> vpf = new List<Vector3> {new Vector3(-9,10,10), 
            new Vector3(-7, 10, 10), new Vector3(-7,-10, 10), new Vector3(-9, -10, 10), 
            new Vector3(-7, -10, 10), new Vector3(-7, 10, 10), new Vector3(-9, -10, 10),new Vector3(-9, 10, 10) };
            parteParedFrontal.vertice.AddRange(vpf);
            
            Poligono parteParedPosterior = new Poligono(Color4.Green);
            List<Vector3> vpp = new List<Vector3> {new Vector3(7,15,10),
            new Vector3(9, 15, 10), new Vector3(9,-5, 10), new Vector3(7, -5, 10),
            new Vector3(7, -5, 10), new Vector3(7, 15, 10), new Vector3(9, -5, 10),new Vector3(9, 15, 10) };
            parteParedFrontal.vertice.AddRange(vpp);

            Poligono parteParedInferior = new Poligono(Color4.Green);
            List<Vector3> vpi = new List<Vector3> {new Vector3(7,-5,10),
            new Vector3(-9, -10, 10),new Vector3(9, -5, 10),new Vector3(-7, -10, 10)};
            parteParedFrontal.vertice.AddRange(vpi);

            Poligono parteParedSuperior = new Poligono(Color4.Green);
            List<Vector3> vps = new List<Vector3> {new Vector3(7,15,10),
            new Vector3(-9, 10, 10),new Vector3(9, 15, 10),new Vector3(-7, 10, 10)};
            parteParedFrontal.vertice.AddRange(vps);

            //// cargar partes del objeto pared 
            this.partePared.add("parteParedFrontal",parteParedFrontal);
            this.partePared.add("parteParedPosterior",parteParedPosterior);
            this.partePared.add("parteParedInferior",parteParedInferior);
            this.partePared.add("parteParedSuperior",parteParedSuperior);


            //PARTES DEL OBJETO REPISA

            Poligono parteRepisaFrontal = new Poligono(Color4.Blue);
            List<Vector3> vrf = new List<Vector3> {new Vector3(-6,3,10),
            new Vector3(-4, 1, 10), new Vector3(-4,-1, 10), new Vector3(-6, 1, 10),
            new Vector3(-4, 1, 10), new Vector3(-4, -1, 10), new Vector3(-6, 3, 10),new Vector3(-6, 1, 10) };
            parteRepisaFrontal.vertice.AddRange(vrf);

            Poligono parteRepisaPosterior = new Poligono(Color4.Blue);
            List<Vector3> vrp = new List<Vector3> {new Vector3(6,8,10),
            new Vector3(8, 6, 10), new Vector3(8,4, 10), new Vector3(6, 6, 10),
            new Vector3(6, 8, 10), new Vector3(6, 6, 10), new Vector3(8, 6, 10),new Vector3(8, 4, 10) };
            parteRepisaFrontal.vertice.AddRange(vrp);

            Poligono parteRepisaInferior = new Poligono(Color4.Blue);
            List<Vector3> vri = new List<Vector3> {new Vector3(6,6,10),
            new Vector3(-6, 1, 10),new Vector3(8, 4, 10),new Vector3(-4, -1, 10)};
            parteRepisaFrontal.vertice.AddRange(vri);

            Poligono parteRepisaSuperior = new Poligono(Color4.Blue);
            List<Vector3> vrs = new List<Vector3> {new Vector3(8,6,10),
            new Vector3(-4, 1, 10),new Vector3(6, 8, 10),new Vector3(-6, 3, 10)};
            parteRepisaFrontal.vertice.AddRange(vrs);

            //// cargar partes del objeto repisa
            this.parteRepisa.add("parteRepisaFrontal", parteRepisaFrontal);
            this.parteRepisa.add("parteRepisaPosterior", parteRepisaPosterior);
            this.parteRepisa.add("parteRepisaInferior", parteRepisaInferior);
            this.parteRepisa.add("parteRepisaSuperior", parteRepisaSuperior);
            ///////////////////////////////////////////////////////////////


            //PARTES DEL OBJETO AUTO

            Poligono parteAutoFrontal = new Poligono(Color4.Red);
            List<Vector3> vaf = new List<Vector3> {new Vector3(-2,6,10),
            new Vector3(-1, 5, 10), new Vector3(-1,3, 10), new Vector3(-2, 4, 10),
            new Vector3(-1, 3, 10), new Vector3(-1, 5, 10), new Vector3(-2, 6, 10),new Vector3(-2, 4, 10) };
            parteAutoFrontal.vertice.AddRange(vaf);

            Poligono parteAutoPosterior = new Poligono(Color4.Red);
            List<Vector3> vap = new List<Vector3> {new Vector3(2,8,10),
            new Vector3(3, 7, 10), new Vector3(3,5, 10), new Vector3(2, 6, 10),
            new Vector3(3, 5, 10), new Vector3(3, 7, 10), new Vector3(2, 6, 10),new Vector3(2, 8, 10) };
            parteAutoPosterior.vertice.AddRange(vap);

            Poligono parteAutoInferior = new Poligono(Color4.Red);
            List<Vector3> vai = new List<Vector3> {new Vector3(2,6,10),
            new Vector3(-2, 4, 10),new Vector3(3, 5, 10),new Vector3(-1, 3, 10)};
            parteAutoInferior.vertice.AddRange(vai);

            Poligono parteAutoSuperior = new Poligono(Color4.Red);
            List<Vector3> vas = new List<Vector3> {new Vector3(3,7,10),
            new Vector3(-1, 5, 10),new Vector3(2, 8, 10),new Vector3(-2, 6, 10)};
            parteAutoSuperior.vertice.AddRange(vas);

            //// cargar partes del objeto auto
            this.parteAuto.add("parteAutoFrontal", parteAutoFrontal);
            this.parteAuto.add("parteAutoPosterior", parteAutoPosterior);
            this.parteAuto.add("parteAutoInferior", parteAutoInferior);
            this.parteAuto.add("parteAutoSuperior", parteAutoSuperior);



            /// cargar valores objeto
            this.auto.add("parteAuto", this.parteAuto);
            this.repisa.add("parteRepisa", this.parteRepisa);
            this.pared.add("partePared", this.partePared);



            /// cargar valores escenario
            
            this.escenario.add("auto", this.auto);
            this.escenario.add("repisa", this.repisa);
            this.escenario.add("pared", this.pared);
           
            
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            // Rotar el objeto
            rotationAngle += 0.3f; // Ajusta la velocidad de rotación según sea necesario
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
           
           
        


            // 4 puntos 
            GL.PointSize(5.0f);
            GL.Begin(PrimitiveType.Points);
            GL.Color4(Color4.Black);
            GL.Vertex3(15.0, 15.0,15.0);
            GL.Vertex3(-15.0, 15.0,15.0);
            GL.Vertex3(0,0,0);
            GL.Vertex3(-15.0, -15.0,15.0);
            GL.Vertex3(15.0, -15.0,15.0);
            GL.End();

           
           // GL.Rotate(rotationAngle, 0.0f, 0.0f, 0.1f);

            
          
            /////////////////////////////
             this.escenario.dibujar(15,15,15);
             this.escenario.dibujar(-15, 15,15);
             this.escenario.dibujar(-15, -15,15);
             this.escenario.dibujar(15, -15,15);
          
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
