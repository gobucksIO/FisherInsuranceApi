using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Model;


[Route("api/quotes")]
 public class QuotesController : Controller{
     private readonly FisherContext db;

     public QuotesController(FisherContext context)
     {
         db = context;
     }
     public IActionResult GetQuotes()
     {
         return Ok(db.Quotes);
     }

     [HttpGet("{id}", Name= "QetQuote")]
     public IActionResult Get(int id){
         
         return Ok(db.Quotes.Find(id));
     }

     [HttpPost]
     public IActionResult Post([FromBody] Quote quote){
         var newQuote= db.Quotes.Add(quote);
         db.SaveChanges();
         return CreatedAtRoute("GetQuote", new {id = quote.Id}, quote);

     }
     [HttpPut ("{id}")]
     public IActionResult Put(int id, [FromBody] Quote quote){
         var newQuote= db.Quotes.Find(id);
         if (newQuote == null)
         {
            return NotFound();
         }
         newQuote.Price=quote.Price;
         newQuote.Product=quote.Product;
         newQuote.ExpireDate=quote.ExpireDate;         
         
         db.Quotes.Update(newQuote);
         db.SaveChanges();
         return Ok(newQuote);
     }
     
     [HttpDelete ("{id}")]
     public IActionResult Delete(int id){
         var quoteToDelete = db.Quotes.Find(id);
         if(quoteToDelete == null){
             return NotFound();
         }
         db.Quotes.Remove(quoteToDelete);
         db.SaveChangesAsync();
         return NoContent();
     }

    }

