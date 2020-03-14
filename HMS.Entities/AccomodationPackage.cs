﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{

    public class AccomodationPackage
    {
        [Key]
        public int Id { get; set; }

        public int AccomodationTypeId { get; set; }
        public AccomodationType AccomodationType { get; set; }

        public string Name { get; set; }
        public int NoOfRoom { get; set; }

        public decimal FeePerNight { get; set; }
    }
}
