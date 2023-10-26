using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace tarea1
{
    class Serializable
    {






     
       public void serializarObjeto(object objeto,String archivo)
       {

            try
            {
                String json = JsonConvert.SerializeObject(objeto,Formatting.Indented);
                File.WriteAllText(archivo, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
          
          
        }


        public Escenario deserializarObjeto(String archivo)
        {
          
                String json = File.ReadAllText(archivo);
                return JsonConvert.DeserializeObject<Escenario>(json);
           
            
                
            
            
        }
    }
}
