using Microsoft.AspNetCore.Mvc;
using WebAPI_M.Models;
using WebAPI_M.Models.NewFolder;
using WebAPI_M.Students;

namespace WebAPI_M.Controllers
{
    //[Route("api/[Controller]")]
    [ApiController]
    [Route("api/Person")]
    public class Person : ControllerBase
    {
        private readonly DBcontext _db;
        public Person(DBcontext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PersonM>> GetPersonModel()
        {
            return Ok(_db.PersonModels.ToList() );
        }


        [HttpGet("{id:int}",Name="GetPerson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        //[ProducesResponseType(200)]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(400)]
        public ActionResult<PersonM> GetPersonOneModel(int id)
        {
            if (id == 0)    
            {
                return BadRequest();
            }
            var persondata = _db.PersonModels.FirstOrDefault(u => u.personId == id);
            if (persondata == null)
            {
                return NotFound();
            }
            return Ok(persondata);
        }
        [HttpPost]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<PersonM> CreatePersonModel([FromBody] PersonM PersonM)
        {
            //if (!ModelState.IsValid) { 
            //    return BadRequest(ModelState);
            //}
            if (_db.PersonModels.FirstOrDefault(u => u.personName.ToLower() == PersonM.personName.ToLower())!=null) {
                ModelState.AddModelError("CustomError", "Person already Exists!");
                return BadRequest();
            }
            if (PersonM == null)
            {
                return BadRequest(PersonM);
            }
            if (PersonM.personId > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            //PersonM.personId = _db.PersonModels.OrderByDescending(u => u.personId).FirstOrDefault().personId + 1;

            PersonModel model = new()
            {
                personId= PersonM.personId,
                personName= PersonM.personName,
                age= PersonM.age,
                CreatedTime= DateTime.Now,
            };
            _db.PersonModels.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetPerson",new { id= PersonM.personId }, PersonM);
        }
       
        [HttpDelete("{id:int}", Name = "DeletePerson")]
        
        public IActionResult DeletePerson(int id)
        {
            if (id==0) {
                return BadRequest();
            }
            var persondata = _db.PersonModels.FirstOrDefault(u => u.personId == id);
            if (persondata == null)
            {
                return NotFound();
            }
            _db.PersonModels.Remove(persondata);
            _db.SaveChanges();
            return NoContent(); 
        }

        [HttpPut("{id:int}", Name = "UpdatePerson")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdatePersonModel(int id,[FromBody] PersonM PersonM)
        {
            if (PersonM==null || id!= PersonM.personId) { 
                return BadRequest();    
            }
            //var persondata = _db.PersonModels.FirstOrDefault(u => u.personId == id);
            //persondata.personName = PersonM.personName;
            //persondata.age = PersonM.age;
            PersonModel model = new()
            {
                personId = PersonM.personId,
                personName = PersonM.personName,
                age = PersonM.age,
                CreatedTime = DateTime.Now,
            };
            _db.PersonModels.Update(model);
            _db.SaveChanges();
            return NoContent();
        }


    }

}