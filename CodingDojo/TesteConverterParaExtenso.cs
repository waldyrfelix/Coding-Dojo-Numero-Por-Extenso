using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class TesteConverterParaExtenso
    {
        [TestMethod]
        public void Quando_passar_0_retornar_zero()
        {
            int entrada = 0;
            string saida = "zero";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }


        [TestMethod]
        public void Quando_passar_1_retornar_um()
        {
            int entrada = 1;
            string saida = "um";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }


        [TestMethod]
        public void Quando_passar_5_retornar_cinco()
        {
            int entrada = 5;
            string saida = "cinco";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void Quando_passar_10_retornar_dez()
        {
            int entrada = 10;
            string saida = "dez";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }


        [TestMethod]
        public void Quando_passar_11_retornar_onze()
        {
            int entrada = 11;
            string saida = "onze";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void Quando_passar_12_retornar_doze()
        {
            int entrada = 12;
            string saida = "doze";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }
        [TestMethod]
        public void Quando_passar_13_retornar_treze()
        {
            int entrada = 13;
            string saida = "treze";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }
        [TestMethod]
        public void Quando_passar_14_retornar_quatorze()
        {
            int entrada = 14;
            string saida = "quatorze";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }
        [TestMethod]
        public void Quando_passar_15_retornar_quinze()
        {
            int entrada = 15;
            string saida = "quinze";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void Quando_passar_19_retornar_dezenove()
        {
            int entrada = 19;
            string saida = "dezenove";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void Quando_passar_20_retornar_vinte()
        {
            int entrada = 20;
            string saida = "vinte";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void Quando_passar_21_retornar_vinte_e_um()
        {
             int entrada = 21;
            string saida = "vinte e um";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);  
        }

        [TestMethod]
        public void Quando_passar_30_retornar_trinta()
        {
            int entrada = 30;
            string saida = "trinta";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void Quando_passar_40_retornar_quarenta()
        {
            int entrada = 40;
            string saida = "quarenta";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod ]
        public void Quando_passar_50_retornar_cinquenta()
        {
            int entrada = 50;
            string saida = "cinquenta";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void Quando_passar_58_retornar_cinquenta_e_oito()
        {
            int entrada = 58;
            string saida = "cinquenta e oito";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }


        [TestMethod]
        public void Quando_passar_72_retornar_setenta_e_dois()
        {
            int entrada = 72;
            string saida = "setenta e dois";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void Quando_passar_100_retornar_cem()
        {
            int entrada = 100;
            string saida = "cem";

            string retorno = ConveterParaExtenso(entrada);

            Assert.AreEqual(saida, retorno);
        }

        [TestMethod]
        public void TesteEmExecução()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(ConveterParaExtenso(i));
                Console.WriteLine();
            }
        }

        private string ConveterParaExtenso(int entrada)
        {

            string numeroPorExtenso = string.Empty;

            var numerosDeZeroADezenove = new string[] { "zero", "um", "dois", "três", "quatro", 
                "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze","treze","quatorze","quinze","dezeseis",
            "dezesete","dezoito","dezenove"};

            var dezenasDeViteACem = new string[]{"vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", 
                                        "noventa", "cem"};

            if (entrada > 19)
            {
                int dezena = entrada / 10;
                int unidade = entrada % 10;

                numeroPorExtenso = dezenasDeViteACem[dezena - 2];

                if (unidade != 0)
                    numeroPorExtenso += " e " + numerosDeZeroADezenove[unidade];
            }
            else
            {
                numeroPorExtenso = numerosDeZeroADezenove[entrada];
            }

            return numeroPorExtenso;
        }


    }
}
