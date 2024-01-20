using Packt.Shared;
using static System.Console;

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

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
WriteLine(format: "{0} was born on {1:dddd, dd MMM yy}", arg0: alice.Name, arg1: alice.DateOfBirth);
