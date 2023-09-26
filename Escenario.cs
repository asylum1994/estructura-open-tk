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
    class Escenario
    {
        Pared pared;
        Repisa repisa;
        Auto auto;
       


        public Escenario()
        {
            this.pared = new Pared(Color4.Black);
            this.repisa = new Repisa(Color4.DarkGreen);
            this.auto = new Auto(Color4.Brown);
        }

        public void Dibujar(float cmx,float cmy,float cmz)
        {
            this.auto.Dibujar(cmx,cmy,cmz);
            this.repisa.Dibujar(cmx,cmy,cmz);
            this.pared.Dibujar(cmx, cmy,cmz);
        } 



    }
}
