using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShareOppsMobile.Models
{
   public  class UserProfile
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Institution { get; set; }
        public string Gender { get; set; }
        public string SectorOfInterest { get; set; }
        public string FieldOfStudy { get; set; }
        public string HighQ { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; }



    }
}
