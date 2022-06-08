using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_19_AgentVisitor
{
    class Agent: IAgent
    {
        public void VisitHouse(ComponentHouse element)
        {
            Console.WriteLine(element.ExclusiveMethodOfComponentHouse());
        }

        public void VisitFactory(ComponentFactory element)
        {
            Console.WriteLine(element.ExclusiveMethodOfComponentFactory());
        }

        public void VisitBank(ComponentBank element)
        {
            Console.WriteLine(element.ExclusiveMethodOfComponentBank());
        }
    }
}
