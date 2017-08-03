using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTravel.Models
{
    public class Request
    {
        public Passengers passengers { get; set; }
        public Slouse[] slice { get; set; }

    }
}