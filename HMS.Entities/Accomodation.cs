using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class Accomodation
    {
        [Key]
        public int Id { get; set; }

        public int AccomodationPackageId { get; set; }
        public AccomodationPackage AccomodationPackage { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
