using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShareOppsMobile.Models
{
    public class SavedOppotunities
    {

        public int Id { get; set; }

        public string Title { get; set; }


        public string Description { get; set; }

        public string Organisation { get; set; }
        public string Venue { get; set; }
        public string Eligibility { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string OppotunityLink { get; set; }
        public string Benefits { get; set; }
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
       
        public string Category { get; set; }
        public string UserId { get; set; }
    }
}