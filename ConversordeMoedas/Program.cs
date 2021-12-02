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

            //Instanciando a classe de Conversor de Moedas
            ConversordeMoedas cm = new ConversordeMoedas();
            
            //Pedindo qual é a cotação do dólar
            Console.WriteLine("QUAL É A COTAÇÃO DO DÓLAR? ");
            //Guardando o valor na variável de cotação de dólar
            cm.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Pedindo quantos dólares ira ser comprado
            Console.WriteLine("\nQUANTOS DÓLARES VOCÊ IRÁ COMPRAR? ");
            //Guardando o valor na variável de quantidade de dólares
            cm.QtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //Chamando o método para converter o valor em real
            cm.ValorEmReais();
            //Imprimindo o valor de dólares em real
            Console.WriteLine("\nVALOR A SER PAGO EM REAIS = " + cm.ValorReais.ToString("F2", CultureInfo.InvariantCulture));
            
            //Pedindo qual irá seo o valor do IOF
            Console.WriteLine("\nVALOR A SER PAGO DE IOF: ");
            //Guardando o valor do IOF na variável IOF
            cm.IOF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Chamando o método para fazer o valor total com o IOF
            cm.ValorTotalIOF();
            //Imprimindo o valor total
            Console.WriteLine("\nVALOR TOTAL DA COMPRA COM IOF = " + cm.ValorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
