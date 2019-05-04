using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormCreatorMVC.DAL;
using FormCreatorMVC.DAL.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FormCreatorMVC.Services
{
    public class FormService : IFormService
    {
        private readonly AppDbContext context;
        public FormService(AppDbContext context)
        {
            this.context = context;
        }
        public bool AddForm(Forms form)
        {
            try
            {
                context.Forms.Add(form);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        public async Task<IEnumerable<Forms>> Get()
        {
            var forms = await context.Forms.ToListAsync();
            return forms;
        }
        public  Forms GetByID(string id)
        {
            var forms = context.Forms.Where(w => w.ID == id).Select(s => s).FirstOrDefault();
            return forms;
        }

        public IEnumerable<Forms> Search(string searchTerm)
        {
            var searchResult = context.Forms
            .Where(c => c.Name.Contains(searchTerm))
            .Select(s => new Forms
            {
                Name = s.Name,
                CreatedAt = s.CreatedAt,
                CreatedBy = s.CreatedBy,
                CreatorAge = s.CreatorAge,
                CreatorName = s.CreatorName,
                CreatorLastName = s.CreatorLastName,
                Description = s.Description,
                ID = s.ID
            });
            return searchResult;
        }
    }
}
