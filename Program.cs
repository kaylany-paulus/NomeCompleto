using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numericName, numDecision;
            string firstName, surname, decision;
            bool userName, numericalDecision;

            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.Write("\nESTE PROGRAMA VEREFICARÁ SEU NOME EM DIFERENTES PERSPECTIVAS.");
            Console.ResetColor();

            Console.WriteLine("\n\nPara prosseguirmos por favor responda corretamente as perguntas.");
            Console.Write("\nDigite seu primeiro nome..: ");
            firstName= Console.ReadLine();
            userName= Int32.TryParse(firstName, out numericName);
            if (userName)
            {
                Console.Clear();    
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("\nESTE NOME É INVÁLIDO!");
                Console.ResetColor();
                Environment.Exit(-1);
            }

            Console.Write("Digite seu sobrenome..: ");
            surname= Console.ReadLine();
            userName= Int32.TryParse(surname, out numericName);
            if (userName)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("\nESTE SOBRENOME É INVÁLIDO!");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine($"\nOlá {firstName}{surname}, você está concorrendo a uma Cesta de Páscoa!");
            Console.ResetColor();
            Console.WriteLine("\nResponda [S] para SIM ou outro caractere para [NÃO].");
            Console.Write("Deseja continuar e ganhar a incrível Cesta de Páscoa..: ");
            decision= Console.ReadLine();
            numericalDecision= Int32.TryParse( decision, out numDecision);
            if (numericalDecision)
            {
              Console.Clear();
              Console.ForegroundColor=ConsoleColor.Yellow;
              Console.WriteLine($"\nA OPÇÃO ({numDecision}) NÃO É VÁLIDA");
              Console.ResetColor();
              Environment.Exit(-1);
              Console.ReadKey();
             
            }
            else if (decision.ToString().ToUpper() != "S")
            {
              Console.Clear();
              Console.ForegroundColor=ConsoleColor.Yellow;
              Console.WriteLine($"\n{firstName}{surname}você escolheu finalizar o programa!");
              Console.ResetColor();
              Console.ResetColor();
              Console.ForegroundColor= ConsoleColor.Green;
              Console.WriteLine("\n\nObrigada pelo acesso!");
              Console.ResetColor();  
              Console.ReadKey();  
              Environment.Exit(-1);
            }
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine($"\nPARA COMEÇARMOS POR FAVOR RESPONDA AS PERGUNTAS CORRETAMENTE.");
            Console.ResetColor();
            Console.Write("\nInsira a sequência numérica do seu cartão..: ");
            Console.ReadKey();
            Console.WriteLine("\nO QUE VOCÊ ESTÁ FAZENDO? jÁ IA COLOCANDO A SEQUÊNCIA NUMÉRICA DO SEU CARTÃO NÉ?!");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine($"\n\n{surname.ToUpper()},{firstName}leia com atenção!");
            Console.WriteLine("\nNUUUNCA...FORNEÇA INFORMAÇÕES DE MANEIRA TÃO DISPLICENTE!");
            Console.WriteLine("NEM MESMO POR UMA INCRÍVEL CESTA DE PÁSCOA.");
            Console.ResetColor();

            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("\n\nObrigada pelo acesso!");
            Console.ResetColor();
            
        }
                
    }
              
}

