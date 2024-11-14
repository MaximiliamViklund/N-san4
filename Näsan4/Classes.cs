using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Hardware{
    protected string name;
    protected int price;
    public Hardware(){
        price=0;
        name="";

    }
    int GetPrice(){
        return price;
    }

    string GetName(){
        return name;
    }
}

public class HardDrive:Hardware{

    protected int memory;
    public HardDrive(string _name, int _price){
        name=_name;
        price=_price;
    }
    //-------------------------------------------SetHardDrive----------------------------------------------------------
    public void SetMemory(int _memory){
        memory=_memory;
    }
    //-------------------------------------------GetHardDrive----------------------------------------------------------
    int GetMemory(){
        return memory;
    }
    //----------------------------------------------Display------------------------------------------------------------
    public void Display(){
        Console.WriteLine(name);
        Console.WriteLine("Price: "+price+"kr");
        Console.WriteLine("Memory: "+memory+"GB");
        Console.ReadLine();
    }
}

public class Processor:Hardware{
    protected int cores;
    protected int clockSpeed;
    public Processor(string _name, int _price){
        name=_name;
        price=_price;
    }
    //-------------------------------------------SetProcessor----------------------------------------------------------
    public void SetCores(int _cores){
        cores=_cores;
    }
    public void SetClockSpeed(int _clockSpeed){
        clockSpeed=_clockSpeed;
    }
    //-------------------------------------------GetProcessor----------------------------------------------------------
    int GetCores(){
        return cores;
    }
    int GetClockSpeed(){
        return clockSpeed;
    }
    //----------------------------------------------Display------------------------------------------------------------
    public void Display(){
        Console.WriteLine(name);
        Console.WriteLine("Price: "+price+"kr");
        Console.WriteLine("Number of cores: "+cores);
        Console.WriteLine("Clock Speed: "+clockSpeed);
        Console.ReadLine();
    }
}

public class GraphicCard:Hardware{
    protected int resolution;
    protected int memory;

    public GraphicCard(string _name, int _price){
        name=_name;
        price=_price;
    }
    //-------------------------------------------SetGraphicCard--------------------------------------------------------
    public void SetMemory(int _memory){
        memory=_memory;
    }
    public void SetResolution(int _resolution){
        resolution=_resolution;
    }
    //-------------------------------------------GetGraphicCard--------------------------------------------------------
    int GetMemory(){
        return memory;
    }
    int GetResolution(){
        return resolution;
    }
    //----------------------------------------------Display------------------------------------------------------------
    public void Display(){
        Console.WriteLine(name);
        Console.WriteLine("Price: "+price+"kr");
        Console.WriteLine("Memory: "+memory+"GB");
        Console.WriteLine("Resolution: "+resolution+"p");
        Console.ReadLine();
    }
}