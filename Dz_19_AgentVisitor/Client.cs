using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_19_AgentVisitor
{
    class Client
    {
        public static void ClientCode(IComponent component, IAgent agent)
        {
            component.Accept(agent);
        }
    }
}
