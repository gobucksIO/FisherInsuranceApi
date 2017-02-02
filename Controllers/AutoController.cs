[Route("api/auto/quotes")]
 public class AutoController : Controller
 {
      // POST api/auto/quotes
    [HttpPost]
    public IActionResult Post([FromBody]string value)
    {
        return Created("", value);
    }

 // POST api/auto/quotes
    [HttpPost]
    public IActionResult Post([FromBody]string value)
    {   
         return Created("", value);
    }

 }