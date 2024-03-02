using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuMostrarArtistas : Menu
    {
        public override void Executar(Dictionary<string, Artista> musicasRegistradas)
        {
            base.Executar(musicasRegistradas);
            ExibirTituloDaOpcao("Exibindo todos os artistas registradas na nossa aplicação");

            foreach (string artista in musicasRegistradas.Keys)
            {
                Console.WriteLine($"Artista: {artista}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
