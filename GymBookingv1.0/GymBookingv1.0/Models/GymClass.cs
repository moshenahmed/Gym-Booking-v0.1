using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymBookingv1._0.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
       
        
        public TimeSpan Duration { get; set; }
      
        public DateTime EndTime { get { return StartTime + Duration; } }
        public string Description { get; set; }
        public virtual ICollection<ApplicationUser> AttendingMembers { get; set; }
    }
}