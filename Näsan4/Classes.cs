using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Hardware{
    protected string _name;
    protected int _price;
    public Hardware(){
        _price=0;
        _name="";

    }
    int GetPrice(){
        return _price;
    }

    string GetName(){
        return _name;
    }
}

public class HardDrive:Hardware{

    protected string memory;
    public HardDrive(){
        _name="Harddrive";
        _price=100;
        void SetMemory(int mem){
            memory=mem+"GB";
        }
    }
    string GetMemory(){
        return memory;
    }
}

public class Processor:Hardware{
    protected int cores;
    public Processor(){
        _name="Processor";
        _price=200;

        void SetCores(int amountOfCores){
            cores=amountOfCores;
        }
    }
    int GetCores(){
        return cores;
    }
}