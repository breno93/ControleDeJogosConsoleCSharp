using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeJogos
{
    //Enumeração que representa diferentes gêneros de jogos
    public enum TipoGenero
    {
        Acao, Aventura, Casual, Puzzle, Estrategia, Outro
    }

    //Enumeração que representa diferentes consoles de jogos
    public enum TipoConsole
    {
        PS4, PS5, Switch, Xbox_360, Xbox_One, PC, Outro
    }

    //Construtor padrão sem parâmetros
    public class Jogo
    {
        public Jogo()
        {
            this.id = 1;
            this.Nome = "";
            this.Descricao = "";
            this.Genero = TipoGenero.Outro;
            this.Console = TipoConsole.Outro;
        }

        //Construtor com PARÂMETROS para criar um jogo com valores específicos
        public Jogo(int id, String nome, String descricao, TipoGenero genero, TipoConsole console)
        {
            this.id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Console = console;
        }

        //Campo privado para armazenar o ID do jogo
        private int id;

        //Propriedade para acessar e modificar o ID, com validação
        public int Id
        {
            get { return id; }
            set 
            {
                if (value > 0) 
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Permitido apenas numeros positivos!");
                }
            }
        }

        //Campos privados para armazenar o nome do jogo
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        //Campos privados para armazenar a descrição do jogo
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public TipoConsole Console { get; set; }
        public TipoGenero Genero { get; set; }
    }
}