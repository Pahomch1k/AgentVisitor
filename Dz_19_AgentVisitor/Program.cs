using System;
using System.Collections.Generic;

namespace Dz_19_AgentVisitor
{
    class Program
    {
        static void Main(string[] args)
        {  
            List<IComponent> components = new List<IComponent>
            {
                new ComponentHouse(),
                new ComponentFactory(),
                new ComponentBank()
            };
             
            var agent = new Agent();

            for (int i = 0; i < 10; i++) Client.ClientCode(components[new Random().Next(0, 3)], agent);
             
            Console.WriteLine(); 
        }
    }
}
