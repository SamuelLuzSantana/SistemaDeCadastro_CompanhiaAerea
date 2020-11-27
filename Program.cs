using System;

namespace Agencia_aerea
{
    class Program
    {
        static void Main(string[] args)
        {

        //Variaveis
        bool senhavalida;
        int contador=0;
        int contadorn=0;
        int escolha;
        string resposta;
        
        //Dados da passagem
        string[] nome = new string[5];
        string[] origem = new string[5];
        string[] destino = new string[5];
        string[] data = new string[5];


        //inicio algoritmo

        
        
        Console.Clear();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("-----Sistema de passagens areas-----");
        Console.WriteLine("------------------------------------");
        
        //Login
        do{
            
        Console.WriteLine("Digite a senha para acessar o sistema");
        string senha = Console.ReadLine();
        senhavalida = efetuarlogin(senha);
        if(contador==3){
            Console.WriteLine("Numero de tentantivas execedido \n Tente novamente mais tarde");
            break;
        }

        }while (!senhavalida);

        do
        {   
            Console.WriteLine("-----------------------");
            Console.WriteLine("  Menu Principal  ");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma Opção abaixo: ");
            Console.WriteLine("[1] - Cadastrar passagem | [2] - Listar Passagem | [0] - Sair");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (escolha)
            {
                case 1:
                    //Cadastrar uma Passagem
                    Console.WriteLine("");
                    Console.WriteLine("Cadastro de Passagem:");
                    do
                    {
                        if(contadorn<5)
                        {
                        Console.WriteLine($"Digite o nome do {contadorn + 1}º passageiro: ");
                        nome[contadorn] = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine($"Digite o Destino: ");
                        destino[contadorn] = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine($"Digite a Origem: ");
                        origem[contadorn] = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine($"Digite a data do Voo");
                        data[contadorn] = Console.ReadLine();
                        Console.WriteLine("");


                        contadorn++;

                        }else{Console.WriteLine("limite Execedido");
                        break;}

                        Console.WriteLine("");
                        Console.WriteLine("Voce gostaria de Cadastrar um novo passageiro? [s/n] :");
                        resposta = Console.ReadLine();
                        Console.WriteLine("");

                    } while (resposta.ToUpper()=="S");

                    Console.Clear();
                    break;

                case 2:
                    //Listar passagens
                    Console.WriteLine("");
                    Console.WriteLine("---------------------");
                    Console.WriteLine(" Lista de Passagem ");
                   Console.WriteLine("");

                   Console.WriteLine("-");
                   for (var i = 0; i <contadorn ; i++)
                   {
                       
                       Console.WriteLine($"Passageiro: {nome[i]} | Origem: {origem[i]} | Destino: {destino[i]} | Data de Vôo: {data[i]}");
                   }
                    Console.WriteLine("-");
                    break;    

                    case 0:
                    //Sair
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Obrigado por viajar conosco :D");
                    
                    break; 

                default:
                    Console.WriteLine("Opção Invalida, Escolha uma das opções listadas.");
                    break;
            }
            

        } while (escolha !=0);

            





        //funções
        bool efetuarlogin(string senha){

            if (senha=="123456")
            {
                return true;
            }else
            {
                Console.WriteLine("Senha Invalida, Tente novamente");
                contador++;
                Console.WriteLine("");
                return false;
            }
        

            
        }
    }
}
}