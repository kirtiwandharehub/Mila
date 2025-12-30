DirectoryItem vacations = new DirectoryItem("Vacations");

DirectoryItem year2024 = new DirectoryItem("Year2024");
FileItem seattle = new FileItem("SeattleMemories.doc");
year2024.Add(seattle);

DirectoryItem year2025 = new DirectoryItem("Year2025");
FileItem newYork = new FileItem("NewYorkMemories.doc");
year2025.Add(newYork);

vacations.Add(year2024);
vacations.Add(year2025);

vacations.Display(0);

year2025.Remove(newYork);

Console.WriteLine("-----------------------------------");
vacations.Display(0);
