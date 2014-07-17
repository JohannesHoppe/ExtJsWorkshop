using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class TodoController : ApiController
    {
        // GET api/values
        public IEnumerable<Todo> Get()
        {
            IEnumerable<Todo> data = TodoRepository.GetAllToDos();
            return data;
        }

        // GET api/values/5
        public Todo Get(int id)
        {
            Todo item = TodoRepository.GetAllToDos().FirstOrDefault(x => x.Id == id);
            return item;

        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}