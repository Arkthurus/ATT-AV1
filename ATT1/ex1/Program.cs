using System;
using System.Text.RegularExpressions;

while (true)
{
    Console.WriteLine("Informe uma senha: ");

string password = Console.ReadLine();

if (StrongPassword(password))
{
    System.Console.WriteLine("Senha forte :D");
}else{System.Console.WriteLine("Senha FRACA! >:(");}
}


static bool StrongPassword(string password){

    if (password.Length<8){return false;}
    if(!Regex.IsMatch(password, "[A-Z]")){return false;}
    if(!Regex.IsMatch(password, "[0-9]")){return false;}
    if(!Regex.IsMatch(password, @"[!@#\$%\^&\*\(\),\.\?""\:\{\}\|\<\>]")){return false;}
    return true;
}