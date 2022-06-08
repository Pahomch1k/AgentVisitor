using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_19_AgentVisitor
{
    interface IAgent
    {
        void VisitHouse(ComponentHouse element); 

        void VisitFactory(ComponentFactory element);

        void VisitBank(ComponentBank element); 
    }
}
