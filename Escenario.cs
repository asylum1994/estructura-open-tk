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

        Dictionary<String, Objeto> dictionaryObjeto;


        public Escenario()
        {
            this.dictionaryObjeto = new Dictionary<string, Objeto>();
           
        }


        public void add(String key,Objeto parte)
        {
            this.dictionaryObjeto.Add(key,parte);
        }

        public void del(String key)
        {
            this.dictionaryObjeto.Remove(key);
        }

        public Objeto get(String key)
        {
            return this.dictionaryObjeto[key];
        }

        public void dibujar(float cmx,float cmy,float cmz)
        {
            foreach (Objeto objeto in this.dictionaryObjeto.Values)
            {
                objeto.dibujar(cmx,cmy,cmz);
            }
        }

        /*  public List<Vector3> cargarVerticesParedFrontal(float cmx,float cmy,float cmz)
          {
             List<Vector3> lista = new List<Vector3>
          {
                  new Vector3(cmx-7, cmy-12, cmz+10),
              new Vector3(cmx-9, cmy-12, cmz+10),
              new Vector3(cmx-7, cmy+8, cmz+10),
              new Vector3(cmx-9, cmy+8, cmz+10),
              new Vector3(cmx-7, cmy+8, cmz+10),
              new Vector3(cmx-7, cmy-12, cmz+10),
              new Vector3(cmx-9, cmy+8, cmz+10),
              new Vector3(cmx-9, cmy-12, cmz+10),
          };

              return lista; 
          }

          public List<Vector3> cargarVerticesParedTrasera(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx+7, cmy-5, cmz+10),
              new Vector3(cmx+9, cmy-5, cmz+10),
              new Vector3(cmx+7, cmy+15, cmz+10),
              new Vector3(cmx+9, cmy+15, cmz+10),
              new Vector3(cmx+9, cmy+15, cmz+10),
              new Vector3(cmx+9, cmy-5, cmz+10),
              new Vector3(cmx+7, cmy+15, cmz+10),
              new Vector3(cmx+7, cmy-5, cmz+10),
          };

              return lista;
          }

          public List<Vector3> cargarVerticesParedInferior(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx+7, cmy-5, cmz+10),
              new Vector3(cmx-9, cmy-12, cmz+10),
              new Vector3(cmx+9, cmy-5, cmz+10),
              new Vector3(cmx-7, cmy-12, cmz+10),

          };

              return lista;
          }

          public List<Vector3> cargarVerticesParedSuperior(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx+7, cmy+15, cmz+10),
              new Vector3(cmx-9, cmy+8, cmz+10),
              new Vector3(cmx+9, cmy+15, cmz+10),
              new Vector3(cmx-7, cmy+8, cmz+10),

          };

              return lista;
          }

          /// OBJETO REPISA
          public List<Vector3> cargarVerticesRepisaFrontal(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx-4, cmy+1, cmz+10),
              new Vector3(cmx+8, cmy+6, cmz+10),
              new Vector3(cmx+8, cmy+4, cmz+10),
              new Vector3(cmx-4, cmy-1, cmz+10),
              new Vector3(cmx-4, cmy+1, cmz+10),
              new Vector3(cmx-4, cmy-1, cmz+10),
              new Vector3(cmx+8, cmy+6, cmz+10),
              new Vector3(cmx+8, cmy+4, cmz+10),
          };

              return lista;
          }
          public List<Vector3> cargarVerticesRepisaTrasera(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx-6, cmy+3, cmz+10),
              new Vector3(cmx+6, cmy+8, cmz+10),
              new Vector3(cmx+6, cmy+6, cmz+10),
              new Vector3(cmx-6, cmy+1, cmz+10),
              new Vector3(cmx-6, cmy+3, cmz+10),
              new Vector3(cmx-6, cmy+1, cmz+10),
              new Vector3(cmx+6, cmy+8, cmz+10),
              new Vector3(cmx+6, cmy+6, cmz+10),
          };

              return lista;
          }

          public List<Vector3> cargarVerticesRepisaInferior(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx-4, cmy-1, cmz+10),
              new Vector3(cmx-6, cmy+1, cmz+10),
              new Vector3(cmx+8, cmy+4, cmz+10),
              new Vector3(cmx+6, cmy+6, cmz+10),

          };

              return lista;
          }

          public List<Vector3> cargarVerticesRepisaSuperior(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx-4, cmy+1, cmz+10),
              new Vector3(cmx-6, cmy+3, cmz+10),
              new Vector3(cmx+8, cmy+6, cmz+10),
              new Vector3(cmx+6, cmy+8, cmz+10),

          };

              return lista;
          }
          /// //////////////////////////////////////////////////////////////////////
          /// Objeto auto
          public List<Vector3> cargarVerticesAutoFrontal(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx-2, cmy+6, cmz+10),
              new Vector3(cmx-1, cmy+5, cmz+10),
              new Vector3(cmx-1, cmy+3, cmz+10),
              new Vector3(cmx-2, cmy+4, cmz+10),
              new Vector3(cmx-1, cmy+3, cmz+10),
              new Vector3(cmx-1, cmy+5, cmz+10),
              new Vector3(cmx-2, cmy+4, cmz+10),
              new Vector3(cmx-2, cmy+6, cmz+10),
          };

              return lista;
          }

          public List<Vector3> cargarVerticesAutoTrasera(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx+2, cmy+8, cmz+10),
              new Vector3(cmx+3, cmy+7, cmz+10),
              new Vector3(cmx+3, cmy+5, cmz+10),
              new Vector3(cmx+2, cmy+6, cmz+10),
              new Vector3(cmx+3, cmy+5, cmz+10),
              new Vector3(cmx+3, cmy+7, cmz+10),
              new Vector3(cmx+2, cmy+6, cmz+10),
              new Vector3(cmx+2, cmy+8, cmz+10),
          };

              return lista;
          }

          public List<Vector3> cargarVerticesAutoInferior(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx-1, cmy+3, cmz+10),
              new Vector3(cmx+3, cmy+5, cmz+10),
              new Vector3(cmx-2, cmy+4, cmz+10),
              new Vector3(cmx+2, cmy+6, cmz+10),

          };

              return lista;
          }

          public List<Vector3> cargarVerticesAutoSuperior(float cmx, float cmy, float cmz)
          {
              List<Vector3> lista = new List<Vector3>
          {
              new Vector3(cmx-1, cmy+5, cmz+10),
              new Vector3(cmx+3, cmy+7, cmz+10),
              new Vector3(cmx-2, cmy+6, cmz+10),
              new Vector3(cmx+2, cmy+8, cmz+10),

          };
              return lista;
          }

          public Vector3 cargarVerticesAutoRuedaTraseraIzq(float cmx, float cmy, float cmz)
          {
              Vector3 vertice = new Vector3();
          {
                  vertice.X = cmx + 2;
                  vertice.Y = cmy + 4.5f;
                  vertice.Z = cmz + 10; 
          };
              return vertice;
          }

          public Vector3 cargarVerticesAutoRuedaDelanteraIzq(float cmx, float cmy, float cmz)
          {
              Vector3 vertice = new Vector3();
              {
                  vertice.X = cmx + 0.5f;
                  vertice.Y = cmy + 3.8f;
                  vertice.Z = cmz + 10;
              };
              return vertice;
          }


          public Vector3 cargarVerticesAutoRuedaTraseraDer(float cmx, float cmy, float cmz)
          {
              Vector3 vertice = new Vector3();
              {
                  vertice.X = cmx + 1;
                  vertice.Y = cmy + 5.5f;
                  vertice.Z = cmz + 10;
              };
              return vertice;
          }

          public Vector3 cargarVerticesAutoRuedaDelanteraDer(float cmx, float cmy, float cmz)
          {
              Vector3 vertice = new Vector3();
              {
                  vertice.X = cmx - 0.5f;
                  vertice.Y = cmy + 4.8f;
                  vertice.Z = cmz + 10;
              };
              return vertice;
          }*/

        /// 

        // new Vector3(-9, -12, 10)
        public void cargarValores()
        {
            // partes del objeto pared


         /*  partePared.adicionar("parte frontal", new Poligono());
            partePared.adicionar("parte trasera",new Poligono());
            partePared.adicionar("parte inferior",new Poligono());
            partePared.adicionar("parte superior",new Poligono());
            //////////////////////////////
            ///
            // partes del objeto repisa
            parteRepisa.adicionar("parte frontal", new Poligono());
            parteRepisa.adicionar("parte trasera", new Poligono());
            parteRepisa.adicionar("parte inferior", new Poligono());
            parteRepisa.adicionar("parte superior", new Poligono());
            ///////////////////////////////////////////////////////

            // partes del auto 
            parteAuto.adicionar("parte frontal",new Poligono());
            parteAuto.adicionar("parte trasera", new Poligono());
            parteAuto.adicionar("parte inferior", new Poligono());
            parteAuto.adicionar("parte superior", new Poligono());
            parteAuto.adicionar("rueda trasera izq",new Poligono());
            parteAuto.adicionar("rueda delantera izq", new Poligono());
            parteAuto.adicionar("rueda trasera der", new Poligono());
            parteAuto.adicionar("rueda delantera der", new Poligono());*/
        }

        public void Dibujar(float cmx, float cmy, float cmz)
        {
            
            // dibujar partes del auto 
           /* parteAuto.obtener("rueda trasera izq").DibujarCirculo(Color4.Black, cargarVerticesAutoRuedaTraseraIzq(cmx, cmy, cmz));
            parteAuto.obtener("rueda delantera izq").DibujarCirculo(Color4.Black, cargarVerticesAutoRuedaDelanteraIzq(cmx, cmy, cmz));

           

            parteAuto.obtener("parte frontal").DibujarLineQuads(Color4.Red, cargarVerticesAutoFrontal(cmx, cmy, cmz));
            parteAuto.obtener("parte trasera").DibujarLineQuads(Color4.Red, cargarVerticesAutoTrasera(cmx, cmy, cmz));
            parteAuto.obtener("parte inferior").DibujarLineQuads(Color4.Red, cargarVerticesAutoInferior(cmx, cmy, cmz));

            parteAuto.obtener("rueda trasera der").DibujarCirculo(Color4.Black, cargarVerticesAutoRuedaTraseraDer(cmx, cmy, cmz));
            parteAuto.obtener("rueda delantera der").DibujarCirculo(Color4.Black, cargarVerticesAutoRuedaDelanteraDer(cmx, cmy, cmz));

            parteAuto.obtener("parte superior").DibujarLineQuads(Color4.Red, cargarVerticesAutoSuperior(cmx, cmy, cmz));


            /////////////////////////////////
            /// dibujar partes de la repisa
            parteRepisa.obtener("parte frontal").DibujarLineQuads(Color4.Blue, cargarVerticesRepisaFrontal(cmx, cmy, cmz));
            parteRepisa.obtener("parte trasera").DibujarLineQuads(Color4.Blue, cargarVerticesRepisaTrasera(cmx, cmy, cmz));
            parteRepisa.obtener("parte inferior").DibujarLineQuads(Color4.Blue, cargarVerticesRepisaInferior(cmx, cmy, cmz));
            parteRepisa.obtener("parte superior").DibujarLineQuads(Color4.Blue, cargarVerticesRepisaSuperior(cmx, cmy, cmz));
            ////////////////////////

            // dibujar partes de la pared
            partePared.obtener("parte frontal").DibujarLineQuads(Color4.Brown,cargarVerticesParedFrontal(cmx,cmy,cmz));
            partePared.obtener("parte trasera").DibujarLineQuads(Color4.Brown,cargarVerticesParedTrasera(cmx,cmy,cmz));
            partePared.obtener("parte inferior").DibujarLineQuads(Color4.Brown,cargarVerticesParedInferior(cmx,cmy,cmz));
            partePared.obtener("parte superior").DibujarLineQuads(Color4.Brown,cargarVerticesParedSuperior(cmx,cmy,cmz));*/
            ///////////////////////





        }



    }
}
