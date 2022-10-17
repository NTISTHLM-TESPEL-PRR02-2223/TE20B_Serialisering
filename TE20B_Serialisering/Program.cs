using System.IO;
using System.Text.Json;

string whinnyText = File.ReadAllText("whinny.txt");


Horse whinny = JsonSerializer.Deserialize<Horse>(whinnyText);

Console.WriteLine(whinny.Speed);

// Horse whinny = new Horse();

// whinny.Color = "Rainbow";
// whinny.Scale = 200;
// whinny.Speed = 3;

// string whinnyText = JsonSerializer.Serialize<Horse>(whinny);

// File.WriteAllText("whinny.txt", whinnyText);


Console.ReadLine();
