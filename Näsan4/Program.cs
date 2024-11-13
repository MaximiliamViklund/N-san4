using System.Security.Cryptography.X509Certificates;

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
Console.WriteLine("What would you like to call your "+create+"?");
string name=Console.ReadLine();
while(creating){
    Console.WriteLine("How much would you your "+create+" to cost?");
    Console.WriteLine("Please only enter a number");
    string stringPrice=Console.ReadLine();

    bool works=int.TryParse(stringPrice, out int price);
    if(works){
        switch(create){
            case "Hard Drive":
                HardDrive NewH=new HardDrive(name,price);
            break;
            case "Processor":
                Processor NewP=new Processor(name,price);
            break;
            case "Graphics Card":
                GraphicCard NewG=new GraphicCard(name,price);
            break;
        }
    }
    else{
        Console.WriteLine("Please only enter a number for the price");
        Console.ReadLine();
    }
}
