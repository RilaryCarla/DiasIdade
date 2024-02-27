using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos meses se passaram desde o seu aniversário: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos dias se passam do seu aniversário ate completar o mês: ");
            int dias = int.Parse(Console.ReadLine());

            int IdadeAnos = anos * 365;
            int IdadeMeses = meses * 30;
            int Total = IdadeAnos + IdadeMeses + dias;
            Console.WriteLine("A sua idade em dias é: " + Total);
            Console.ReadKey();
        }
    }
}
