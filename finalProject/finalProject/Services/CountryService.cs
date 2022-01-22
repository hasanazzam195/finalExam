using finalProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public class CountryService : ICountryService
    {
        private HospetalContext context;

        public CountryService(HospetalContext _context)
        {
            context = _context;
        }

        public List<Country> LoadAll()
        {
            List<Country> li = context.countries.ToList();
            return li;
        }
    }
}
