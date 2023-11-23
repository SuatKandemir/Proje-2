using Newpratict;
using System.Diagnostics.Metrics;
using System.Reflection;

Car car1 = new Car()
{
    Brand = " Mercedes",
    Model = " SPLus",
    Year = 2023,
    Fuel = 30
};

Car car2 = new Car()
{
    Brand = " Ford",
    Model = " Focus",
    Year = 2023,
    Fuel = 15,

};

Rentalservice rentalservice = new Rentalservice();
rentalservice.CarRental(car1);
Thread.Sleep(2000);
Console.Clear();

Rentalservice rentalservice1 = new Rentalservice();
rentalservice1.CarRental(car2);
Thread.Sleep(2000);

RenterHuman renterhuman = new RenterHuman();
renterhuman.Hire(car1);
Thread.Sleep(2000);

RenterHuman renterhuman2 = new RenterHuman();
renterhuman2.Hr(car2);
Thread.Sleep(2000);



Console.WriteLine(" Car 1 about and renter Suat Kandemir");
Console.WriteLine(car1.Brand + " : " + car1.Model + " : "  + car1.Fuel + " : " + car1.Year);

Console.WriteLine(" Car 2 about and renter Yavuz Yazıcı");
Console.WriteLine(car2.Brand + " : " + car2.Model + " : " + car2.Fuel + " : " + car2.Year);



//car2.Addfuel();
//Console.WriteLine("Add fueling");
//Console.WriteLine(car2.Brand + ": " + car2.Fuel);

//car1.Addfuel();
//Console.WriteLine("Add fueling");
//Console.WriteLine(car1.Brand+ ": " + car1.Fuel);
//car2.Drive();
//Console.WriteLine("Car is driving : 2");

//Console.WriteLine(car2.Brand + ": " + car2.Fuel);

//car2.Addfuel();
//Console.WriteLine("Add fueling car : 2");
//Console.WriteLine(car2.Brand + ": " + car2.Fuel);
//car1.Drive();
//Console.WriteLine("Car is driving");
//Console.WriteLine(car1.Brand + ": " + car1.Fuel);

//car2.Drive();
//Console.WriteLine("Car is driving");

//Console.WriteLine(car2.Brand + ": " + car2.Fuel);




