using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_19_AgentVisitor
{
    class ComponentFactory: IComponent
    {
        public void Accept(IAgent agent)
        {
            agent.VisitFactory(this);
        }

        // Конкретные Компоненты могут иметь особые методы, не объявленные в их
        // базовом классе или интерфейсе. Посетитель всё же может использовать
        // эти методы, поскольку он знает о конкретном классе компонента.
        public string ExclusiveMethodOfComponentFactory()
        {
            return "Предложение фабрика";
        }
    }
}
