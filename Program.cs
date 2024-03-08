using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeJogos
{
    internal class Program
    {
        static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("<===> Controle de Jogos <===>");
            Console.WriteLine("\nSELECIONE UMA OPÇÃO: ");
            Console.WriteLine("[1] - Cadastrar um jogo.");
            Console.WriteLine("[2] - Excluir um jogo.");
            Console.WriteLine("[3] - Alterar um jogo.");
            Console.WriteLine("[4] - Localizar um jogo por nome.");
            Console.WriteLine("[5] - Listar os jogos por Genero.");
            Console.WriteLine("[6] - Listar os jogos por Console.");
            Console.WriteLine("[7] - Listar todos os jogos.");
            Console.WriteLine("[9] - Sair.");

            Console.Write("\nQual opção deseja escolher: ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            ListaDeJogos listadejogos = new ListaDeJogos();
            List<Jogo> lista = new List<Jogo>();
            String nomejogo = "";
            int id = 0;
            

            //Jogos para teste do sistema.
            Jogo jogo = new Jogo(1, "Counter-Strike", "Jogo de FPS", TipoGenero.Acao, TipoConsole.PC);
            listadejogos.Inserir(jogo);

            jogo = new Jogo(2, "Call of Duty", "Jogo de FPS", TipoGenero.Acao, TipoConsole.PC);
            listadejogos.Inserir(jogo);

            jogo = new Jogo(3, "Battlefield I", "Jogo de FPS", TipoGenero.Acao, TipoConsole.PC);
            listadejogos.Inserir(jogo);

            int op = 0;


            while (op != 9)
            {
                op = ShowMenu();
                Console.Clear();

                switch (op) 
                {
                    case 1: //inserir
                        Console.WriteLine("Inserir novo jogo");
                        jogo = new Jogo(); //Construindo um novo objeto 

                        Console.Write("ID: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine()); //Utilizo o objeto que construi 

                        Console.WriteLine("Nome: ");
                        jogo.Nome = Console.ReadLine();

                        Console.WriteLine("Descrição: ");
                        jogo.Descricao = Console.ReadLine();

                        Console.Write("Informe o Genero: Acao [0], Aventura [1], Casual [2], Puzzle [3], Estrategia [4], Outro [5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe o Console: PS4 [0], PS5 [1], Switch [2], Xbox 360 [3], Xbox One [4], PC [5], Outro [6] ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listadejogos.Inserir(jogo))
                        {
                            Console.WriteLine("\nJogo inserido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\nJogo não encontrado");
                        }
                        Console.ReadKey();
                        break;


                    case 2: //excluir
                        Console.WriteLine("Excluir jogo");
                        Console.Write("Informe o ID do jogo: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (listadejogos.Excluir(id))
                        {
                            Console.WriteLine("\nJogo excluído com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("\nJogo não encontrado");
                        }
                        Console.ReadKey();
                    break;


                    case 3: //alterar
                        Console.WriteLine("Alterar jogo");
                        jogo = new Jogo(); //Construindo um novo objeto 

                        Console.Write("ID: ");
                        jogo.Id = Convert.ToInt32(Console.ReadLine()); //Utilizo o objeto que construi 

                        Console.WriteLine("Nome: ");
                        jogo.Nome = Console.ReadLine();

                        Console.WriteLine("Descrição: ");
                        jogo.Descricao = Console.ReadLine();

                        Console.Write("Informe o Genero: Acao [0], Aventura [1], Casual [2], Puzzle [3], Estrategia [4], Outro [5]: ");
                        jogo.Genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe o Console: PS4 [0], PS5 [1], Switch [2], Xbox 360 [3], Xbox One [4], PC [5], Outro [6] ");
                        jogo.Console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listadejogos.Alterar(jogo))
                        {
                            Console.WriteLine("\nJogo alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\nJogo não encontrado!");
                        }
                        Console.ReadKey();
                        break;


                    case 4: //localizar por nome
                        Console.WriteLine("Localizar jogos");
                        Console.Write("Informe o nome do jogo: ");
                        nomejogo = Console.ReadLine();

                        lista = listadejogos.Localizar(nomejogo);
                        foreach (var j in lista)
                        {
                            Console.Write("Id: " + j.Id);
                            Console.Write(" - Nome: " + jogo.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                    break;


                    case 5: //listar Genero
                        Console.WriteLine("Listar todos os jogos por genero");
                        Console.Write("Informe o Genero: Acao [0], Aventura [1], Casual [2], Puzzle [3], Estrategia [4], Outro [5]: ");
                        TipoGenero genero = (TipoGenero)Convert.ToInt32(Console.ReadLine());

                        lista = listadejogos.ListarPorGenero(genero);
                        foreach (var j in lista)
                        {
                            Console.Write("Id: " + j.Id);
                            Console.Write(" - Nome: " + jogo.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("\nAperte qualquer tecla para continuar");
                        Console.ReadKey();
                    break;


                    case 6: //listar console
                        Console.WriteLine("Listar todos os jogos por console");
                        Console.Write("Informe o Console: PS4 [0], PS5 [1], Switch [2], Xbox 360 [3], Xbox One [4], PC [5], Outro [6] ");
                        TipoConsole console = (TipoConsole)Convert.ToInt32(Console.ReadLine());

                        lista = listadejogos.ListarPorConsole(console);
                        foreach (var j in lista)
                        {
                            Console.Write("Id: " + j.Id);
                            Console.Write(" - Nome: " + jogo.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                    break;


                    case 7: //listar todos os jogos
                        Console.WriteLine("Listar todos os jogos");
                        foreach (var j in listadejogos.Jogos)
                        {
                            Console.Write("Id: " + j.Id);
                            Console.Write(" - Nome: " + j.Nome);
                            Console.Write(" - Descricao: " + j.Descricao);
                            Console.Write(" - Genero: " + j.Genero);
                            Console.WriteLine(" - Console: " + j.Console);
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                    break;
                }
            }
        }
    }
}
