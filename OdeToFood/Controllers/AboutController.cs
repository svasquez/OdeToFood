using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("About")]
    public class AboutController
    {
        [Route("")]
        public string Phone() => "809-555-5555";

        [Route("address")]
        public string Address() => "Santo Domingo";
    }
}
