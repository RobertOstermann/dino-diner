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

        public List<Entree> Entrees;

        public List<Drink> Drinks;

        public List<Side> Sides;

        [BindProperty]
        public string search { get; set; }

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
                Combos = menu.SearchCombos(search);
                Entrees = menu.SearchEntrees(search);
                Drinks = menu.SearchDrinks(search);
                Sides = menu.SearchSides(search);
            }
            else
            {
                Combos = menu.AvailableCombos;
                Entrees = menu.AvailableEntrees;
                Drinks = menu.AvailableDrinks;
                Sides = menu.AvailableSides;
            }
        }
    }
}