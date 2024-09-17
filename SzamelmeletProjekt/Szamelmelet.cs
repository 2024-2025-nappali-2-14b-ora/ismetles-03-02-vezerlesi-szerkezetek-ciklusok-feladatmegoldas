
namespace SzamelmeletProjekt
{
    // Statikus osztályok - kódjuk egyszer szerepel a memóriába
    public static class Szamelmelet
    {
        // Statikus osztályban statikus metódusokat lehet készíteni
        public static List<int> GetOsztok(int szam)
        {
            // Pl. 6 osztói 1,2,3,
            List<int> osztok = new List<int>();
            osztok.Add(szam);
            osztok.Add(1);

            return osztok;
        }
    }
}
