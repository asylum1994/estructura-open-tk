using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Windows.Forms; 
namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anchoPantalla = Screen.PrimaryScreen.Bounds.Width;
            int altoPantalla = Screen.PrimaryScreen.Bounds.Height; 
            Game game = new Game(anchoPantalla,altoPantalla);
            game.Run(60.0);
            Console.ReadLine();
        }
    }
}
