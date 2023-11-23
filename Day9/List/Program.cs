using Dumper;
class Program
{
	static void Main()
	{
		List<int> myInt = new();
			myInt.Add(3);
			myInt.Add(4);
			myInt.Add(5);

			int result = myInt[0];
			// Console.WriteLine(result);

			List<int> myInt2 = new() {1,2,3,4,5};
			myInt2.Add(6);
			Console.WriteLine(myInt2[5]);
			
			List<Player> players = new()
			{
				new Player(1, "Kinara"),
				new Player(2, "Yusuf"),
				new Player(3, "tanto")
			};
			
			// Access and print a player by Id
			int playerIdToFind = 1;
			Player playerById = players.FirstOrDefault(player => player.Id == playerIdToFind);
			if (playerById != null)
			{
				Console.WriteLine($"Player with Id {playerIdToFind}: {playerById.Name}");
			}
			else
			{
				Console.WriteLine($"Player with Id {playerIdToFind} not found");
			}

			// Access and print a player by Name
			string playerNameToFind = "Yusuf";
			Player playerByName = players.FirstOrDefault(player => player.Name == playerNameToFind);
			if (playerByName != null)
			{
				Console.WriteLine($"Player with Name {playerNameToFind}: {playerByName.Id}");
			}
			else
			{
				Console.WriteLine($"Player with Name {playerNameToFind} not found");
			}
				
			players.ElementAt(0).Id.Dump(); // access directly ID using ElementAt
			players.ElementAt(2).Name.Dump(); // access directly Name using ElementAt
	}
}

// You can define other methods, fields, classes and namespaces here
class Player 
{
	public int Id { get; }
	public string Name { get; }
	public Player(int id,string name) 
	{
		Id = id;
		Name = name;	
	}
}