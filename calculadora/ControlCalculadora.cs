using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class ControlCalculadora
    {
        ModelCalculadora calculadora;//criando um objeto calculadora na memoria

        public ControlCalculadora()
        {
            this.calculadora = new ModelCalculadora();//representação do objeto como se fosse uma sala fechada onde a calculadora uma chave pra abrir a outra sala usando qndo quiser os metodos da outra classe

        }//fim do construtor

        public void Coletar() //void é quando nao retorna nada
                              //
        {
            Console.WriteLine("informe um numero: ");//Escreva
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());//Leia

            Console.WriteLine("informe outro numero: ");//Escreva
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());//Leia

        }//fim do coletar

        public int Menu()
        {
            Console.WriteLine("-------------Menu-----------" +
                             "\n0. Sair" +
                             "\n1. Somar" +
                             "\n2. Subtrair" +
                             "\n3. Dividir" +
                             "\n4. Multiplicar" +
                             "\n4. Potencia" +
                             "\n5. Raiz do Primeiro Numero" +
                             "\n6. Tabuada do primeiro numero" +
                             "\n7. Tabuada do segundo numero" +
                             "\n\nEscolha uma das opções acima: ");

            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;



        }//fim do metodo menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();

                switch (opcao)
                {

                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;//encerra a operação

                    case 1:
                        Coletar();
                        Console.WriteLine("Soma:" + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração" + this.calculadora.Subtrair());
                        break;
                    case 3://se o retorno deesse metodo for igual a menos um impossivel dividir
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("impossivel dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Multiplicar());

                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar:" + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("potencia:" + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz; " + this.calculadora.Raiz());
                        break;

                    case 7://o coletar tem dois numeros ent ao chamar ele deveria ser quebrado ou algo assim e eu qro apenas um numero
                        Console.WriteLine("Informe um numero: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 8:
                        Console.WriteLine("Informe um numero:");
                        this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum2());
                        break;

                    default:
                        Console.WriteLine("opção escolhida não é valida");
                        break;


                }//fim do switch
            } while (opcao != 0);//fim do whilw

        }//fim da classe
         //control void e model return
         //reforça que a calculadora que esta em cima é a variavel
         //quanto mais metodoa melhor
    }
}//fim do projeto
