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

    protected string memory;
    public HardDrive(){
        name="Harddrive";
        price=100;
    }
    //-------------------------------------------SetHardDrive----------------------------------------------------------
    void SetMemory(int _memory){
        memory=_memory+"GB";
    }
    //-------------------------------------------GetHardDrive----------------------------------------------------------
    string GetMemory(){
        return memory;
    }
}

public class Processor:Hardware{
    protected int cores;
    protected int clockSpeed;
    public Processor(){
        name="Processor";
        price=200;
    }
    //-------------------------------------------SetProcessor----------------------------------------------------------
    void SetCores(int _cores){
        cores=_cores;
    }
    void SetClockSpeed(int _clockSpeed){
        clockSpeed=_clockSpeed;
    }
    //-------------------------------------------GetProcessor----------------------------------------------------------
    int GetCores(){
        return cores;
    }
    int GetClockSpeed(){
        return clockSpeed;
    }
}

public class GraphicCard:Hardware{
    protected int resolution;
    protected int memory;

    public GraphicCard(){
        name="Graphic Card";
        price=300;
    }
    //-------------------------------------------SetGraphicCard--------------------------------------------------------
    void SetMemory(int _memory){
        memory=_memory;
    }
    void SetResolution(int _resolution){
        resolution=_resolution;
    }
    //-------------------------------------------GetGraphicCard--------------------------------------------------------
    int GetMemory(){
        return memory;
    }
    int GetResolution(){
        return resolution;
    }
}