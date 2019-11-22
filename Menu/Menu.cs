/* Menu.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Gets a list of available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                JurassicJava jurassicJava = new JurassicJava();
                Sodasaurus sodasaurus = new Sodasaurus();
                Tyrannotea tyrannotea = new Tyrannotea();
                Water water = new Water();
                Brontowurst brontowurst = new Brontowurst();
                DinoNuggets dinoNuggets = new DinoNuggets();
                PrehistoricPBJ prehistoricPBJ = new PrehistoricPBJ();
                PterodactylWings pterodactylWings = new PterodactylWings();
                SteakosaurusBurger steakosaurusBurger = new SteakosaurusBurger();
                TRexKingBurger kingBurger = new TRexKingBurger();
                VelociWrap velociWrap = new VelociWrap();
                Fryceritops fryceritops = new Fryceritops();
                MeteorMacAndCheese meteorMacAndCheese = new MeteorMacAndCheese();
                MezzorellaSticks mezzorellaSticks = new MezzorellaSticks();
                Triceritots triceritots = new Triceritots();
                CretaceousCombo brontowurstCombo = new CretaceousCombo(brontowurst);
                CretaceousCombo dinoNuggetsCombo = new CretaceousCombo(dinoNuggets);
                CretaceousCombo prehistoricCombo = new CretaceousCombo(prehistoricPBJ);
                CretaceousCombo pterodactylCombo = new CretaceousCombo(pterodactylWings);
                CretaceousCombo steakosaurusCombo = new CretaceousCombo(steakosaurusBurger);
                CretaceousCombo kingBurgerCombo = new CretaceousCombo(kingBurger);
                CretaceousCombo velociWrapCombo = new CretaceousCombo(velociWrap);
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(jurassicJava);
                items.Add(sodasaurus);
                items.Add(tyrannotea);
                items.Add(water);
                items.Add(brontowurst);
                items.Add(dinoNuggets);
                items.Add(prehistoricPBJ);
                items.Add(pterodactylWings);
                items.Add(steakosaurusBurger);
                items.Add(kingBurger);
                items.Add(velociWrap);
                items.Add(fryceritops);
                items.Add(meteorMacAndCheese);
                items.Add(mezzorellaSticks);
                items.Add(triceritots);
                items.Add(brontowurstCombo);
                items.Add(dinoNuggetsCombo);
                items.Add(prehistoricCombo);
                items.Add(pterodactylCombo);
                items.Add(steakosaurusCombo);
                items.Add(kingBurgerCombo);
                items.Add(velociWrapCombo);
                return items;
            }
        }
        /// <summary>
        /// Gets a list of available entrees.
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                Brontowurst brontowurst = new Brontowurst();
                DinoNuggets dinoNuggets = new DinoNuggets();
                PrehistoricPBJ prehistoricPBJ = new PrehistoricPBJ();
                PterodactylWings pterodactylWings = new PterodactylWings();
                SteakosaurusBurger steakosaurusBurger = new SteakosaurusBurger();
                TRexKingBurger kingBurger = new TRexKingBurger();
                VelociWrap velociWrap = new VelociWrap();
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(brontowurst);
                items.Add(dinoNuggets);
                items.Add(prehistoricPBJ);
                items.Add(pterodactylWings);
                items.Add(steakosaurusBurger);
                items.Add(kingBurger);
                items.Add(velociWrap);
                return items;
            }
        }
        /// <summary>
        /// Gets a list of available sides.
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                Fryceritops fryceritops = new Fryceritops();
                MeteorMacAndCheese meteorMacAndCheese = new MeteorMacAndCheese();
                MezzorellaSticks mezzorellaSticks = new MezzorellaSticks();
                Triceritots triceritots = new Triceritots();
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(fryceritops);
                items.Add(meteorMacAndCheese);
                items.Add(mezzorellaSticks);
                items.Add(triceritots);
                return items;
            }
        }
        /// <summary>
        /// Gets a list of available drinks.
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                JurassicJava jurassicJava = new JurassicJava();
                Sodasaurus sodasaurus = new Sodasaurus();
                Tyrannotea tyrannotea = new Tyrannotea();
                Water water = new Water();
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(jurassicJava);
                items.Add(sodasaurus);
                items.Add(tyrannotea);
                items.Add(water);
                return items;
            }
        }
        /// <summary>
        /// Gets a list of available combos.
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                Brontowurst brontowurst = new Brontowurst();
                DinoNuggets dinoNuggets = new DinoNuggets();
                PrehistoricPBJ prehistoricPBJ = new PrehistoricPBJ();
                PterodactylWings pterodactylWings = new PterodactylWings();
                SteakosaurusBurger steakosaurusBurger = new SteakosaurusBurger();
                TRexKingBurger kingBurger = new TRexKingBurger();
                VelociWrap velociWrap = new VelociWrap();
                CretaceousCombo brontowurstCombo = new CretaceousCombo(brontowurst);
                CretaceousCombo dinoNuggetsCombo = new CretaceousCombo(dinoNuggets);
                CretaceousCombo prehistoricCombo = new CretaceousCombo(prehistoricPBJ);
                CretaceousCombo pterodactylCombo = new CretaceousCombo(pterodactylWings);
                CretaceousCombo steakosaurusCombo = new CretaceousCombo(steakosaurusBurger);
                CretaceousCombo kingBurgerCombo = new CretaceousCombo(kingBurger);
                CretaceousCombo velociWrapCombo = new CretaceousCombo(velociWrap);
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(brontowurstCombo);
                items.Add(dinoNuggetsCombo);
                items.Add(prehistoricCombo);
                items.Add(pterodactylCombo);
                items.Add(steakosaurusCombo);
                items.Add(kingBurgerCombo);
                items.Add(velociWrapCombo);
                return items;
            }
        }
        /// <summary>
        /// Gets a hashset of ingredients.
        /// </summary>
        public HashSet<string> PossibleIngredients
        {
            get
            {
                HashSet<string> ingredients = new HashSet<string>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    foreach (string ingredient in item.Ingredients)
                    {
                        ingredients.Add(ingredient);
                    }
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Searches the menu items by a search string.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<IMenuItem> SearchMenuItems(List<IMenuItem> items, string search)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (item.ToString().Contains(search))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the menu items by price.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMin (List<IMenuItem> items, float min)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            if (items != null)
            {
                foreach (IMenuItem item in items)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the menu items by price.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMax(List<IMenuItem> items, float max)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            if (items != null)
            {
                foreach (IMenuItem item in items)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the menu items by ingredients.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByIngredients(List<IMenuItem> items, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            if (items != null)
            {
                results.AddRange(items);
                foreach (IMenuItem item in items)
                {
                    foreach (string ingredient in ingredients)
                    {
                        if (item.Ingredients.Contains(ingredient))
                        {
                            results.Remove(item);
                            continue;
                        }
                    }
                }
            }
            return results;
        }
        /// <summary>
        /// Displays  the full menu contents.
        /// </summary>
        /// <returns>Menu contents seperated by new line.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(object i in AvailableMenuItems)
            {
                sb.Append(i.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
