using finalProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public class DoctorService : IDoctorService
    {
        private HospetalContext context;

        public DoctorService(HospetalContext _context)
        {
            context = _context;
        }

        public List<Doctor> LoadAll()
        {
            List<Doctor> li = context.doctors.ToList();
            return li;
        }
    }
}
