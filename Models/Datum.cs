﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userApi.Models
{
    public class Datum
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }
}
