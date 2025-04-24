using System;//Importando namespace System que serve pra evitar ter de escrever System.n.... toda vez.
using System.Text.RegularExpressions;//Importando namespace que contem a Class Regex.

while (true)//inicia um loop infinito
{
    Console.WriteLine("Informe uma senha:         [Ctrl+C]Sair");//Printa a mensagem de requerimento de senha e informa como SAIR do programa.
    
string password = Console.ReadLine();//Declara a String password para guardar o input do teclado atraves do .ReadLine().


if (StrongPassword(password))//Verifica se o retorno da função/metodo StrongPassword é "True".
{
    Console.WriteLine("Senha forte :D");//Caso o retorno da função seja "True", Printa "Senha forte :D".
}else{Console.WriteLine("Senha FRACA! >:(");}//Caso o retorno da função seja "False", Printa "Senha FRACA! >:(" ).
}


static bool StrongPassword(string password){//Cria uma Função "StrongPassword" que recebe uma String.

    //o "Regex" é uma Class da namespace importada "System.Text.RegularExpressions"-
    //-é utilizado para verificar se uma String atende a um determinado padrão.
    //".IsMatch" é um metodo da Class "Regex" que serve pra verificar se a String informada atende ao Padrão tbm informado "Regex.IsMatch(String, Padrão)".

    if (password.Length<8){
        Console.WriteLine($"A senha deve conter pelo menos 8 caracteres!"); //Mostra o motivo da senha ser fraca para o usuário
        return false;
    } //O ".length" pega o tamanho da String e compara com 8(num min de caracteres).
    if(!Regex.IsMatch(password, "[A-Z]")){
        Console.WriteLine($"A senha deve conter pelo menos uma letra maiúscula!"); //Mostra o motivo da senha ser fraca para o usuário
        return false;
    } //Negando(!) o Regex.IsMatch verifica se as Letras Maiusculas de A-Z não existem na String, se não existirem Retorna "False".
    if(!Regex.IsMatch(password, "[0-9]")){
        Console.WriteLine($"A senha deve conter pelo menos um caractere numérico!"); //Mostra o motivo da senha ser fraca para o usuário
        return false;
    } //Negando(!) o Regex.IsMatch verifica se numeros não existem na String, se não existirem Retorna "False".
    if(!Regex.IsMatch(password, @"[!@#\$%\^&\*\(\),\.\?""\:\{\}\|\<\>]")){
        Console.WriteLine($"A senha deve conter pelo menos um caractere especial!"); //Mostra o motivo da senha ser fraca para o usuário 
        return false;
    } //Negando(!) o Regex.IsMatch verifica se os caracteres especiais não estão presentes na string, se não existirem Retorna "False".
                                                                                        //O "@" antes da string faz com que o C# interprete a string como verbatim string literal — ou seja, ele não processa "\" como escape normal.
                                                                                        //Os "\" escapam os caracteres especiais dentro da regex corretamente assim evitando conflito de caracteres com alguma função.
    return true;//Se passar por todas as verificações sem falhar, Retorna "True".
}