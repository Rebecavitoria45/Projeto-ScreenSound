using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            Console.WriteLine("Tchau tchau :)");
        }
    }
}
