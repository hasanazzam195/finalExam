using finalProject.data;
using finalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatiantController : ControllerBase
    {
        private  IPatiantService patiantService;
        private  ICountryService countryService;
        private  ICityService cityService;
        private  IBedService bedService;
        private  IRoomService roomService;
        private  IDoctorService doctorService;

        public PatiantController(IPatiantService _patiantService, ICountryService _countryService, ICityService _cityService, 
            IBedService _bedService,IRoomService _roomService, IDoctorService _doctorService)
        {
            patiantService = _patiantService;
            countryService = _countryService;
            cityService = _cityService;
            bedService = _bedService;
            roomService = _roomService;
            doctorService = _doctorService;
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Country> LoadAll()
        {
            List<Country> li = countryService.LoadAll();
            return li;
        }
        [HttpGet]
        [Route("LoadAllCity")]
        public List<City> LoadAllCity()
        {
            List<City> li = cityService.LoadAll();
            return li;
        }
        [HttpGet]
        [Route("LoadAllBed")]
        public List<Bed> LoadAllBed()
        {
            List<Bed> li = bedService.LoadAll();
            return li;
        }

        [HttpGet]
        [Route("LoadAllRoom")]
        public List<Room> LoadAllRoom()
        {
            List<Room> li = roomService.LoadAll();
            return li;
        }
        [HttpGet]
        [Route("LoadAllDoctor")]
        public List<Doctor> LoadAllDoctor()
        {
            List<Doctor> li = doctorService.LoadAll();
            return li;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Patiant patiant)
        {
            patiantService.Insert(patiant);
        }
    }
}
