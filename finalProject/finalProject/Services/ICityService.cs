using finalProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public interface ICityService
    {
        public List<City> LoadAll();
       
    }
}
