using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentsExamen
{
    partial class Agents
    {
        public string getLogo
        {
            get
            {
                if (ЛоготипАгента == null)
                    return null;
                return "Resources" + ЛоготипАгента;
            }
        }
    }
}
