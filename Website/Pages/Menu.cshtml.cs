using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu menu = new DinoDiner.Menu.Menu();

        public List<CretaceousCombo> Combos;

        public bool ShowCombos
        {
            get
            {
                if (Combos != null)
                {
                    if (Combos.Count > 0) return true;
                }
                return false;
            }
        }

        public List<Entree> Entrees;

        public bool ShowEntrees
        {
            get
            {
                if (Entrees != null)
                {
                    if (Entrees.Count > 0) return true;
                }
                return false;
            }
        }

        public List<Drink> Drinks;

        public bool ShowDrinks
        {
            get
            {
                if (Drinks != null)
                {
                    if (Drinks.Count > 0) return true;
                }
                return false;
            }
        }

        public List<Side> Sides;

        public bool ShowSides
        {
            get
            {
                if (Sides != null)
                {
                    if (Sides.Count > 0) return true;
                }
                return false;
            }
        }

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> category { get; set; } = new List<string>() { "Combos", "Entrees", "Drinks", "Sides" };

        public void OnGet()
        {
            Combos = menu.AvailableCombos;
            Entrees = menu.AvailableEntrees;
            Drinks = menu.AvailableDrinks;
            Sides = menu.AvailableSides;
        }
        public void OnPost()
        {
            if (search != null)
            {
                Combos = null;
                Entrees = null;
                Drinks = null;
                Sides = null;
                if (category.Contains("Combos")) Combos = menu.SearchCombos(search);
                if (category.Contains("Entrees")) Entrees = menu.SearchEntrees(search);
                if (category.Contains("Drinks")) Drinks = menu.SearchDrinks(search);
                if (category.Contains("Sides")) Sides = menu.SearchSides(search);
            }
            else
            {
                if (category.Contains("Combos")) Combos = menu.AvailableCombos;
                if (category.Contains("Entrees")) Entrees = menu.AvailableEntrees;
                if (category.Contains("Drinks")) Drinks = menu.AvailableDrinks;
                if (category.Contains("Sides")) Sides = menu.AvailableSides;
            }
        }
    }
}