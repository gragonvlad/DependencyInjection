using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DependencyInjection.Core;
using DependencyInjection.Core.Models;

namespace DependencyInjection.Web.Controllers.Api
{
    public class PersonController : ApiController
    {
        private readonly IRepository _repository;

        public PersonController(IRepository repository)
        {
            _repository = repository;
        }

        public Person Get(Guid id)
        {
            var person = _repository.GetPerson(id);

            return person;
        }

        public void Post(Guid id, Person person)
        {
            if (person.Id != id)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _repository.Update(person);
        }
    }
}
