using finalProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public class CityService : ICityService
    {
        private HospetalContext context;

        public CityService(HospetalContext _context)
        {
            context = _context;
        }

        public List<City> LoadAll()
        {
            List<City> li = context.cities.ToList();
            return li;
        }
    }
}
