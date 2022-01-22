using finalProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public class PatiantService : IPatiantService
    {
        private  HospetalContext context;

        public PatiantService(HospetalContext _context)
        {
            context = _context;
        }

        public List<Country> LoadAll()
        {
            List<Country> li = context.countries.ToList();
            return li;
        }

        public void Insert(Patiant patiant)
        {
            context.patiants.Add(patiant);
            context.SaveChanges();
        }
    }
}
