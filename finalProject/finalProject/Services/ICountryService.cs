using finalProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public interface ICountryService
    {
        List<Country> LoadAll();
    }
}
