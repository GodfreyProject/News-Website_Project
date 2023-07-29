using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using News_ClassLibrary.DBClasses;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;

namespace WAD_ASSIGNMENT.Pages
{
    public class AddContentModel : PageModel
    {
      
      
       // private IFormFile img;
        [BindProperty]

        public IFormFile Upload { get; set; }
      
        public String Msg { get; set; }
        [BindProperty]

        public NewsArticle article { get; set; }

        private IHostingEnvironment _environment;
        public AddContentModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        
        public async Task OnPostAsync()
        {
            //if (String.IsNullOrEmpty(article.Img))
            //{
            //    Msg = "Images can not be Empty ";
            //    ViewData["Msg"] = Msg;
            //}
            //else
            //{
                var file = Path.Combine(_environment.ContentRootPath, @"wwwroot\photo", Upload.FileName);
           
            
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    article.Img = Upload.FileName;
                    NewsArticleManager gameDB = new NewsArticleManager(new NewsArticleRePository());
                    gameDB.AddArticle(article);
                    await Upload.CopyToAsync(fileStream);
                    article.Img = Upload.FileName;

                    //if (ModelState.IsValid)
                    //{
                    //    GameDB gameDB = new GameDB();
                    //    gameDB.AddGame(Game);
                    //    new RedirectToPageResult("/Game");
                    //}
                    //else
                    //{
                    //    Page();
                    //}
                //}

            }

        }
        public IActionResult OnGet()
        {

            if (HttpContext.Session.GetString("UserPosition") == "Admin")
            {
                return Page();
            }
            else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            {
                return new RedirectToPageResult("index");
                //return Page();
            }
            return new RedirectToPageResult("index");
            //if (HttpContext.Session.GetString("UserPosition") == "Admin")
            //{
            //    return Page();
            //}
            //else if (HttpContext.Session.GetString("UserPosition") == "Customer")
            //{
            //    return new RedirectToPageResult("Index");
            //}
            //return Page();
        }

     
    }
}
