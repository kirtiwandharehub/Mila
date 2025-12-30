IFile fileHasAccess = new ProxyFile("Menu.txt", true);
fileHasAccess.Read();
fileHasAccess.Read();

Console.WriteLine("-------------------------");

IFile fileNoAccess = new ProxyFile("Cities.txt", false);
fileNoAccess.Read();