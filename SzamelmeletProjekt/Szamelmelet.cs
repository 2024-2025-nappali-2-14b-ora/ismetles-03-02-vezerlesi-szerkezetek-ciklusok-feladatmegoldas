
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

                for (int i = 2; i < (szam / 2); i = i + 1)
                    if (szam % i == 0)
                        osztok.Add(i);
            }
            return osztok.ToList();
        }
    }
}
