﻿Console.WriteLine("What's your mame?");
string userName= Console.ReadLine();
if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.WriteLine("Привет, " + userName);
}