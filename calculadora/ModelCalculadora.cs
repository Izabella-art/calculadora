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
         //so pode tirar raiza de um numero de cada vez
         //guarda o dado como texto e depois mostra de uma vexz na tela ja que nao da pra colocar 2 return de uma vez e tem que transformar em numero apes isso criando um metodo para cada return
    }//fim da classe
    //metodo construtor cria um objeto na memoria
    //instanciar e adicionar valores iniciais
    //transformar as variaveis em private
    //get set ve e devolve o conteudo
    //+=pegar oq ta dentro e concatenar com o resto
    //substring coleta cada caracter
}//fim do projeto
