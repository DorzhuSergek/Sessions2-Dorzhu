using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentsExamen
{
    partial class user9Entities
    {
        public static user9Entities _context;
        public static user9Entities GetContext()
        {
            if (_context == null)
            {
                _context = new user9Entities();
            }
            return _context;
        }
    }
}
