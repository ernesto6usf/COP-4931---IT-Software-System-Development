//// COP 4931 - IT Software Systems Development
// Instructor - James Anderson
// Student - Ernesto Diaz
// Assignment - AHPA 10: The Car Problem

/* The Zipper class will have two interfaces: ZoomMode and QuickBreaking. 
ZoomModewill have a method startToStop which will display "going fast" 
and QuickBreaking which will display "stopping".*/


Zipper zipper = new Zipper();
Touring touring = new Touring();

Console.WriteLine("Zipper has " + zipper.numberOfTires + " tires and an " + zipper.engineSize + " cylinder engine.");
Console.WriteLine("Touring has " + touring.numberOfTires + " tires and an " + touring.engineSize + " cylinder engine.");
zipper.EngageZoomMode();
zipper.StartToStop();
touring.EngageFuelEconomy();


public interface IZoomMode
{
    public void EngageZoomMode();
}

public interface IQuickBreaking
{
    public void StartToStop();
}

public interface IFuelEconomy
{
    public void EngageFuelEconomy();
}

public class Car
{
    public int numberOfTires = 4;
    public int engineSize = 8;
}

public class Zipper :Car, IZoomMode, IQuickBreaking
{
    public void StartToStop()
    {
        Console.WriteLine("Stopping");
    }

    public void EngageZoomMode()
    {
        Console.WriteLine("Going fast.");
    }
}

public class Touring : Car, IFuelEconomy 
{
    public void EngageFuelEconomy()
    {
        Console.WriteLine("Fuel economy mode engaged.");
    }
}