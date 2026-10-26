// dotnet new sln --format sln -n Week2Exercise
// dotnet new console -n Foobarjazz 
// dotnet sln Week2Exercise.sln add Foobarjazz/Foobarjazz.csproj

using Foobar;
Fooba fooba = new Fooba();

fooba.AddRule(3, "fuh");
fooba.AddRule(4, "ciluk");
fooba.AddRule(5, "baa");
fooba.AddRule(7, "yass");
fooba.AddRule(9, "shush");


fooba.Evaluate(100);
fooba.GenerateSequence(1,100);