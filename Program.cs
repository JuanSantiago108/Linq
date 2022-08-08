List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano"),
    new Eruption("Zebra", 2500, "Iceland", 2000, "Stratovolcano"),
    new Eruption("Zel", 3000, "New York", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// // Execute Assignment Tasks here!

// // 1.
IEnumerable<Eruption> chileEruptions = eruptions.Where(c => c.Volcano == "Kilauea");
// PrintEach(chileEruptions, "Kilauea eruptions.");

Eruption? firstHawaiian = eruptions.FirstOrDefault(w => w.Location == "Hawaiian Is");

// if(firstHawaiian != null)
// {
//     Console.WriteLine(firstHawaiian);
// } 
// else
// {
//     Console.WriteLine("No Hawaiian Is Eruption found");
// }

Eruption? yearEruptions = eruptions.FirstOrDefault(e => e.Year > 1900 && e.Location == "New Zealand");

// Console.WriteLine(yearEruptions);

IEnumerable<Eruption> allErup2000 = eruptions.Where(e => e.ElevationInMeters > 2000);
// PrintEach(allErup2000);

IEnumerable<Eruption> allZV = eruptions.Where(e => e.Volcano.StartsWith("Z")).ToList();
// PrintEach(allZV,$"Heres the count of all volcanos that start with Z:  {allZV.Count()} ");


Eruption? maxErup = eruptions.FirstOrDefault(e => e.ElevationInMeters == eruptions.Max(e => e.ElevationInMeters));
// if (maxErup != null)
// {
//     Console.WriteLine(maxErup.ElevationInMeters);
// }

List<Eruption> allAlpha = eruptions.OrderBy(e => e.Volcano).ToList();
// foreach (Eruption eruption in allAlpha)
// {
//     Console.WriteLine(eruption.Volcano);
// };

List<Eruption> eralyAlpha = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).ToList();

PrintEach(eralyAlpha);
foreach (Eruption eruption in eralyAlpha)
{
    Console.WriteLine(eruption);
    
}
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
