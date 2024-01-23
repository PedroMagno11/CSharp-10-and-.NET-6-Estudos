using Packt.Shared;
using PacktLibrary;
using static System.Console;

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

//Em resumo, o comando a ser executado faz o mesmo que o comando anterior, mas assim fica mais difícil de ler.
//        HangingGardensOfBabylon = 0b_0000_0010 // i.e. 2
//        MausoleumAtHalicarnassus = 0b_0001_0000 // i.e. 16
//O número 18 é convertido para o tipo enum (Soma do 2 + 16)
//Comando a ser executado:
//bob.BucketList = (WondersOfTheAncientWorld)18;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new Person() { Name = "Alfred" });
bob.Children.Add(new Person() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");

for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"    {bob.Children[childIndex].Name}");
}

// using foreach
//foreach(Person child in bob.Children)
//{
//    WriteLine($"    {child.Name}");
//}

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new DateTime(1998, 3, 7)
};


WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}", arg0: bob.Name, arg1: bob.DateOfBirth);
WriteLine(format: "{0}'s favorite wonder is {1}. Its intenger is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2:(int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
WriteLine(format: "{0} was born on {1:dddd, dd MMM yy}", arg0: alice.Name, arg1: alice.DateOfBirth);


BankAccount.InterestRate = 0.012M; //store a shared value

BankAccount jonesAccount = new BankAccount();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new BankAccount();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

Person blankPerson = new();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new Person(initialName: "Gunny", homePlanet: "Mars");

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetFruit2();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");


var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetFruit();
(string fruitName2, int fruitNumber2) = bob.GetFruit2();

WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");
WriteLine($"Deconstructed 2: {fruitName2}, {fruitNumber2}");


// Deconstructing a Person

var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");


WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emilly"));
WriteLine(bob.OptionalParameters());
WriteLine(bob.OptionalParameters(command: "Jump!",number: 98.5));
WriteLine(bob.OptionalParameters("Hide!",52.7));
WriteLine(bob.OptionalParameters("Poke!", active:false));

int a = 10;
int b = 20;
int c = 30;

WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

int d = 10;
int e = 20;

WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
// simplified C#7.0 or Later syntax for the out parameter
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1972, 1, 27)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

sam.Children.Add(new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });

WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

