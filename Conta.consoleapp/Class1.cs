using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.consoleapp
{
    public class conta
    {
        public double saldo;
        public string status;
        public double limite;
        public int hisorico;
        public int id;
        public double saldo2;
        public double vsaque;
        public double vdeposito;
        public double vtransferencia;
        public double nsaldo;
        
       
        
        public void extrato(double vsauqe, double vdeposito, double vtransferencia)
        {
            Console.WriteLine("Voce depositou: {0}", vdeposito);
            Console.WriteLine("Voce sacou: {0}", vsauqe);
            Console.WriteLine("Voce transferiu: {0}", vtransferencia);
        }
       public void transferencia(int contaquerecebe, double vtransfrencia)
       {
          if(contaquerecebe == 1)
          {
                saldo = vtransfrencia + saldo;
                saldo2 = saldo2 - vtransferencia;
          }
          else if (contaquerecebe == 2)
          {
                saldo2 = vtransfrencia + saldo;
                saldo = saldo - vtransferencia;
          }   
        }
        public void versaldo(double vsauqe, double vdeposito, double vtransferencia)
        {
            saldo = saldo - vsauqe + vdeposito - vtransferencia;

        }
        public void infoc1()
        {
            Console.WriteLine("O saldo da conta é: {0}", saldo);
            Console.Write("A conta ");
            Console.WriteLine(status);
            Console.WriteLine("O limite da conta é: {0}", limite);
            Console.WriteLine("O id da conta é: {0}", id);
        }
        public void infoc2()
        {
            Console.WriteLine("O saldo da conta é: {0}", saldo2);
            Console.Write("A conta ");
            Console.WriteLine(status);
            Console.WriteLine("O limite da conta é: {0}", limite);
            Console.WriteLine("O id da conta é: {0}", id);
        }


    }
    
}
