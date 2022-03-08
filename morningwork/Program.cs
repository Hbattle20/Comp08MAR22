// See https://aka.ms/new-console-template for more information
using morningwork;

//Car honda = new Car(6, "green");

////honda.Wheels = 6;

//Console.WriteLine(honda.Wheels);

//Bike hotwheels = new Bike();
//hotwheels.MoveVechicle(6);
//hotwheels.Show();


Tires fordsTires = new Tires(4, 10);

Engine fordsengine = new Engine((int) EngineType.Gas, 6 );

Car ford = new Car(fordsTires, fordsengine);

Console.WriteLine(ford.Engine._engineType);


