using Altkom.CSharp.RentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alktom.CSharp.RentSystem.IServices
{
    public interface IPersonsService
    {
        Person GetByName(string fullname);

        Person Get(int id);

        void Add(Person person);

        void Update(Person person);

        void Remove(int id);
    }


  
}
