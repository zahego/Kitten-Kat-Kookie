using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KittenKatKookie.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KittenKatKookie.Pages.CRUD
{
    [Authorize]
    public class AddEditModel : PageModel
    {
        private readonly IRecipesService recipesService;

        [FromRoute]
        public long? Id { get; set; }
        public bool IsNewRecipe
        {
            get { return Id == null; }
        }
        public AddEditModel(IRecipesService recipesService)
        {
            this.recipesService = recipesService;
        }

        //razors will iterate through items of the object and match the name of the value of the request
        //by the time the onpost method is called, data will be auto populated and ready to use
        //So, when data is changed, when post method is called, it will returned the changed data
        //this need asp-for to help keep track
        [BindProperty]
        public Recipe AddEditRecipe { get; set; }
        [BindProperty]
        public IFormFile UploadImage{ get; set;}

        public async Task OnGetAsync()
        {
            AddEditRecipe = await recipesService.FindAsync(Id.GetValueOrDefault())
                ?? new Recipe();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var recipeHolder = await recipesService.FindAsync(Id.GetValueOrDefault())
                ?? new Recipe();
            recipeHolder.Name = AddEditRecipe.Name;
            recipeHolder.Description = AddEditRecipe.Description;
            recipeHolder.Ingredients = AddEditRecipe.Ingredients;
            recipeHolder.Directions = AddEditRecipe.Directions;
            if (UploadImage != null)
            {
                using(var stream =new System.IO.MemoryStream())
                {
                    await UploadImage.CopyToAsync(stream);
                    //recipeHolder.SrcImage = "" + stream.ToArray();
                    //Trace.WriteLine(recipeHolder.SrcImage);
                    //recipeHolder.SrcImage=
                }
            }
            
            //fixed the issue of creating more new Recipe(). Turn out it was SaveAsync(recipeHolder), not SaveAsync(AddEditRecipe)
            await recipesService.SaveAsync(recipeHolder);
            return RedirectToPage("/Recipe", new { id = recipeHolder.Id });
        }
        public async Task<IActionResult> OnPostDeleteDangerDontDoIt()
        {
            await recipesService.DeleteAsync(Id.Value);
            return RedirectToPage("/Index");
        }
    }
}
