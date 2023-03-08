Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

// if (username == 'Маша'); or 
if (username.ToLower() == "маша")
{
  Console.WriteLine("Ура, это же МАША!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}
