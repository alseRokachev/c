Console.Write("Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "alex") 
{
    Console.WriteLine("Дарова, Кент");
} 
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}