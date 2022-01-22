using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.data
{
    [Table("Doctors")]
    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Patiant> liPatiant { get; set; }
    }
}
