using System;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contatos[] pessoa = new Contatos[5];
            int i = 0;
            do
            {
                int menu = Menu();

                switch (menu)
                {
                    case 1:
                        i = InsereContato(pessoa, i);
                        break;

                    case 2:
                        ImprimeContato(pessoa);
                        break;

                    case 3:
                        BuscarContato(pessoa);
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente Novamente.\n");
                        Console.Beep(600, 1000);
                        break;
                }
                if (menu == 0)
                {
                    Console.WriteLine("O programa foi finalizado.\n");
                    break;
                }
                Console.WriteLine("Tecle enter para realizar outra ação.\n");
                Console.ReadLine();
                Console.Clear();

            } while (true);
        }

        private static int Menu()
        {
            Console.WriteLine("***Escolha a opção desejada***");
            Console.WriteLine("1 - Inserir contato na agenda");
            Console.WriteLine("2 - Imprimir contatos da agenda");
            Console.WriteLine("3 - Buscar contatos na agenda");
            Console.WriteLine("0 - Sair do programa");
            Console.Write("\nOpção ");
            int menu = int.Parse(Console.ReadLine());
            if (menu == 0)
                Console.Beep(660, 700);
            else
                Console.Beep(660, 200);
            Console.Clear();
            return menu;
        }

        private static int InsereContato(Contatos[] pessoa, int i)
        {
            if (i < 5)
            {
                pessoa[i] = new Contatos();
                Console.Write("Nome: ");
                pessoa[i].Nome = Console.ReadLine();
                Console.Write("Idade: ");
                pessoa[i].Idade = (Console.ReadLine());
                Console.Write("Sexo: ");
                pessoa[i].Sexo = Console.ReadLine();
                Console.Write("Telefone: ");
                pessoa[i].Tel = (Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Contato inserido com sucesso!\n");
                i++;
            }
            else
                Console.WriteLine("Sua agenda está cheia\n");
            return i;
        }

        private static void ImprimeContato(Contatos[] pessoa)
        {
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                if (pessoa[i] != null)
                {
                    Console.WriteLine("Nome: " + pessoa[i].Nome);
                    Console.WriteLine("Idade: " + pessoa[i].Idade + " anos");
                    Console.WriteLine("Sexo: " + pessoa[i].Sexo);
                    Console.WriteLine("Telefone: " + pessoa[i].Tel);
                    Console.WriteLine("\n______________________________________________\n");

                    contador++;
                }
            }
            Console.WriteLine($"\nA pesquisa retornou {contador} resultados.\n");
            Console.WriteLine("______________________________________________\n");
        }


        private static void BuscarContato(Contatos[] pessoa)
        {
            Console.Write("Buscar: ");
            string busca = Console.ReadLine();
            int contador = 0;
            for (int j = 0; j < 5; j++)
            {
                if (pessoa[j] != null && pessoa[j].Nome.ToLower() == busca.ToLower())
                {
                    Console.WriteLine("Nome: " + pessoa[j].Nome);
                    Console.WriteLine("Idade: " + pessoa[j].Idade + " anos");
                    Console.WriteLine("Sexo: " + pessoa[j].Sexo);
                    Console.WriteLine("Telefone: " + pessoa[j].Tel);
                    Console.WriteLine("\n______________________________________________\n");

                    contador++;
                }
            }
            Console.WriteLine($"\nA pesquisa retornou {contador} resultados.\n");
            Console.WriteLine("______________________________________________\n");
        }
    }
}
