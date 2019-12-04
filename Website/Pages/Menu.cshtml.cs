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
        public Menu menu = new Menu();

        public IEnumerable<IMenuItem> Items;

        public List<CretaceousCombo> Combos;

        public List<Entree> Entrees;

        public List<Drink> Drinks;

        public List<Side> Sides;

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

        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }
        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();
        public void OnGet()
        {
            Items = menu.AvailableMenuItems;
            Combos = Items.OfType<CretaceousCombo>().ToList();
            Entrees = Items.OfType<Entree>().ToList();
            Drinks = Items.OfType<Drink>().ToList();
            Sides = Items.OfType<Side>().ToList();
            /*Combos = menu.AvailableCombos;
            Entrees = menu.AvailableEntrees;
            Drinks = menu.AvailableDrinks;
            Sides = menu.AvailableSides;*/
        }
        public void OnPost()
        {
            Items = menu.AvailableMenuItems;
            if (search != null)
            {
                /*Combos = null;
                Entrees = null;
                Drinks = null;
                Sides = null;
                if (category.Contains("Combos")) Combos = menu.SearchMenuItems(menu.AvailableCombos, search);
                if (category.Contains("Entrees")) Entrees = menu.SearchMenuItems(menu.AvailableEntrees, search);
                if (category.Contains("Drinks")) Drinks = menu.SearchMenuItems(menu.AvailableDrinks, search);
                if (category.Contains("Sides")) Sides = menu.SearchMenuItems(menu.AvailableSides, search);*/
                Items = Items.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            /*else
            {
                if (category.Contains("Combos")) Combos = menu.AvailableCombos;
                if (category.Contains("Entrees")) Entrees = menu.AvailableEntrees;
                if (category.Contains("Drinks")) Drinks = menu.AvailableDrinks;
                if (category.Contains("Sides")) Sides = menu.AvailableSides;
            }*/
            if (minimumPrice is float min)
            {
                /*Combos = menu.FilterByMin(Combos, min);
                Entrees = menu.FilterByMin(Entrees, min);
                Drinks = menu.FilterByMin(Drinks, min);
                Sides = menu.FilterByMin(Sides, min);*/
                Items = Items.Where(item => item.Price >= minimumPrice);
            }
            if (maximumPrice is float max)
            {
                /*Combos = menu.FilterByMax(Combos, max);
                Entrees = menu.FilterByMax(Entrees, max);
                Drinks = menu.FilterByMax(Drinks, max);
                Sides = menu.FilterByMax(Sides, max);*/
                Items = Items.Where(item => item.Price <= maximumPrice);
            }
            if (ingredients.Count > 0)
            {
                /*Combos = menu.FilterByIngredients(Combos, ingredients);
                Entrees = menu.FilterByIngredients(Entrees, ingredients);
                Drinks = menu.FilterByIngredients(Drinks, ingredients);
                Sides = menu.FilterByIngredients(Sides, ingredients);*/
                foreach(string ingredient in ingredients)
                {
                    Items = Items.Where(item => !item.Ingredients.Contains(ingredient));
                }
            }
            if (Items != null)
            {
                if (category.Contains("Combos")) Combos = Items.OfType<CretaceousCombo>().ToList();
                if (category.Contains("Entrees")) Entrees = Items.OfType<Entree>().ToList();
                if (category.Contains("Drinks")) Drinks = Items.OfType<Drink>().ToList();
                if (category.Contains("Sides")) Sides = Items.OfType<Side>().ToList();
            }
        }
    }
}