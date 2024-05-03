


List<string> videoGameNames = new List<string>() { "GrayZone Warfare", "Call Of Duty", "Forza" };

videoGameNames.Add("MineCraft");
videoGameNames.Add("Hell Let Loose");


var orderedGames = videoGameNames.OrderByDescending(name  => name.Length);

foreach (var gameName in orderedGames) 
{ 
   Console.WriteLine(gameName);
}