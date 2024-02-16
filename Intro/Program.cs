// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System.Diagnostics.Metrics;

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables -->camelCase
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoş geldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
//string[] loans2 = new string[6];
//loans2="Kredi 1";

      //start     condition   increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new(new DapperCourseDal());

List<Course> courses2= courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
Console.WriteLine("Kod bitii");

InvidiualCustomer customer1 = new InvidiualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

InvidiualCustomer customer2 = new InvidiualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678924";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123458";

CorporateCustomer customer3= new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "645778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 3;
customer4.Name = "Kodlamaio";
customer4.CustomerNumber = "645778";
customer4.TaxNumber = "12345678985";
//value types --> int, bool, double...
//Değer tutucular

int number1=10;//20
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 ={ "Bursa", "Bolu", "Diyarbakır"};

cities2 = cities1;

cities1[0] = "Adana";
Console.WriteLine(cities2[0]);

//referans tutucu
//reference types --> array, class, interface...
                            //101      //102      //103      //104
BaseCustomer[] customers = {customer1, customer2, customer3, customer4};
//polymorhism
foreach(BaseCustomer customer in customers)
{
    //if(customer is InvidiualCustomer)
    //{
    //    Console.WriteLine((((InvidiualCustomer)customer).FirstName));
    //}
    Console.WriteLine(customer.CustomerNumber);
}