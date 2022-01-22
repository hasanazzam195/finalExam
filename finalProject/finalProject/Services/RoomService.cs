using finalProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public class RoomService: IRoomService
    {
        private HospetalContext context;

        public RoomService(HospetalContext _context)
        {
            context = _context;
        }

        public List<Room> LoadAll()
        {
            List<Room> li = context.rooms.ToList();
            return li;
        }
    }
}
