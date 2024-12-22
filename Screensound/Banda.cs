using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screensound
{
    public class Banda
    {
        public Banda(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; }

        private List<Album> albums = [];

        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach (var album in albums)
            {
                Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
            }
        }
    }
}
