// See https://aka.ms/new-console-template for more information
using SzamelmeletProjekt;

Console.WriteLine("Hello, World!");
List<int> osztok = Szamelmelet.GetOsztok(6);

foreach (int oszto in osztok)
    Console.Write($"{oszto}, ");
