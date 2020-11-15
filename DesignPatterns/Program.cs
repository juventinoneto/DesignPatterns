using System;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuTiposPadroes();
        }

        static void MenuTiposPadroes() 
        {
            var escolha = 0;
            do 
            {
                Console.Clear();
                Console.WriteLine("Design Patterns \n");
                Console.WriteLine("1 - Padrões de Criação");
                Console.WriteLine("2 - Padrões Estruturais");
                Console.WriteLine("3 - Padrões Comportamentais");
                Console.WriteLine("4 - Sair");
                escolha = int.Parse(Console.ReadLine().ToString());

                if (escolha == 1 || escolha == 2 || escolha == 3)
                {
                    if (escolha == 1)
                        MenuPadroesCriacao();

                    if (escolha == 2)
                        MenuPadroesEstruturais();
                    
                    if (escolha == 3)
                        MenuPadroesComportamentais();
                }
                else if (escolha != 4)
                {
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                }
            } while(escolha != 4);
            
            
        }

        private static void MenuPadroesComportamentais()
        {
            var escolha = 0;
            do 
            {
                Console.Clear();
                Console.WriteLine("Padrões Comportamentais \n");
                Console.WriteLine("1 - Chains of Resp");
                Console.WriteLine("2 - Command");
                Console.WriteLine("3 - Interpreter");
                Console.WriteLine("4 - Iterator");
                Console.WriteLine("5 - Mediator");
                Console.WriteLine("6 - Memento");
                Console.WriteLine("7 - Observer");
                Console.WriteLine("8 - State");
                Console.WriteLine("9 - Strategy");
                Console.WriteLine("10 - Template Method");
                Console.WriteLine("11 - Visitor");
                Console.WriteLine("12 - Sair");
                escolha = int.Parse(Console.ReadLine().ToString());
            } while(escolha != 12);
        } 

        private static void MenuPadroesEstruturais()
        {
            var escolha = 0;
            do 
            {
                Console.Clear();
                Console.WriteLine("Padrões Estruturais \n");
                Console.WriteLine("1 - Adapter");
                Console.WriteLine("2 - Bridge");
                Console.WriteLine("3 - Composite");
                Console.WriteLine("4 - Decorator");
                Console.WriteLine("5 - Facade");
                Console.WriteLine("6 - Flyweight");
                Console.WriteLine("7 - Proxy");
                Console.WriteLine("8 - Sair");
                escolha = int.Parse(Console.ReadLine().ToString());
            } while(escolha != 8);
        }

        private static void MenuPadroesCriacao()
        {
            var escolha = 0;
            do 
            {
                Console.Clear();
                Console.WriteLine("Padrões de Criação \n");
                Console.WriteLine("1 - Abstract Factory");
                Console.WriteLine("2 - Builder");
                Console.WriteLine("3 - Factory Method");
                Console.WriteLine("4 - Prototype");
                Console.WriteLine("5 - Singleton");
                Console.WriteLine("6 - Sair");                
                escolha = int.Parse(Console.ReadLine().ToString());
            } while(escolha != 6);
        }
    }
}
