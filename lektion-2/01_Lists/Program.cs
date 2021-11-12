// JS    const customers = []
// C#    string[] customers = string[5];                 (detta är en array och det är inte lika med en lista)
// C#    List<string> customers = new List<string>();    (detta är en lista)

/*
    List<string> names = new List<string>();
    List<int> numbers = new List<int>();
    List<Customer> customers = new List<Customer>();
    List<dynamic> something = new List<dynamic>();

    Med en lista:
    ----------------------------------------------------------------------------------------------------------------------
    List<int> numbers = new List<int>();          gör jag inte så här så får jag FELMEDDELANDE: not set to an instance of an object
    numbers = await Http.GetFromJsonAsync<List<int>>("https://webapiurl.com/api/numbers");
   

    Med en array:
    ----------------------------------------------------------------------------------------------------------------------
    int[] numbers;
    numbers = await Http.GetFromJsonAsync<int[]>("https://webapiurl.com/api/numbers");

*/


/* ADD */
var names = new List<string>()
{
    "Hans",
    "Anki"
};

names.Add("Tommy");
names.Add("Stefan");


/* ADD-RANGE */
string[] staff = { "Joakim", "Haithem", "Nina", "Alicja", "Anki" };
names.AddRange(staff);


/* INSERT */
names.Insert(3, "Boboo");


/* INSERT-RANGE */
string[] customers = { "EC Utbildning", "Nackademin", "Lexicon", "KYH" };
names.InsertRange(5, customers);


/* SORT LIST */
names.Reverse();
names.Sort();


/* REMOVE FROM LIST */
names.Remove("Anki");
names.RemoveAt(5);
names.RemoveRange(4, 6);
//names.Clear();


/* FILTER WITH LINQ */
names = names.Where(name => name != "Anki").ToList();


/* READ LIST */
foreach (var name in names)
    Console.WriteLine(name);


/* INDEX OF */
var index = names.IndexOf("Tommy");
Console.WriteLine(index);


/* SPLIT */
var fullName = "Hans Mattin-Lassei";
var parts = fullName.Split(" ");

foreach (var name in parts)
    Console.WriteLine(name);
