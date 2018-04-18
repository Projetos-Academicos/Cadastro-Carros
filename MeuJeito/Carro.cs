using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace MeuJeito
{  // MUDE O LOCAL ONDE SERÁ SALVO OS ARQUIVOS .TXT NO METODO DIRETORIO
  //ESTE PROJETO FOI FEITO NO MEU TERCEIRO PERIODO DA GRADUAÇÃO EM CIÊNCIA DA COMPUTAÇÃO NA DISCIPLINA DE 
 //INTRODUÇÃO A PROGRAMAÇÃO ORIENTADA A OBJETOS.

    public class Carro
    {
        #region ATRIBUTOS

        public string marca;
        public string modelo;
        public string placa;
        public string ano;
        public string mensagem;
        string file;
        string pathFile;
        List<String> listaCarro = new List<String>();

        #endregion

        #region MENU

        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("            ||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("            ||||||||||||||||||| MENU INICIAL |||||||||||||||||||||");
            Console.WriteLine("            ||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("            || 1- ARQUIVO || 2- EXCLUIR || 3- EQUIPE || 4- SAIR ||");
            Console.WriteLine("            ||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("\n\n\n");

            try
            {
                int ii = int.Parse(Console.ReadLine());
                Console.Clear();

                if (ii == 1)
                {
                    Arquivo();
                }
                else if (ii == 2)
                {
                    Excluir();
                }
                else if (ii == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("         TURMA: CCO-FG  3MA / PROGRAMAÇÃO ORIENTADA A OBJETO.");
                    Console.WriteLine("         PROFESSOR: RAONI OLIVEIRA" + " \n\n");
                    Console.WriteLine("                      EQUIPE:   Ricardo Lima. ");
                    Console.WriteLine("                                Jefferson Euclides. ");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else if (ii == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SISTEMA FINALIZADO COM SUCESSO !! \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n OPÇAO NAO ENCONTRADA !");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: DIGITE APENAS VALORES NUMERICOS !");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: VARIAVEL NAO SUPORTA ESSA QUANTIDADE DE NUMEROS !");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            /* catch (Exception)
             {                
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("\n\n ERRO DESCONHECIDO, TENTE NOVAMENTE !");
                 Console.ReadKey();
                 Console.Clear();
                 Menu();
             }     */
        }
        #endregion

        #region ARQUIVO

        public void Arquivo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|| <<MENU |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||||||||||||||||||||||||||||||||| ARQUIVO ||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||| 1- Novo || 2- Salvar || 3- Inserir  || 4- Consultar |||||||||||||");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||| 5- Alterar || 6- Deletar || 7- Voltar |||||||||||||||||||||");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("\n\n\n");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.Clear();

                if (i == 1)
                {
                    Novo();
                }
                else if (i == 2)
                {
                    Salvar();
                }
                else if (i == 3)
                {
                    Inserir();
                }
                else if (i == 4)
                {
                    Consultar();
                }
                else if (i == 5)
                {
                    Alterar();
                }
                else if (i == 6)
                {
                    Deletar();
                }
                else if (i == 7)
                {
                    Menu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n OPÇAO NAO ENCONTRADA !");
                    Console.ReadKey();
                    Console.Clear();
                    Arquivo();
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: DIGITE APENAS VALORES NUMERICOS !");
                Console.ReadKey();
                Console.Clear();
                Arquivo();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: VARIAVEL NAO SUPORTA ESSA QUANTIDADE DE NUMEROS !");
                Console.ReadKey();
                Console.Clear();
                Arquivo();
            }
            /*  catch (Exception)
              {
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("\n\n ERRO DESCONHECIDO, TENTE NOVAMENTE !");
                  Console.ReadKey();
                  Console.Clear();
                  Arquivo();
              }*/
        }
        #endregion

        #region  DIRETORIO

        public void Diretorio()
        {
            string path = @"C:\Users\Ricardo\Desktop\";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("INFORME O NOME DO ARQUIVO!");
            file = Console.ReadLine() + ".txt";
            pathFile = path + file;
        }
        #endregion

        #region NOVO

        public void Novo()
        {
            try
            {
                string continuar = "S";
                while (continuar.ToUpper() == "S")
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Carro carro = new Carro();
                    Console.WriteLine("Informe a Marca do carro:");
                    carro.marca = Console.ReadLine();
                    Console.WriteLine("Informe o Modelo do carro:");
                    carro.modelo = Console.ReadLine();
                    Console.WriteLine("Informe a Placa do Carro:");
                    carro.placa = Console.ReadLine();
                    Console.WriteLine("Informe o Ano do Carro:");
                    int anoo = int.Parse(Console.ReadLine());
                    carro.ano = Convert.ToString(anoo);

                    mensagem = " Marca: " + carro.marca + " /" + " Modelo: " + carro.modelo + " /" + " Placa: " + carro.placa + " /" + " Ano: " + carro.ano;
                    listaCarro.Add(mensagem);

                    Console.WriteLine("DESEJA ADICIONAR OUTRO CARRO? (S/N)");
                    ConsoleKeyInfo result = Console.ReadKey();
                    Console.Clear();
                    if ((result.KeyChar == 'S') || (result.KeyChar == 's'))
                    {
                        continuar = "S";
                    }
                    else
                    {
                        break;
                    }
                }
                CriarNew();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: ANO SO ACEITA NUMEROS !");
                Console.ReadKey();
                Console.Clear();
                Novo();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: ANO ULTRAPASSOU O VALOR MAXIMO DA VARIAVEL !");
                Console.ReadKey();
                Console.Clear();
                Novo();
            }
            catch (DirectoryNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: ACESSO NEGADO AO DIRETORIO !\n");
                Console.WriteLine(" FAVOR CHECAR O DIRETORIO ONDE VAI SER ARMAZENADO O ARQUIVO !");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
        #endregion

        #region CONSULTAR

        public void Consultar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Diretorio();
            if (File.Exists(pathFile))
            {
                Console.Clear();
                string[] lista = File.ReadAllLines(pathFile);
                foreach (string linha in lista)
                {
                    string[] colunas = linha.Split('/');
                    Console.WriteLine("\n " + colunas[0]);
                    Console.WriteLine(colunas[1]);
                    Console.WriteLine(colunas[2]);
                    Console.WriteLine(colunas[3] + "\n");
                }
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ARQUIVO NÃO ENCONTRADO!! ");
                Console.ReadKey();
                Console.Clear();
                Consultar();
            }

        }
        #endregion

        #region  ALTERAR

        public void Alterar()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Diretorio();
                if (File.Exists(pathFile))
                {
                    Console.WriteLine("DIGITE O INDICE QUE DESEJA ALTERAR:");
                    int ind = int.Parse(Console.ReadLine());
                    string[] linhas = File.ReadAllLines(pathFile);
                    listaCarro = new List<string>();
                    listaCarro.AddRange(linhas);
                    Console.WriteLine(listaCarro[ind]);
                    if (null != listaCarro[ind])
                    {
                        Carro carro = new Carro();
                        Console.WriteLine("Informe a Marca do carro:");
                        carro.marca = Console.ReadLine();
                        Console.WriteLine("Informe o Modelo do carro:");
                        carro.modelo = Console.ReadLine();
                        Console.WriteLine("Informe a Placa do Carro:");
                        carro.placa = Console.ReadLine();
                        Console.WriteLine("Informe o Ano do Carro:");
                        int anoo = int.Parse(Console.ReadLine());
                        carro.ano = Convert.ToString(anoo);
                        mensagem = " Marca: " + carro.marca + " /" + " Modelo: " + carro.modelo + " /" + " Placa: " + carro.placa + " /" + " Ano: " + carro.ano;
                        listaCarro[ind] = mensagem;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n ARQUIVO ALTERADO COM SUCESSO !! ");
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n ARQUIVO NAO ENCONTRADO!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n           DIGITE: X PARA RETORNAR AO MENU!");
                    
                    ConsoleKeyInfo result = Console.ReadKey();
                    Console.Clear();
                    if ((result.KeyChar == 'X') || (result.KeyChar == 'x'))
                    {
                        Console.Clear();
                        Arquivo();
                    }
                    else
                    {
                        Console.Clear();
                        Alterar();
                    }
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: DIGITE APENAS VALORES NUMERICOS !");
                Console.ReadKey();
                Console.Clear();
                Alterar();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: VARIAVEL NAO SUPORTA ESSA QUANTIDADE DE NUMEROS !");
                Console.ReadKey();
                Console.Clear();
                Alterar();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: INDICE INFORMADO NAO EXISTE!");
                ConsoleKeyInfo result = Console.ReadKey();
                if ((result.KeyChar == 'X') || (result.KeyChar == 'x'))
                {
                    Console.Clear();
                    Arquivo();
                }
                else
                {
                    Console.Clear();
                    Alterar();
                }

            }
        }
        #endregion

        #region DELETAR
        public void Deletar()
        {
            try
            {
                Diretorio();
                if (File.Exists(pathFile))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("DIGITE O INDICE QUE DESEJA DELETAR:");
                    int ind = int.Parse(Console.ReadLine());
                    string[] linhas = File.ReadAllLines(pathFile);
                    listaCarro = new List<string>();
                    listaCarro.AddRange(linhas);
                    Console.WriteLine("\n\n" + listaCarro[ind]);

                    listaCarro.Remove(listaCarro[ind]);
                    /*File.WriteAllLines(pathFile, listaCarro);*/
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n CARRO DELETADO COM SUCESSO!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n ARQUIVO NAO ENCONTRADO!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n          DIGITE: X PARA RETORNAR AO MENU!");

                    ConsoleKeyInfo result = Console.ReadKey();
                    Console.Clear();
                    if ((result.KeyChar == 'X') || (result.KeyChar == 'x'))
                    {
                        Console.Clear();
                        Arquivo();
                    }
                    else
                    {
                        Console.Clear();
                        Deletar();
                    }
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: DIGITE APENAS VALORES NUMERICOS !");
                Console.ReadKey();
                Console.Clear();
                Deletar();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: VARIAVEL NAO SUPORTA ESSA QUANTIDADE DE NUMEROS !");
                Console.ReadKey();
                Console.Clear();
                Deletar();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: INDICE INFORMADO NAO EXISTE!");
                ConsoleKeyInfo result = Console.ReadKey();
                if ((result.KeyChar == 'X') || (result.KeyChar == 'x'))
                {
                    Console.Clear();
                    Arquivo();
                }
                else
                {
                    Console.Clear();
                    Deletar();
                }
            }
        }
        #endregion

        #region CRIAR NOVO ARQUIVO

        public void CriarNew()
        {
            Diretorio();
            if (File.Exists(pathFile))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n EXISTE UM ARQUIVO COM ESSE NOME, FAVOR ESCOLHER OUTRO NOME!! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                CriarNew();
            }
            else
            {
                File.WriteAllLines(pathFile, listaCarro);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n ARQUIVO CRIADO COM SUCESSO!!");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
        #endregion

        #region  SALVAR

        public void Salvar()
        {
            Diretorio();

            if (File.Exists(pathFile))
            {
                File.WriteAllLines(pathFile, listaCarro);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n ARQUIVO SALVO COM SUCESSO !! ");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ARQUIVO NÃO ENCONTRADO!! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                Salvar();
            }

        }
        #endregion

        #region INSERIR

        public void Inserir()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Diretorio();
                if (File.Exists(pathFile))
                {
                    string[] linhas = File.ReadAllLines(pathFile);
                    listaCarro = new List<string>();
                    listaCarro.AddRange(linhas);
                    Carro carro = new Carro();
                    Console.WriteLine("Informe a Marca do carro:");
                    carro.marca = Console.ReadLine();
                    Console.WriteLine("Informe o Modelo do carro:");
                    carro.modelo = Console.ReadLine();
                    Console.WriteLine("Informe a Placa do Carro:");
                    carro.placa = Console.ReadLine();
                    Console.WriteLine("Informe o Ano do Carro:");
                    int anoo = int.Parse(Console.ReadLine());
                    carro.ano = Convert.ToString(anoo);
                    mensagem = " Marca: " + carro.marca + " /" + " Modelo: " + carro.modelo + " /" + " Placa: " + carro.placa + " /" + " Ano: " + carro.ano;
                    listaCarro.Add(mensagem);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n DADOS INSERIDOS COM SUCESSO!! ");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n ARQUIVO NAO ENCONTRADO!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n           DIGITE: X PARA RETORNAR AO MENU!");

                    ConsoleKeyInfo result = Console.ReadKey();
                    Console.Clear();
                    if ((result.KeyChar == 'X') || (result.KeyChar == 'x'))
                    {
                        Console.Clear();
                        Arquivo();
                    }
                    else
                    {
                        Console.Clear();
                        Inserir();
                    }
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: DIGITE APENAS VALORES NUMERICOS !");
                Console.ReadKey();
                Console.Clear();
                Inserir();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ERRO: VARIAVEL NAO SUPORTA ESSA QUANTIDADE DE NUMEROS !");
                Console.ReadKey();
                Console.Clear();
                Inserir();
            }

        }

        #endregion

        #region Excluir

        public void Excluir()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Diretorio();
            if (File.Exists(pathFile))
            {                
                Console.WriteLine("\n\n DESEJA EXCLUIR PERMANENTEMENTE ESSE ARQUIVO? S/N");
                string bb = Console.ReadLine();
                if (bb.ToUpper() == "S")
                {
                    Console.Clear();
                    File.Delete(pathFile);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n ARQUIVO DELETADO COM SUCESSO!!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n EXCLUSÃO CANCELADA!!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n ARQUIVO NÃO ENCONTRADO!! ");                
                Console.ReadKey();
                Console.Clear();
                Excluir();
            }
        }
        #endregion
    }
}  

















/*    #region  SALVAR COMO
      public void SalvarComo()
      {
          DirSalvarComo();

          if (File.Exists(pathFile))
          {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("ARQUIVO JA EXISTE, FAVOR ESCOLHER OUTRO NOME OU OUTRO DIRETORIO. \n");
              Console.ForegroundColor = ConsoleColor.White;
              Console.ReadKey();
              Console.Clear();
              SalvarComo();
          }
          else
          {
              Console.Clear();
              File.WriteAllLines(pathFile, listaCarro);
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("\n ARQUIVO SALVO COM SUCESSO !!");
              Console.ReadKey();
              Console.Clear();
              Menu();
          }
      }
      #endregion  
      

 #region DIRETORIO SALVAR COMO

        public void DirSalvarComo()
        {        
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("INFORME O CAMINHO DO DIRETORIO ONDE DESEJA SALVAR O ARQUIVO: ");
                string path = @"" + Console.ReadLine();
                Console.WriteLine("INFORME O NOME DO ARQUIVO! * .Extenção * :");
                file = Console.ReadLine();
                pathFile = path + file;            
        }
        #endregion     */