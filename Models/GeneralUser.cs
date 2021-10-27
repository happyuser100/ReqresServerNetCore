using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userApi.Models
{
    public class GeneralUser
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum> data { get; set; }
        public Support support { get; set; }
    }
}
