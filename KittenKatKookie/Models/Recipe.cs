using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static System.Environment;

namespace KittenKatKookie.Models
{
    public class Recipe
    {
        [Required]
        public long Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "you have to input a name btwn 5 and 100 character")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Directions { get; set; }
        [Required]
        public string Ingredients { get; set; }

        public IEnumerable<string> DirectionsList
        {
            get { return (Directions ?? string.Empty).Split(NewLine); }
        }

        public IEnumerable<string> IngredientsList
        {
            get { return (Ingredients ?? string.Empty).Split(NewLine); }
        }

        public string SrcImage { get; set; }
    }
}
