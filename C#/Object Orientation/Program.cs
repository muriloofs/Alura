using bytebank_ADM.Employees;
using bytebank_ADM.InternalSystem;
using bytebank_ADM.Utility;

#region
//Employee murilo = new Employee("781.219.777-43");
//murilo.Name = "Murilo Faria";

//Console.WriteLine(murilo.Name);
//Console.WriteLine(murilo.GetBonus());

//Director nicole = new Director("187.213.981-18");
//nicole.Name = "Nicole Carazzo";

//Console.WriteLine(nicole.Name);
//Console.WriteLine(nicole.GetBonus());

//BonusManager manager = new BonusManager();
//manager.Register(murilo);
//manager.Register(nicole);

//Console.WriteLine("Total bonus: " + manager.TotalBonus);
//Console.WriteLine("Total employees: " + Employee.TotalEmployees);

//murilo.RaiseSalary();
//nicole.RaiseSalary();

//Console.WriteLine("New salary of Murilo: " + murilo.Salary);
//Console.WriteLine("New salary of Nicole: " + nicole.Salary);
#endregion

//CalculateBonus();
UsingSystem();
void CalculateBonus()
{
    BonusManager manager = new BonusManager();

    Designer otavio = new Designer("XXX.XXX.XXX-XX");
    otavio.Name = "Otávio Rodrigues";

    Auxiliary rafael = new Auxiliary("ZZZ.ZZZ.ZZZ-ZZ");
    rafael.Name = "Rafael Dias";

    Director maiara = new Director("VVV.VVV.VVV-VV");
    maiara.Name = "Maiara Rodrigues";

    AccountManager leandro = new AccountManager("WWW.WWW.WWW-WW");
    leandro.Name = "Leadro Augusto";

    manager.Register(otavio);
    manager.Register(rafael);
    manager.Register(maiara);
    manager.Register(leandro);

    Console.WriteLine("Total bonus: " + manager.TotalBonus);
}

void UsingSystem()
{
    InternalSystem system = new InternalSystem();

    Director roberto = new Director("LLL.LLL.LLL-LL");
    roberto.Name = "Roberto Jorge";
    roberto.Password = "0992";
    roberto.Email = "roberto.jorge@gmail.com";

    AccountManager logan = new AccountManager("PPP.PPP.PPP-PP");
    logan.Name = "Logan West";
    logan.Password = "8712";
    logan.Email = "logan.west@gmail.com";

    system.Login(roberto, roberto.Password, roberto.Email);
    system.Login(logan, logan.Password, logan.Email);
}