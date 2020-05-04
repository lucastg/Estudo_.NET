using System;

namespace app_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while(tipo != 4)
            {
                if (tipo == 1)
                {
                    gasolina = gasolina+ 1;
                }

                else if
                    (tipo == 2) {
                        alcool = alcool + 1;
                    }

                else if (tipo == 3)
                {
                    diesel = diesel +1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado");
            Console.WriteLine("gasolina: " + gasolina);
            Console.WriteLine("alcool: " + alcool);
            Console.WriteLine("diesel: " + diesel);
        }
    }
}
