using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public int AccomodationId { get; set; }
        public Accomodation Accomodation { get; set; }

        public DateTime FromDate { get; set; }


        /// <summary>
        /// No Of Stay Night
        /// </summary>
        public int Duration { get; set; }
    }
}
