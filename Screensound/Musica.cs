using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screensound
{
    public class Musica
    {
        public Musica(Banda banda, string nome)
        {
            Artista = banda;
            Nome = nome;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida =>
            $"A música {Nome} pertence à banda {Artista.Nome}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine(Disponivel ? "Disponível no plano." : "Adquira o plano Plus+");
            Console.WriteLine(DescricaoResumida + "\n");
        }
    }
}
