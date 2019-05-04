using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormCreatorMVC.DAL.Models;

namespace FormCreatorMVC.Services
{
    public interface IFormService
    {
      IEnumerable<Forms> Search(string searchTerm);
      Task<IEnumerable<Forms>> Get();
      bool AddForm(Forms form);
      Forms GetByID(string id);
    }
}
