using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareOppsMobile.Views;

namespace ShareOppsMobile
{

    public class EntryPageMenuItem
    {
        public EntryPageMenuItem()
        {
            TargetType = typeof(Categories);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public string Icon { get; set; }
    }
}