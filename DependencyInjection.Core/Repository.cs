using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Core.Models;

namespace DependencyInjection.Core
{
    public interface IRepository
    {
        Person GetPerson(Guid id);
        void Update(Person person);
    }

    public class Repository : IRepository
    {
        public Person GetPerson(Guid id)
        {
            return null;
        }

        public void Update(Person person)
        {

        }
    }
}
