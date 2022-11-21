Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "таня")
{
    Console.WriteLine ("Ура, Приветствую тебя Таня!");
}
else
{
    Console.Write ("Привет, ");
    Console.Write (username);
}