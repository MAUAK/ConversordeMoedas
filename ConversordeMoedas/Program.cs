using System;
using System.Globalization;

namespace ConversordeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ----------------- KAUAM SILVA BATISTA - 210501 ----------- 
             * 
             * Valor do dólar (R$5,59) - https://economia.uol.com.br/noticias/redacao/2021/11/24/dolar-comercial-opera-em-queda-r-5606.htm
             * Valor IOF para pessoas fisíicas (4,08%) - https://riconnect.rico.com.vc/blog/iof
             */

            //
            ConversordeMoedas cm = new ConversordeMoedas();

            
            //
            Console.WriteLine("QUAL É A COTAÇÃO DO DÓLAR? ");
            cm.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //
            Console.WriteLine("\nQUANTOS DÓLARES VOCÊ IRÁ COMPRAR? ");
            cm.QtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            cm.ValorEmReais();
            Console.WriteLine("\nVALOR A SER PAGO EM REAIS = " + cm.ValorReais.ToString("F2", CultureInfo.InvariantCulture));
            
            //
            Console.WriteLine("\nVALOR A SER PAGO DE IOF: ");
            cm.IOF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cm.ValorTotalIOF();
            Console.WriteLine("\nVALOR TOTAL DA COMPRA COM IOF = " + cm.ValorTotal);

        }
    }
}
