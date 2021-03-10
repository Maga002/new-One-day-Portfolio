using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
     public class Sect1_Service
    {
        public ApplicationDbContext _context;

        public Sect1_Service(ApplicationDbContext context)
        {
            _context = context;
        }
       
    }
}
