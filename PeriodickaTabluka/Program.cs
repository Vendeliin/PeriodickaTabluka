using System;
using System.Collections.Generic;
using System.Linq;

namespace periodickatabulka
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Zadej značku prvku, nebo nazev v češtině, anlgličtině, latine. Pro porcvičování napiš 1. Pro zavření programu napiš exit.");
            while (program.Znacka())
            {
                Console.WriteLine("Zadej značku prvku, nebo nazev v češtině, anlgličtině, latine. Pro porcvičování napiš 1. Pro zavření programu napiš exit.");
                program.Znacka();
            }
        }

        public bool Znacka()
        {
            var input = Console.ReadLine();

            Random rnd = new Random();
            int ran_num = rnd.Next(0, 87);

            var prvky = new Dictionary<string, string>(){
                {"H", "Vodík, Hydrogen, Hydrogenium"},
                {"He", "Helium, Helium, Helium"},
                {"Li", "Lithium, Lithium, Lithium"},
                {"Be", "Beryllium, Beryllium, Beryllium"},
                {"B", "Bor, Boron, Borium"},
                {"C", "Uhlík, Carbon, Carbonium"},
                {"N", "Dusík, Nitrogen, Nitrogenium"},
                {"O", "Kyslík, Oxygen, Oxygenium"},
                {"F", "Fluor, Fluorine, Fluorum"},
                {"Ne", "Neon, Neon, Neon"},
                {"Na", "Sodík, Sodium, Natrium"},
                {"Mg", "Hořčík, Magnesium, Magnesium"},
                {"Al", "Hliník, Aluminium, Aluminium"},
                {"Si", "Křemík, Silicon, Silicium"},
                {"P", "Fosfor, Phosphorus, Phosphorus"},
                {"S", "Síra, Sulfur, Sulphur"},
                {"Cl", "Chlor, Chlorine, Chlorum"},
                {"Ar", "Argon, Argon, Argon"},
                {"K", "Draslík, Potassium, Kalium"},
                {"Ca", "Vápník, Calcium, Calcium"},
                {"Sc", "Skandium, Scandium, Scandium"},
                {"Ti", "Titan, Titanium, Titanium"},
                {"V", "Vanad, Vanadium, Vanadium"},
                {"Cr", "Chrom, Chromium, Chromium"},
                {"Mn", "Mangan, Manganese, Manganum"},
                {"Fe", "Železo, Iron, Ferrum"},
                {"Co", "Kobalt, Cobalt, Cobaltum"},
                {"Ni", "Nikl, Nickel, Niccolum"},
                {"Cu", "Měď, Copper, Cuprum"},
                {"Zn", "Zinek, Zinc, Zincum"},
                {"Ga", "Gallium, Gallium, Gallium"},
                {"Ge", "Germanium, Germanium, Germanium"},
                {"As", "Arsen, Arsenic, Arsenicum"},
                {"Se", "Selen, Selenium, Selenium"},
                {"Br", "Brom, Bromine, Bromium"},
                {"Kr", "Krypton, Krypton, Krypton"},
                {"Rb", "Rubidium, Rubidium, Rubidium"},
                {"Sr", "Stroncium, Strontium, Strontium"},
                {"Y", "Yttrium, Yttrium, Yttrium"},
                {"Zr", "Zirkonium, Zirconium, Zirconium"},
                {"Nb", "Niob, Niobium, Niobium"},
                {"Mo", "Molybden, Molybdenum, Molybdenum"},
                {"Tc", "Technecium, Technetium, Technetium"},
                {"Ru", "Ruthenium, Ruthenium, Ruthenium"},
                {"Rh", "Rhodium, Rhodium, Rhodium"},
                {"Pd", "Palladium, Palladium, Palladium"},
                {"Ag", "Stříbro, Silver, Argentum"},
                {"Cd", "Kadmium, Cadmium, Cadmium"},
                {"In", "Indium, Indium, Indium"},
                {"Sn", "Cín, Tin, Stannum"},
                {"Sb", "Antimon, Antimony, Stibium"},
                {"Te", "Tellur, Tellurium, Tellurium"},
                {"I", "Jod, Iodine, Iodum"},
                {"Xe", "Xenon, Xenon, Xenon"},
                {"Cs", "Cesium, Caesium, Caesium"},
                {"Ba", "Baryum, Barium, Barium"},
                {"Hf", "Hafnium, Hafnium, Hafnium"},
                {"Ta", "Tantal, Tantalum, Tantalum"},
                {"W", "Wolfram, Tungsten, Wolframium"},
                {"Re", "Rhenium, Rhenium, Rhenium"},
                {"Os", "Osmium, Osmium, Osmium"},
                {"Ir", "Iridium, Iridium, Iridium"},
                {"Pt", "Platina, Platinum, Platinum"},
                {"Au", "Zlato, Gold, Aurum"},
                {"Hg", "Rtuť, Mercury, Hydrargyrum"},
                {"Tl", "Thallium, Thallium, Thallium"},
                {"Pb", "Olovo, Lead, Plumbum"},
                {"Bi", "Bismut, Bismuth, Bisemutum"},
                {"Po", "Polonium, Polonium, Polonium"},
                {"At", "Astat, Astatine, Astatium"},
                {"Rn", "Radon, Radon, Radon"},
                {"Fr", "Francium, Francium, Francium"},
                {"Ra", "Radium, Radium, Radium"},
                {"Rf", "Rutherfordium, Rutherfordium, Rutherfordium"},
                {"Db", "Dubnium, Dubnium, Dubnium"},
                {"Sg", "Seaborgium, Seaborgium, Seaborgium"},
                {"Bh", "Bohrium, Bohrium, Bohrium"},
                {"Hs", "Hassium, Hassium, Hassium"},
                {"Mt", "Meitnerium, Meitnerium, Meitnerium"},
                {"Ds", "Darmstadtium, Darmstadtium, Darmstadtium"},
                {"Rg", "Roentgenium, Roentgenium, Roentgenium"},
                {"Cn", "Kopernicium, Copernicium, Copernicium"},
                {"Nh", "Nihonium, Nihonium, Nihonium"},
                {"Fl", "Flerovium, Flerovium, Flerovium"},
                {"Mc", "Moscovium, Moscovium, Moscovium"},
                {"Lv", "Livermorium, Livermorium, Livermorium"},
                {"Ts", "Tennessin, Tennessine, Tennessine"},
                {"Og", "Oganesson, Oganesson, Oganesson"}
            };
            string key = "";
            foreach (var pair in prvky)
            {
                if (pair.Value == input)
                {
                    key = pair.Key;
                }
            }
            if (prvky.ContainsKey(input))
            {
                Console.WriteLine(prvky[input]);
                return true;
            }
            else if (prvky.ContainsValue(input))
            {
                Console.WriteLine(key);
                return true;
            }
            else if (input == "1")
            {
                Console.WriteLine(prvky.ElementAt(ran_num).Value);
                Console.WriteLine("Napiš značku prvku: ");
                var input1 = Console.ReadLine();
                if (input1 == prvky.ElementAt(ran_num).Key)
                {
                    Console.WriteLine("Správně.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Špatně, bylo to " + prvky.ElementAt(ran_num).Key);
                    return true;
                }
            }
            if (input == "exit")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Název neexistuje, nebo jsi ho napsal špatně.");
                return true;
            }
        }
    }
}
