using System;

namespace app_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha Invalida!!");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido!!");
        }
    }
}


