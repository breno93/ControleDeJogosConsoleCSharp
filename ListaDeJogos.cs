using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeJogos
{
    public class ListaDeJogos
    {

        //Aqui estou criando uma propriedade privada/public para que o usuário tenha acesso...
        //...a lista de jogos.
        private List<Jogo> jogos;

        //lista de objetos da classe Jogo
        public List<Jogo> Jogos
        {
            get 
            { 
                return jogos; 
            }   
        }

        public ListaDeJogos()
        {
            //Aqui em vez de trabalhar com a propriedade 'Jogos', eu trabalho com o dado privado...
            //...'jogos'
            jogos = new List<Jogo>();  
        }

        public Boolean Inserir(Jogo jogo)
        {
            //Começo com o Boolean true, alegando que o usuário pode adicionar jogos.
            Boolean resultado = true;
            try
            {
                Jogo j = jogos.Find(x => x.Id == jogo.Id);
                if (j == null)
                {
                    jogos.Add(jogo);
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception erro)
            {
                resultado = false;
            }
            return resultado;
        }

        public Boolean Alterar(Jogo jogo)
        {
            Boolean resultado = false;
            Jogo j = jogos.Find(x => x.Id == jogo.Id);
            if (j != null)
            {
                j.Nome = jogo.Nome;
                j.Descricao = jogo.Descricao;
                j.Genero = jogo.Genero;
                j.Console = jogo.Console;
                resultado = true;
            }
            return resultado;
        }

        public Boolean Excluir(int id)
        {
            Boolean resultado = false;
            Jogo j = jogos.Find(x => x.Id == id);
            if (j != null)
            {
                resultado = jogos.Remove(j);
            }
            return resultado;
        }

        //método Localizar()
        public List<Jogo> Localizar(String nome)
        {
            /* Instanciei List<Jogo> no 'lj', onde estou utilizando o 'FindAll' para...
            localizar o 'nome' que foi passado como parametro do Método Localizar()...
            Já o FindAll está utilizando o objeto 'x', para localizar um 'Nome' que contenha...
            o 'nome' do Metodo Localizar()*/
            List<Jogo> lj = jogos.FindAll(x => x.Nome.Contains(nome.ToUpper()));

            return lj;
        }

        public List<Jogo> ListarPorGenero(TipoGenero genero)
        {
            List<Jogo> lg = jogos.FindAll(x => x.Genero.Equals(genero));
            return lg;
        }

        public List<Jogo> ListarPorConsole(TipoConsole console)
        {
            List<Jogo> lc = jogos.FindAll(x => x.Console.Equals(console));
            return lc;
        }

    }
}
