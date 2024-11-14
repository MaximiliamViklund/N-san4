using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

List<Hardware> HardwareList=new();
bool start=true;
string create="";

while(start){
    Console.WriteLine("What type of hardware would you like to create?");
    Console.WriteLine("1) Hard Drive");
    Console.WriteLine("2) Processor");
    Console.WriteLine("3) Graphics Card");
    string type=Console.ReadLine().ToLower();

    switch(type){
        case "1":
            create="Hard Drive";
            start=false;
        break;
        case "2":
            create="Processor";
            start=false;
        break;
        case "3":
            create="Graphics Card";
            start=false;
        break;
        default:
            Console.WriteLine("Not a valid answer, restart and try again");
            Console.ReadLine();
        break;
    }
}

bool creating=true;
Console.Clear();
Console.WriteLine("What would you like to call your "+create+"?");
string name=Console.ReadLine();
while(creating){
    Console.Clear();
    Console.WriteLine("How much would you like your "+create+" to cost?");
    Console.WriteLine("Please only enter a number");
    string stringPrice=Console.ReadLine();

    bool works=int.TryParse(stringPrice, out int price);
    if(works){
        switch(create){
            case "Hard Drive":
                HardDrive NewH=new HardDrive(name,price);
                HardwareList.Add(NewH);
                creating=false;
            break;
            case "Processor":
                Processor NewP=new Processor(name,price);
                HardwareList.Add(NewP);
                creating=false;
            break;
            case "Graphics Card":
                GraphicCard NewG=new GraphicCard(name,price);
                HardwareList.Add(NewG);
                creating=false;
            break;
        }
    }
    else{
        Console.WriteLine("Not a valid answer");
    }
}

string resp="";
bool check;
bool anotherFuckingLoop=true;
if(HardwareList[0] is HardDrive h){
    while(anotherFuckingLoop){
        Console.Clear();
        Console.WriteLine("How much memory would you like for your Hard Drive to have?");
        Console.WriteLine("Please enter a number");
        resp=Console.ReadLine();

        check=int.TryParse(resp, out int memory);
        if(check){
            h.SetMemory(memory);
            Console.Clear();
            h.Display();
            anotherFuckingLoop=false;
        }
        else{
            Console.WriteLine("Not a valid answer, please only input a number");
        }
    }
}
else if(HardwareList[0] is Processor p){
    while(anotherFuckingLoop){
        Console.Clear();
        Console.WriteLine("How many cores would you like for your Processor to have?");
        Console.WriteLine("Please enter a number");
        resp=Console.ReadLine();

        check=int.TryParse(resp, out int cores);
        if(check){
            p.SetCores(cores);
            check=false;

            bool anotherAnotherFuckingLoop=true;
            while(anotherAnotherFuckingLoop){
                Console.Clear();
                Console.WriteLine("How fast clock speed would you like your Processor to have?");
                Console.WriteLine("Please enter a number");
                resp=Console.ReadLine();

                check=int.TryParse(resp, out int clockSpeed);
                if(check){
                    p.SetClockSpeed(clockSpeed);
                    Console.Clear();
                    p.Display();
                    anotherAnotherFuckingLoop=false;
                }
                else{
                    Console.WriteLine("Not a valid answer, please only input a number");

                }

            }
            anotherFuckingLoop=false;
        }
        else{
            Console.WriteLine("Not a valid answer, please only input a number");
        }
    }

}
else if(HardwareList[0] is GraphicCard g){
    while(anotherFuckingLoop){
        Console.Clear();
        Console.WriteLine("How much memory would you like for your Graphic Card to have?");
        Console.WriteLine("Please enter a number");
        resp=Console.ReadLine();

        check=int.TryParse(resp, out int memory);
        if(check){
            g.SetMemory(memory);
            check=false;

            bool anotherAnotherFuckingLoop=true;
            while(anotherAnotherFuckingLoop){
                Console.Clear();
                Console.WriteLine("How high resolution would you like your Graphics Card to have?");
                Console.WriteLine("Please enter a number");
                resp=Console.ReadLine();

                check=int.TryParse(resp, out int resolution);
                if(check){
                    g.SetResolution(resolution);
                    Console.Clear();
                    g.Display();
                    anotherAnotherFuckingLoop=false;
                }
                else{
                    Console.WriteLine("Not a valid answer, please only input a number");

                }

            }
            anotherFuckingLoop=false;
        }
        else{
            Console.WriteLine("Not a valid answer, please only input a number");
        }
    }
    
}