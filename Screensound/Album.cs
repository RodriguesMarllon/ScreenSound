using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screensound
{
    public class Album
    {
        private List<Musica> musicas  = [];
        public string Nome { get; set; }
        public int DuracaoTotal { get; set; }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
    }
}
