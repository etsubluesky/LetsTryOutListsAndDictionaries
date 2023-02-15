using LetsTryOutListsAndDictionaries;
//using System.Linq;

List<string> names = new List<string>();
names.Add("Matt");
names.Add("Matt");
names.Add("Matt");
names.Add("Matt");
names.Add("Matt");

List<int> numbers = new List<int>(100);

Console.WriteLine(names.Capacity);
Console.WriteLine(numbers.Capacity);



List<State> states = new List<State>(50);

var state = new State();
state.Id = 2;
state.Name = "Connecticut";
state.Abbreviation = "CT";
state.URLToFlagPicture = " https://www.nationsonline.org/gallery/USA/CoA/Connecticut-Flag-226x136.jpg";

states.Add(state);

state = new State();
state.Id = 3;
state.Name = "Georgia";
state.Abbreviation = "GA";
state.URLToFlagPicture = " https://www.nationsonline.org/gallery/USA/CoA/Georgia-Flag-226x141.jpg";

states.Add(state);

states.Add(new State { Id = 1, Abbreviation = "TN", Name = "Tennessee", URLToFlagPicture = "https://www.nationsonline.org/gallery/USA/CoA/Tennessee-Flag-226x136.jpg" });

//var refState = states[2];

//Console.WriteLine(states.Count);

//Console.WriteLine(states.Contains( refState));

//refState = states.Find(s => s.Name == "Tennessee");
foreach (var item in states)
{
	Console.WriteLine(item.Name);
}

var chunks = states.Chunk(1);

Console.WriteLine(chunks.Count());

foreach (var items in chunks)
{
	foreach (var item in items)
	{
		Console.WriteLine(item.Name);
	}

	//states.
	//	Console.WriteLine("End chunk");
}
//Console.WriteLine(states.Contains(refState));
//Console.WriteLine(states.Contains(states.Where(s => s.Name == "Tennessee").First()));
