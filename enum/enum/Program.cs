using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
            enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar};
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada) 
            { 
                case Opcao.Criar:
                    Console.WriteLine("Criando");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Deletando");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Edtando");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Listando");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Atualizando");
                    break;
            }

            Console.ReadLine();

        }
    }
}
