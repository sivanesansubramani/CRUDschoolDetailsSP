using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDschoolDetails;
using CRUDschoolDetails.Business;
using CRUDschoolDetails.Repository;
using CRUDschoolDetails.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolDetailsApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchooldetailsController : ControllerBase
    {


        CRUDmethods objApiCrud;

        public SchooldetailsController()
        {
            objApiCrud = new CRUDmethods();
        }



        // GET: api/<SchooldetailsController>
        [HttpGet]
        public IEnumerable<SchoolDetailsModel> Get()
        {
            return objApiCrud.SelectSchoolDetailsCRUD();
        }

        // GET api/<SchooldetailsController>/5
        [HttpGet("{id}")]
        public IEnumerable<SchoolDetailsModel> Get(int id)
        {
            return objApiCrud.SelectSchoolDetailsCRUD(id);
        }

        // POST api/<SchooldetailsController>
        [HttpPost]
        public void Post([FromBody] SchoolDetailsModel value)
        {
            objApiCrud.InsertSchoolDetailsCRUD(value);

        }

        // PUT api/<SchooldetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SchoolDetailsModel value)
        {
            value.Id = id;
            objApiCrud.UbdateSchoolDetailsCRUD(value);
        }

        // DELETE api/<SchooldetailsController>/5
        [HttpDelete("{SchoolName}")]
        public void Delete(string SchoolName)
        {

            objApiCrud.DeleteSchoolDetailsCRUD(SchoolName);
        }
    }
}
