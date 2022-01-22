using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.data
{
    [Table("Patiants")]
    public class Patiant
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BDate { get; set; }
        [ForeignKey("country")]
        public int Country_id { get; set; }
        [ForeignKey("city")]
        public int City_id { get; set; }
        [ForeignKey("room")]
        public int Room_id { get; set; }
        [ForeignKey("bed")]
        public int Bed_id { get; set; }
        [ForeignKey("doctor")]
        public int Doctor_id { get; set; }
        [ForeignKey("department")]
        public int department_id { get; set; }
        public Country country { get; set; }
        public City city { get; set; }
        public Room room { get; set; }
        public Bed bed { get; set; }
        public Doctor doctor { get; set; }
        public Department department { get; set; }
        public string Status { get; set; }

    }
}
