using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class ModelCalculadora
    {
        //declarando variaveis
        private double num1;
        private double num2;


        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;


        }//fim do construtor

        //get set
        public double GetSetNum1
        {
                get {return this.num1; }
                set {this.num1 = value; }
        }//fim do get set num 1
        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//fim do get set num 2

        //metodos 
        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do metodo somar
        
        //metodo subtrair
        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//fim do metodo subtrair

        //metodo dividir
        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }

        }//fim do metodo dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//fim do metodo multiplicar

        //
        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//fim da potencia

        public string Raiz()
        {

            string msg = "Raiz do primeiro número: " + Math.Sqrt(GetSetNum1) +
                            "\nRaiz Segundo número: " + Math.Sqrt(GetSetNum2);
            return msg;
        }
        public string TabuadaNum1()
        {
            string resultado = "";
            for (int i = 0;i <=10; i++) 
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            
            }//fim do for

            return resultado;

        }//fim do metodo

        public string TabuadaNum2()
        {
            string resultado = "";

            //inicio;fim;contagem
            for (int i = 0; i <= 10; i++)
            {
                resultado += GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);

            }//fim do for

            return resultado;

        }//fim do metodo


        public int ConverterDecimal(string binario)
        {
            int dec = 0;
            string caract = "";
            int tamanho = binario.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Convert.ToInt32(Math.Pow(2, pote));
                }
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterBinario(int dec)
        {
            string binario = "";
            int resto = 0;
            do
            {
                resto = dec % 2;
                binario += resto;
                dec = dec / 2;
            } while (dec != 0);
            return new String(binario.Reverse().ToArray());
        }//fim do método

        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterDecimalHexa(int dec)
        {
            int resto = 0;
            string hexadecimal = "";

            do
            {
                resto = dec % 16;
                switch (resto)
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += resto;
                        break;
                }//fim do switch
                dec = dec / 16;
            } while (dec != 0);
            return new string(hexadecimal.Reverse().ToArray());
        }//fim do converter

        public string bhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta <= 0)
            {
                return "Impossível calcular X1 e X2, Delta: " + delta;
            }
            else
            {
                double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Delta: " + delta + "\nX1: " + X1 + "\nX2: " + X2;
            }
        }//fim do bhaskara

        public string ConverterBinarioHexadecimal (string binario)
        {
            int dec = ConverterDecimal(binario);
            string hex = ConverterDecimalHexa(dec);
            //pegou o valor bin converteu para dec
            return hex;



        }//fim do metodo
        

        //////////////////////Exercicios//////////////////////

        public string MultiplicarDobroTriplo (double num)
        {
            string DobroTriplo = "O dobro é: " (num * 2) " \n O triplo é: " (num * 3);

            return DobroTriplo;
        }//fim do metodo
        //underscorepegar um numero e multilplicar por dois e por tres




        public string Salario (double num1)
        {   
            
            string SalarioAtual ((num1 * 100 / )30)
            
        }








        public string ParOuImpar(int num1, int num2)
        {
            int ParImpar = (num1 % 2);
            
            if(ParImpar = 0 )
            {
                return "o numero é par" + PositivoNegativo;
            }
            else
            {
                return "o numero é impar" + PositivoNegativo;
            }
            
            int PositivoNegativo ()
            if (num1 < 0)
            {
                return "o numero é negativo" + ParImpar;
            }
            else
            {
                return "o numero é positivo" + ParImpar;
            }
            
        }//pegar um numero dizer se é negativo ou positivo  e par ou impar




        //mod %
        //so pode tirar raiza de um numero de cada vez
        //guarda o dado como texto e depois mostra de uma vexz na tela ja que nao da pra colocar 2 return de uma vez e tem que transformar em numero apes isso criando um metodo para cada return
    }//fim da classe
    //metodo construtor cria um objeto na memoria
    //instanciar e adicionar valores iniciais
    //transformar as variaveis em private
    //get set ve e devolve o conteudo
    //+= pegar oq ta dentro e concatenar com o resto
    //substring coleta cada caracter
    //
    //tamanho de uma variavel do tipo texto length
    //substring para quebrar em caracteres quebra da esquerda para a direita 
    //math pow o lugar que voce quer elevado a math.pow(2, i)
    //guarda ba variavel j por exemplo e põe j-1 (esse processo é decimal binario 
    //qualque numero concatenado com aspas converte para string
    //mod na conta
    //reverse e vetor array(ilimitado)
    //
    //
    //
    //
}//fim do projeto
