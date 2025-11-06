using PracticeTask;
using InterviewTask;
using CarManufacture;
using CarManufacture.Brand;
using BalockExercise;

Task1.Run();
InterviewQuestion.Run();

Toyota lgx = new Toyota("V4", 200, 1998, "Red", 84_000_000);
lgx.Turbo();
lgx.ShowInfo();

Wuling airev = new Wuling("V3", 120, 2023, "White", 300_000_000);
airev.Hybrid();
airev.ShowInfo();

lgx.MakeToyota();
Console.WriteLine("Total Car on showroom " + Car.TotalCar);

BalockTask.Run();