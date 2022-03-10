using System;

namespace Conta.consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            conta conta1 = new conta();           
            conta1.saldo = 1000;
            conta1.status = "é Especial";
            conta1.id = 1;
            conta1.limite = 2000;
            
            conta conta2 = new conta();
            conta2.saldo2 = 500;
            conta2.status = "Não Especial";
            conta2.id = 2 ;
            conta2.limite = 1000;

            Console.WriteLine("INFORMAÇÕES CONTA 1!!");
            Console.WriteLine("==============================");           
            conta1.transferencia(1, 500);
            conta1.versaldo(200, 200, 200);
            conta1.extrato(200, 200, 200);
            Console.WriteLine("==============================");
            conta1.infoc1();
            Console.WriteLine("==============================");

            Console.WriteLine("INFORMAÇÕES CONTA 2!!");
            Console.WriteLine("==============================");
            conta2.transferencia(2, 700);
            conta2.versaldo(200, 300, 280);
            conta2.extrato(200, 300, 280);
            Console.WriteLine("==============================");
            conta2.infoc2();
            Console.WriteLine("==============================");

            Console.ReadLine();
        }
    }
}
