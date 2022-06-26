using Earbuds_Webservice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Earbuds_Webservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EarBudsController : Controller
    {
        public List<Earbud> GetEarbuds()
        {
            List<Earbud> lst = new List<Earbud>();
            lst.Add(new Earbud() { EarbudID = 1, EarbudName = "MaxPro", Cost = 2000 });
            lst.Add(new Earbud() { EarbudID = 2, EarbudName = "Air2", Cost = 4000 });
            lst.Add(new Earbud() { EarbudID = 3, EarbudName = "Dopes", Cost = 6000 });
            return lst;

        }
    }
}
