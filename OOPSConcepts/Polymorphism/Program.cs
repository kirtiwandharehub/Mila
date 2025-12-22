// Static/Early/Compile-Time polymorphism
using System.Data.Common;
using OOPSConcepts.Polymorphism;

Console.WriteLine("------------Static Polymorphism/Static Binding/CompileTime Binding------------");
Animal pet = new Animal() { Name = "Oscar" };
pet.Walk();
pet.Walk(Speed.Slow);

Console.WriteLine("------------Dynamic Polymorphism/Late Binding/RunTime Binding------------");
pet.WhoAmI();
Animal cat = new Cat() { Name = "Paula" };
cat.Walk();
cat.Walk(Speed.Slow);
cat.WhoAmI();
