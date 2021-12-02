using System;
using System.Collections.Generic;
using System.Text;

namespace ConversordeMoedas
{
    class ConversordeMoedas
    {
        //Criando a variavel de quantidade de dólares com encapsulamento
        public double QtdDolares { get; set; }        
        //Criando a variavel de cotação de dólares com encapsulamento
        public double CotacaoDolar { get; set; }
        //Criando a variavel do valor de IOF com encapsulamento
        public double IOF { get; set; }
        //Criando a variavel do valor convertido em reais com encapsulamento
        public double ValorReais { get; set; }
        //Criando a variavel total com encapsulamento
        public double ValorTotal { get; set; }

        //Criando o método para fazer o calculo do valor do dólar em reais
        public void ValorEmReais()
        {
            //Fazendo o calculo da conversão
            ValorReais = QtdDolares * CotacaoDolar;
        }

        //Criando o método dpara incrementar a porcentagem do IOF no valor total
        public void ValorTotalIOF()
        {
            //Fazendo o calculo
            ValorReais += ValorReais * IOF;
            //Igualando o valor com o IOF na varipavel Valor total
            ValorTotal = ValorReais;
        }        
    }
}
