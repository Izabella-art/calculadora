using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlCalculadora control=new ControlCalculadora();
            control.Operacao();
            Console.ReadLine(); //Manter o prompt aberto
        }//fim do metodo main

    }//fim da classe program

}//fim do projeto calculadora


//classe de modelagem
//padrão mvc- model view control ele sao arquivos de modelo de negocio e tem classes de regras do negocio 
//view representação da tela onde fica os botões e tudo mais a main nessa situação é a view 
//control faz o meio de campo e é outra classe faz com que a model se comunique com a view tbm acessa outro objeto que é o dao
//dao é a classe de acesso aos dados e liga o banco de dados
//para reaproveitar o codigo usa-se esse modelo e sabe onde tem que atuar para resolver o problema
