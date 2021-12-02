using System;
using System.Collections.Generic;
using System.Text;

namespace ConversordeMoedas
{
    class ConversordeMoedas
    {
        //Criando a variavel id com encapsulamento
        public double QtdDolares { get; set; }        
        //Criando a variavel salario com encapsulamento
        public double CotacaoDolar { get; set; }
        //Criando a variavel salario com encapsulamento
        public double IOF { get; set; }
        //Criando a variavel salario com encapsulamento
        public double ValorReais { get; set; }
        //Criando a variavel salario com encapsulamento
        public double ValorTotal { get; set; }

        //Criando o método para incrementar a porcentagem ao salario
        public void ValorEmReais()
        {
            //Fazendo o calculo da porcentagem
            ValorReais = QtdDolares * CotacaoDolar;
        }

        public void ValorTotalIOF()
        {
            ValorReais += ValorReais * IOF;
            ValorTotal = ValorReais;
        }        
    }
}
