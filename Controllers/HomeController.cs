using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FormCreatorMVC.DAL;
using FormCreatorMVC.DAL.Models;
using FormCreatorMVC.Models;
using FormCreatorMVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormCreatorMVC.Controllers
{  
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IFormService formService;
        public HomeController(IFormService formService)
        {
            this.formService = formService;
        }
        // GET: /<controller>/
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Admin()
        {
            var adminViewModel = new AdminViewModel { Forms = await formService.Get() };
            return View(adminViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Admin(SearchForm searchForm)
        {           
            var adminViewModel = new AdminViewModel();

            if (ModelState.IsValid) 
            {
                adminViewModel.Forms = formService.Search(searchForm.SearchString);
                return View(adminViewModel);
            }
            adminViewModel.Forms = await formService.Get();
            return View(adminViewModel);
        }
        [HttpPost]
        public  IActionResult Add([FromBody]Forms forms)
        {
           
            forms.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {
                   var addResult = formService.AddForm(forms);
                    if (!addResult)
                    {
                        return Json(new { newUrl = Url.Action("Error", "Home") });
                    }
                    return Json(new { newUrl = Url.Action("Admin", "Home") });                         
            }
            return Json(new { newUrl = Url.Action("Error", "Home") });
        }

        [HttpGet]   
        public IActionResult Forms(string id)
        {
            var formViewModel = new FormViewModel();
            if (!string.IsNullOrEmpty(id))
            {
                formViewModel.Form = formService.GetByID(id);
               
                return View(formViewModel); 
            }       
            return View(formViewModel);
        }  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

    }
}
