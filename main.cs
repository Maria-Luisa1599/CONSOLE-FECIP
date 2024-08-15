using System;

class Program
{
    public static void Main(string[] args) 
    {  
        //variáveis básicas
        string nome = "", sair = "", sair2 = "";

        //array para armazenar as respostas
        string[] respostas = new string[6];

        //variáveis que armazenam a resposta 6, a qual define se a avaliação da pessoa for boa ou ruim 
        int respostaR = 0, respostaB = 0;

        //mantém os dados armazenados
        bool avaliacoes = false;

        //loop

                Console.Clear();  
        while(true)
        {
            do
            {
                #region BEM VINDO
                Console.WriteLine("================ Perguntas ================");
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Bem vindo a área de perguntas, {0}!", nome);
                Console.WriteLine("");
                #endregion

                #region PERGUNTAS
                Console.WriteLine("O que você achou do nosso jogo?");
                Console.WriteLine("Digite 1 para MUITO BOM");
                Console.WriteLine("Digite 2 para BOM");
                Console.WriteLine("Digite 3 para RUIM");
                respostas[0] = Console.ReadLine();
                Console.WriteLine("");
                #region SE A RESPOSTA1 FOR 1, 2 OU 3 ... SENÃO
                    if (respostas[0] == "1" || respostas[0] == "2" || respostas[0] == "3")
                    {
                        //SE A RESPOSTA1 FOR 1, 2 OU 3...
                        Console.WriteLine("Resposta valida! Prosseguindo...");
                        Console.WriteLine("");                    
                    }
                    else
                    {
                        //SENÃO..
                        Console.WriteLine("Desculpe, isso nao e uma resposta valida.");
                        Console.WriteLine("");
                        Console.WriteLine("O que voce achou do nosso jogo?");
                        Console.WriteLine("Digite 1 para MUITO BOM");
                        Console.WriteLine("Digite 2 para BOM");
                        Console.WriteLine("Digite 3 para RUIM");
                        respostas[0] = Console.ReadLine();
                        Console.WriteLine("");
                    }
                #endregion

                Console.WriteLine("Como você avaliaria a dificuldade do jogo?");
                Console.WriteLine("Digite 1 para MUITO FÁCIL");
                Console.WriteLine("Digite 2 para FÁCIL");
                Console.WriteLine("Digite 3 para MEDIANO");
                Console.WriteLine("Digite 4 para DIFÍCIL");
                respostas[1] = Console.ReadLine();
                Console.WriteLine("");
                #region SE A RESPOSTA2 FOR 1, 2 OU 3 ... SENÃO
                    if (respostas[1] == "1" || respostas[1] == "2" || respostas[1] == "3" || respostas[1] == "4")
                    {
                        //SE A RESPOSTA1 FOR 1, 2 OU 3...
                        Console.WriteLine("Resposta valida! Prosseguindo...");
                        Console.WriteLine("");                    
                    }
                    else
                    {
                        //SENÃO..
                        Console.WriteLine("Desculpe, isso nao e uma resposta valida.");
                        Console.WriteLine("");
                        Console.WriteLine("Como você avaliaria a dificuldade do jogo?");
                        Console.WriteLine("Digite 1 para MUITO FÁCIL");
                        Console.WriteLine("Digite 2 para FÁCIL");
                        Console.WriteLine("Digite 3 para MEDIANO");
                        Console.WriteLine("Digite 4 para DIFÍCIL");
                        respostas[1] = Console.ReadLine();
                        Console.WriteLine("");
                    }
                #endregion

                Console.WriteLine("O jogo foi intuitivo e fácil de entender?");
                Console.WriteLine("Digite 1 para INTUITIVO");
                Console.WriteLine("Digite 2 para NEUTRO");
                Console.WriteLine("Digite 3 para CONFUSO");
                respostas[2] = Console.ReadLine();
                Console.WriteLine("");
                #region SE A RESPOSTA3 FOR 1, 2 OU 3 ... SENÃO
                    if (respostas[2] == "1" || respostas[2] == "2" || respostas[2] == "3")
                    {
                        //SE A RESPOSTA1 FOR 1, 2 OU 3...
                        Console.WriteLine("Resposta valida! Prosseguindo...");
                        Console.WriteLine("");                    
                    }
                    else
                    {
                        //SENÃO..
                        Console.WriteLine("Desculpe, isso nao e uma resposta valida.");
                        Console.WriteLine("");
                        Console.WriteLine("O jogo foi intuitivo e fácil de entender?");
                        Console.WriteLine("Digite 1 para INTUITIVO");
                        Console.WriteLine("Digite 2 para NEUTRO");
                        Console.WriteLine("Digite 3 para CONFUSO");
                        respostas[2] = Console.ReadLine();
                        Console.WriteLine("");
                    }
                #endregion

                Console.WriteLine("Quão satisfatória foi a história ou narrativa do jogo?");
                Console.WriteLine("Digite 1 para SATISFEITO");
                Console.WriteLine("Digite 2 para NEUTRO");
                Console.WriteLine("Digite 3 para INSATISFEITO");
                respostas[3] = Console.ReadLine();
                Console.WriteLine("");
                #region SE A RESPOSTA4 FOR 1, 2 OU 3 ... SENÃO
                    if (respostas[3] == "1" || respostas[3] == "2" || respostas[3] == "3")
                    {
                        //SE A RESPOSTA1 FOR 1, 2 OU 3...
                        Console.WriteLine("Resposta valida! Prosseguindo...");
                        Console.WriteLine("");                    
                    }
                    else
                    {
                        //SENÃO..
                        Console.WriteLine("Desculpe, isso nao e uma resposta valida.");
                        Console.WriteLine("");
                        Console.WriteLine("Quão satisfatória foi a história ou narrativa do jogo?");
                        Console.WriteLine("Digite 1 para SATISFEITO");
                        Console.WriteLine("Digite 2 para NEUTRO");
                        Console.WriteLine("Digite 3 para INSATISFEITO");
                        respostas[3] = Console.ReadLine();
                        Console.WriteLine("");
                    }
                #endregion

                Console.WriteLine("O que você acha da diversidade de personagens no jogo?");
                Console.WriteLine("Digite 1 para MUITO BOA");
                Console.WriteLine("Digite 2 para BOA");
                Console.WriteLine("Digite 3 para NEUTRA");
                Console.WriteLine("Digite 4 para RUIM");
                respostas[4] = Console.ReadLine();
                Console.WriteLine("");
                #region SE A RESPOSTA5 FOR 1, 2 OU 3 ... SENÃO
                    if (respostas[4] == "1" || respostas[4] == "2" || respostas[4] == "3" || respostas[4] == "4")
                    {
                        //SE A RESPOSTA1 FOR 1, 2 OU 3...
                        Console.WriteLine("Resposta valida! Prosseguindo...");
                        Console.WriteLine("");                    
                    }
                    else
                    {
                        //SENÃO..
                        Console.WriteLine("Desculpe, isso nao e uma resposta valida.");
                        Console.WriteLine("");
                        Console.WriteLine("O que você acha da diversidade de personagens no jogo?");
                        Console.WriteLine("Digite 1 para MUITO BOA");
                        Console.WriteLine("Digite 2 para BOA");
                        Console.WriteLine("Digite 3 para NEUTRA");
                        Console.WriteLine("Digite 4 para RUIM");
                        respostas[4] = Console.ReadLine();
                        Console.WriteLine("");
                    }
                #endregion

                Console.WriteLine("Qual seria sua avaliação total para esse jogo?");
                Console.WriteLine("Digite 1 para menor ou igual a 100%");
                Console.WriteLine("Digite 2 para menor ou igual a 75%");
                Console.WriteLine("Digite 3 para menor ou igual a 60%");
                Console.WriteLine("Digite 4 para menor ou igual a 30%");
                respostas[5] = Console.ReadLine();
                Console.WriteLine("");
                #region SE A RESPOSTA6 FOR 1, 2 OU 3 ... SENÃO
                    if (respostas[5] == "1" || respostas[5] == "2" || respostas[5] == "3" || respostas[5] == "4")
                    {
                        //SE A RESPOSTA1 FOR 1, 2 OU 3...
                        Console.WriteLine("Resposta valida! Prosseguindo...");
                        Console.WriteLine("");                    
                    }
                    else
                    {
                        //SENÃO..
                        Console.WriteLine("Desculpe, isso nao e uma resposta valida.");
                        Console.WriteLine("");
                        Console.WriteLine("Qual seria sua avaliação total para esse jogo?");
                        Console.WriteLine("Digite 1 para menor ou igual a 100%");
                        Console.WriteLine("Digite 2 para menor ou igual a 75%");
                        Console.WriteLine("Digite 3 para menor ou igual a 60%");
                        Console.WriteLine("Digite 4 para menor ou igual a 30%");
                        respostas[5] = Console.ReadLine();
                        Console.WriteLine("");
                    }
                #endregion
                #endregion

                #region ARMAZENANDO RESPOSTA BOA E RUIM
                if (respostas[5] == "1" || respostas[5] == "2")
                {
                    respostaB += 1;
                }
                if (respostas[5] == "3" || respostas[5] == "4")
                {
                    respostaR += 1;
                }
                Console.WriteLine("");
                #endregion

                #region MOSTRANDO AS RESPOSTAS PARA O USUÁRIO COM SWITCH
                switch(respostas[0])
                {
                    case "1": Console.WriteLine("Você achou nosso jogo MUITO BOM"); break;
                    case "2": Console.WriteLine("Você achou nosso jogo BOM"); break;
                    case "3": Console.WriteLine("Você achou nosso jogo RUIM"); break;
                }

                switch(respostas[1])
                {
                    case "1": Console.WriteLine("Você avaliou a dificuldade do jogo em MUITO FÁCIL"); break;
                    case "2": Console.WriteLine("Você avaliou a dificuldade do jogo em FÁCIL"); break;
                    case "3": Console.WriteLine("Você avaliou a dificuldade do jogo em MEDIANO"); break;
                    case "4": Console.WriteLine("Você avaliou a dificuldade do jogo em DIFÍCIL"); break;                    
                }

                switch(respostas[2])
                {
                    case "1": Console.WriteLine("Você achou que o jogo é INTUITIVO"); break;
                    case "2": Console.WriteLine("Você achou que o jogo é NEUTRO"); break;
                    case "3": Console.WriteLine("Você achou que o jogo é CONFUSO"); break;
                }

                switch(respostas[3])
                {
                    case "1": Console.WriteLine("Você está SATISFEITO com a narrativa do jogo"); break;
                    case "2": Console.WriteLine("Você está NEUTRO com a narrativa do jogo"); break;
                    case "3": Console.WriteLine("Você está INSATISFEITO com a narrativa do jogo"); break;
                }

                switch(respostas[4])
                {
                    case "1": Console.WriteLine("Você acha MUITO BOA a diversidade de personagens"); break;
                    case "2": Console.WriteLine("Você acha BOA a diversidade de personagens"); break;
                    case "3": Console.WriteLine("Você está NEUTRO sobre a diversidade de personagens"); break;
                    case "4": Console.WriteLine("Você acha RUIM a diversidade de personagens"); break;                    
                }

                switch(respostas[5])
                {
                    case "1": Console.WriteLine("Você nos avaliou com uma nota menor ou igual a 100%"); break;
                    case "2": Console.WriteLine("Você nos avaliou com uma nota menor ou igual a 75%"); break;
                    case "3": Console.WriteLine("Você nos avaliou com uma nota menor ou igual a 60%"); break;
                    case "4": Console.WriteLine("Você nos avaliou com uma nota menor ou igual a 30%"); break;                    
                }
                Console.WriteLine("");    
                #endregion

                #region SAÍDA
                Console.WriteLine("Obrigado por avaliar!");
                Console.WriteLine("Deseja sair? s/n");
                sair = Console.ReadLine();
                #endregion
            } while (sair == "n");

            #region OPERADOR
            //operador nome
            Console.WriteLine("Digite o nome do operador: ");
            nome = Console.ReadLine();

            if(nome=="barros")
            { 
                Console.Clear();  
                Console.WriteLine("");                
                Console.WriteLine("Você está na área de avaliações.");
                Console.WriteLine("{0} pessoas acharam seu jogo BOM (gostaram de mais de 60% do jogo)", respostaB);
                Console.WriteLine("{0} pessoas acharam seu jogo RUIM (gostaram menos ou igual a 60% do jogo)", respostaR);  
                Console.WriteLine("");
                Console.WriteLine("Deseja sair? s/n");
              sair2 = Console.ReadLine();
                if(sair2 == "s"){                 
                  avaliacoes = true;
                 }else{
                   Console.WriteLine("");
                   Console.WriteLine("Digite 's' quando quiser sair.");
                 }
            }
            else
            {
                //senão...
                Console.WriteLine("Nome do operador não reconhecido.");                
            }
            #endregion
        }
        Console.ReadKey();
    }
}
