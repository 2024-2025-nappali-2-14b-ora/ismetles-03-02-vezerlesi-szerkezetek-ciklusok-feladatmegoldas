
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
            return 0;
        }

        public static bool TokeletesE(int szam)
        {
            return false;
        }

        public static int GetOsztokSzama(int szam)
        { return 0; }

        public static bool PrimszamE(int szam)
        {
            return false;
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
            return new List<int>();
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
