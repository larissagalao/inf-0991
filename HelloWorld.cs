using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Comentario por <Pablo>
namespace inf0991
{
    public class HelloWorld
    {
        private static void Main(string[] args){ 
            Console.WriteLine("Hello");
            string name;
            name = Console.ReadLine();

            if(name.Length > 0){
                Console.WriteLine("Hello" + name);
            }       
        }
    }
}
//comentario por <Larissa>
//2o comentario por <Larissa>
//segundo comentario por <Pablo>
