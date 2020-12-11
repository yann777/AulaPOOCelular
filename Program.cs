using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alunos aluno = new Alunos();

            // Console.WriteLine("Digite o Nome do Aluno: ");
            // aluno.nome = Console.ReadLine();

            // Console.WriteLine("Digite o Curso do Aluno: ");
            // aluno.curso = Console.ReadLine();

            // Console.WriteLine("Digite o RG do Aluno: ");
            // aluno.rg = Console.ReadLine();

            // Console.WriteLine("Digite a Idade do Aluno: ");
            // aluno.curso = Console.ReadLine();

            // Console.WriteLine("Digite a Média Final do Aluno: ");
            // aluno.mediaFinal = float.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o valor da Mensalidade do Aluno: ");
            // aluno.curso = Console.ReadLine();

            // Console.WriteLine("Digite se o Aluno é bolsista (s/n): ");
            // string resposta = Console.ReadLine();
            // if(resposta == "s"){
            //     aluno.bolsista = true;
            // }
            // else{
            //     aluno.bolsista = false;
            // }

            // int opcao = 0;

            // do{
            //     Console.WriteLine("Selecione uma opção");
            //     Console.WriteLine("[1] - Ver Média do Aluno");
            //     Console.WriteLine("[2] - Ver Mensalidade do Aluno");
            //     Console.WriteLine("[0] - Sair");
            //     opcao = int.Parse(Console.ReadLine());


            // switch (opcao){
            //     case 1:
            //         Console.WriteLine($"A Média final do Aluno {aluno.nome} = {aluno.VerMediaAluno()}");
            //     break;

            //     case 2:
            //         Console.WriteLine($"A Mensalidade do Aluno fica em: {aluno.VerMensalidade()}");
            //     break;
                
            //     case 0:
            //         Console.WriteLine("Obrigado por acessar!");
            //     break;

            //     default:
            //          Console.WriteLine("Opção Inválida");
            //     break;
              
            // }
            // }while (opcao != 0);

            Celular celular = new Celular();

            int opcao = 0;
            int opcaoMenu = 0;

            Console.WriteLine("Celular no console");
            Console.WriteLine("[1] - Ligar");
            Console.WriteLine("[0] - Desligar");
            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1){
                Console.WriteLine("Digite a Cor do celular:");
                celular.cor = Console.ReadLine();

                Console.WriteLine("Digite o Modelo do celular:");
                celular.modelo = Console.ReadLine();

                Console.WriteLine("Digite o Tamanho do celular:");
                celular.tamanho = float.Parse(Console.ReadLine()); 

                do{     
                    Console.WriteLine("Selecione uma opção");
                    Console.WriteLine("[1] - Especificações do celular");
                    Console.WriteLine("[2] - Mandar mensagem");
                    Console.WriteLine("[3] - Fazer ligação");
                    Console.WriteLine("[0] - Sair");
                    opcao = int.Parse(Console.ReadLine()); 

            switch (opcaoMenu){
                case 1:
                    Console.WriteLine($"Modelo {celular.modelo}, cor {celular.cor}, {celular.tamanho} cm de altura.");
                break;

                case 2:
                    Console.WriteLine("Para quem a mensagem será enviada?");
                    Console.ReadLine();
                    Console.WriteLine("Digite a mensagem:");
                    Console.ReadLine();
                    Console.WriteLine("mensagem enviada com sucesso!");
                break;

                case 3:
                   Console.WriteLine("Para quem a ligação será feita?");
                   Console.ReadLine();
                   Console.WriteLine("Ligando...");
                   Console.ReadLine();
                   Console.WriteLine("A ligação caiu na caixa postal, tente novamente mais tarde!");
                break;

                default:
                     Console.WriteLine("Opção Inválida");
                break;
                }

              }while(opcaoMenu != 0);
            }
            else{
                Console.WriteLine("Tchau!");
            }

        }
    }
}
