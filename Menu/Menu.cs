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
        public List<object> AvailableMenuItems
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
                List<object> items = new List<object>();
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
        public List<Entree> AvailableEntrees
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
                List<Entree> items = new List<Entree>();
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
        public List<Side> AvailableSides
        {
            get
            {
                Fryceritops fryceritops = new Fryceritops();
                MeteorMacAndCheese meteorMacAndCheese = new MeteorMacAndCheese();
                MezzorellaSticks mezzorellaSticks = new MezzorellaSticks();
                Triceritots triceritots = new Triceritots();
                List<Side> items = new List<Side>();
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
        public List<Drink> AvailableDrinks
        {
            get
            {
                JurassicJava jurassicJava = new JurassicJava();
                Sodasaurus sodasaurus = new Sodasaurus();
                Tyrannotea tyrannotea = new Tyrannotea();
                Water water = new Water();
                List<Drink> items = new List<Drink>();
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
        public List<CretaceousCombo> AvailableCombos
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
                List<CretaceousCombo> items = new List<CretaceousCombo>();
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
