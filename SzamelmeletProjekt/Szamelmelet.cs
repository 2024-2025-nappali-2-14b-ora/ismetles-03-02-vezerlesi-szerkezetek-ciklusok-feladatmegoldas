
namespace SzamelmeletProjekt
{
    // Statikus osztályok - kódjuk egyszer szerepel a memóriába
    public static class Szamelmelet
    {
        // Statikus osztályban statikus metódusokat lehet készíteni
        public static List<int> GetOsztok(int szam)
        {
            // Pl. 6 osztói 1,2,3,
            HashSet<int> osztok = new HashSet<int>();
            if (szam != 0)
            {
                osztok.Add(szam);
                osztok.Add(1);

                if (szam < 0)
                    szam = Math.Abs(szam);

                for (int i = 2; i <= (szam / 2); i = i + 1)
                    if (szam % i == 0)
                        osztok.Add(i);
            }
            return osztok.OrderBy(szam => szam).ToList();
        }
        public static int GetOsztokOsszege(int szam)
        {
            //List<int> osztok = GetOsztok(szam);
            /*
            int osszeg = 0;
            foreach (int oszto in osztok)
                osszeg = osszeg + oszto;
            return osszeg;
            */

            return GetOsztok(szam).Sum();
        }

        public static bool TokeletesE(int szam)
        {
            return false;
        }

        public static int GetOsztokSzama(int szam)
        { return 0; }

        public static bool PrimszamE(int szam)
        {
            /*
            List<int> osztok = GetOsztok(szam);
            if (osztok.Count == 2)
                return true;
            else
                return false;
            */
            //return GetOsztok(szam).Count == 2 ? true : false;
            return GetOsztok(szam).Count == 2;
        }

        public static void KiirLista(List<int> list)
        {
        }

        public static List<int> GetPrimek(int veg)
        {
            return new List<int>();
        }

        public static List<int> GetPrimek(int kezdet, int veg)
        {
            List<int> primek = new List<int>();
            for (int i = kezdet; i<= veg; i++)
            {
                if (PrimszamE(i))
                    primek.Append(i);
            }
            return primek;
        }

        public static List<int> GetTokeletesek(int veg)
        { 
            return new List<int>();
        }

        public static List<int> GetTokeletesek(int kezdet, int veg) 
        { 
            return new List<int>(); 
        }


    }
}
