using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Linkin Park");
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");

        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[5]);

        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //var musicasPreferidasEmilly = new MusicasPreferidas("Emilly");
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[8]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[9]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[10]);

        //musicasPreferidasEmilly.ExibirMusicasFavoritas();
        //musicasPreferidasEmilly.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
