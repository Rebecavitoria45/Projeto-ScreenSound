using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarMusica : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Registro de músicas");
            Console.Write("Digite o artista cuja música deseja registrar: ");
            string nomeDoArtista = Console.ReadLine()!;
            var artistaRecuperado = artistaDAL.RecuperarPor(a => a.Nome.Equals(nomeDoArtista));
            if (artistaRecuperado is not null)
            {
                Console.Write("Agora digite o título da música: ");
                string tituloDaMusica = Console.ReadLine()!;
                Console.Write("Agora digite o ano de lançamento da música: ");
                string anoLancamento = Console.ReadLine()!;
                artistaRecuperado.AdicionarMusica(new Musica(tituloDaMusica)
                { AnoLancamento = Convert.ToInt32(anoLancamento) });
                Console.WriteLine($"A música {tituloDaMusica} de {nomeDoArtista} foi registrada com sucesso!");
                artistaDAL.Atualizar(artistaRecuperado);
                Thread.Sleep(4000);
                Console.Clear();
            }
        }
    }
}
