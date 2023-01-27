using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject
{
    internal class MenuHandler
    {
        public void drawMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao parquimetro" + DateTime.Now + "\n");
			Console.WriteLine("Escolha uma das seguintes opções");
			Console.WriteLine("1 - Menu administrador");
            Console.WriteLine("2 - Menu cliente");
            Console.WriteLine("0 - Sair\n");
            
        }
        public void drawAdminMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Administrador");
            Console.WriteLine(DateTime.Now + "\n");

			Console.WriteLine("Escolha uma das seguintes opções");
			Console.WriteLine("1 - Ver zonas");
            Console.WriteLine("2 - Ver historico");
            Console.WriteLine("3 - Ver maquinas");
            Console.WriteLine("4 - Voltar");
            Console.WriteLine("0 - Sair\n");
            
        }

        public void drawClientMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Cliente");
            Console.WriteLine(DateTime.Now + "\n");
			Console.WriteLine("Escolha uma das seguintes opções");
			Console.WriteLine("1 - Estacionar");
            Console.WriteLine("2 - Ver zonas");
            Console.WriteLine("3 - Ver historico");
            Console.WriteLine("4 - Voltar");
            Console.WriteLine("0 - Sair\n");
            
        }
    }
}
