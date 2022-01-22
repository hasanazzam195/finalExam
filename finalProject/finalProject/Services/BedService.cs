using finalProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public class BedService: IBedService
    {
        private HospetalContext context;

        public BedService(HospetalContext _context)
        {
            context = _context;
        }

        public List<Bed> LoadAll()
        {
            List<Bed> li = context.beds.ToList();
            return li;
        }
    }
}
