using System;
namespace ConsoleApp
{
class GreetingProgram
{
static void Main (string[] args)
{
Console.Write("Name: ");
string name = Console.ReadLine();  

Console.Write("Present Address: ");
string pa1 = Console.ReadLine(); 

Console.Write("Permanent Address: ");
string pa2 = Console.ReadLine(); 

Console.Write("Date of birth: ");
string dob = Console.ReadLine(); 

Console.Write("Civil Status: ");
string cs = Console.ReadLine(); 

Console.Write("Citizenship: ");
string cp = Console.ReadLine(); 

Console.Write("Name of Father: ");
string f = Console.ReadLine(); 

Console.Write("Name of Mother: ");
string m = Console.ReadLine(); 

Console.Write("Address: ");
string address = Console.ReadLine(); 

Console.Write("Language or Dialect Spoken: ");
string lod = Console.ReadLine(); 

Console.Write("Person to be notified Incase of Emergency: ");
string emergency = Console.ReadLine(); 

Console.Write("Religion: ");
string religion = Console.ReadLine(); 

Console.Write("Age: ");
int age;
age = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Weight: ");
string weight = Console.ReadLine(); 

Console.Write("Height: ");
string height = Console.ReadLine(); 



//===========================================================


Console.WriteLine("Name: " + name);
Console.WriteLine("Present Address: " + pa1);
Console.WriteLine("Permanent Address: " + pa2);
Console.WriteLine("Date of birth: " + dob + "               Religion: " + religion);
Console.WriteLine("Civil Status: " + cs + "                       Age: " + age);
Console.WriteLine("Citizenship: " + cp + "                    Weight: " + weight);
Console.WriteLine("Name of Father: " + f + "                  Height: " + height);
Console.WriteLine("Name of Mother: " + m);
Console.WriteLine("Address: " + address);
Console.WriteLine("Language or Dialect Spoken: " + lod);
Console.WriteLine("Person to be notified Incase of Emergency: " + emergency);
Console.ReadKey();
}
}
}