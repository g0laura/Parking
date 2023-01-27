namespace ParkingProject;

class Program
{
    static void Main(string[] args)
    {
        Boolean login = true;
        int menuChoice =0;
        int menuLevel = 1;
        //Inicializador de zonas
        Zones zone1 = new Zones(1.15, 45, new Random().Next(99) + 1);
        Zones zone2 = new Zones(1, 120, new Random().Next(99) + 1);
        Zones zone3 = new Zones(0.62, 999999, new Random().Next(99) + 1);


        MenuHandler menus = new MenuHandler();

        HelperClass helperClass = new HelperClass();

        if (helperClass.timeIsValid())
        {

            menus.drawMainMenu();

        }
        else
        {
            Console.WriteLine("Fora de horas");
            login = false;
        }

        while (login == true)
        {


            if (menuLevel == 1)
            {

                try
                {

                    menuChoice = int.Parse(Console.ReadLine());

                    switch (menuChoice)
                    {
                        case 1:
                            menus.drawAdminMenu();
                            menuLevel = 2;
                            break;
                        case 2:
                            menus.drawClientMenu();
                            menuLevel = 3;
                            break;
                        case 0:
                            login = false;
                            Console.Clear();
                            Console.WriteLine("Adeus, volte sempre");
                            break;

                        default:

                            throw new Exception("Opção não valida, tente novamente");

                    }

                }

                catch (FormatException ex)
                {

                    Console.WriteLine("\nErro: " + ex.Message + "\nEscolha uma opção válida do menu");

                }

            }

            //Menu administrador
            else if (menuLevel == 2)
            {
                try
                {
					menuChoice = int.Parse(Console.ReadLine());
					switch (menuChoice)
                    {
                        case 1:
                            //Chamar metodo para ver zonas
                            Console.WriteLine("\n");
                            Console.WriteLine("Informação da zona 1: ");
                            zone1.getZoneInfo();
                            Console.WriteLine("Informação da zona 2: ");
                            zone2.getZoneInfo();
                            Console.WriteLine("Informação da zona 3: ");
                            zone3.getZoneInfo();

							Console.ReadLine();
							menuLevel = 1;
							menus.drawMainMenu();
							break;

						case 2:
                            //Chamar metodo para ver historico
                            //menuLevel = 1;
                            break;
                        case 3:
                            //Chamar metodo para ver maquinas
                            //menuLevel = 1;
							//menus.drawMainMenu();
							break;
                        case 4:
                            //Chamar metodo para voltar
                            menuLevel = 1;
                            menus.drawMainMenu();
                            break;
                        case 0:
                            login = false;
                            Console.Clear();
                            Console.WriteLine("Adeus, volte sempre");
                            break;
                    }

                }


                catch (FormatException ex)
                {

                    Console.WriteLine("\nErro: " + ex.Message);
                    //Console.WriteLine(" ");
                    Console.WriteLine("\nEscolha uma opção válida do menu");

                }
            }

            //Menu cliente
            else 


			{
                try
                {
                    menuChoice = int.Parse(Console.ReadLine());
                    switch (menuChoice)
                    {
                        case 1:
                            //Chamar metodo para estacionar
                            Console.WriteLine("Qual a zona que pretende estacionar?");
                            int zoneChoice = int.Parse(Console.ReadLine());
                            switch (zoneChoice)
                            {
                                case 1:
                                    zone1.parkCar();
                                    
                                    break;
                                case 2:
                                    zone2.parkCar();
                                    break;
                                case 3:
                                    zone3.parkCar();
                                    break;
                            }

							Console.ReadLine();
							menuLevel = 1;
							menus.drawMainMenu();
							break;
                        case 2:
                            //chamar metodo para ver zonas
                            Console.WriteLine("Informação da zona 1: ");
                            zone1.getZoneInfo();
                            Console.WriteLine("Informação da zona 2: ");
                            zone2.getZoneInfo();
                            Console.WriteLine("Informação da zona 3: ");
                            zone3.getZoneInfo();
                            Console.ReadLine();

                            
                            menuLevel = 1;
							menus.drawMainMenu();
							break;
                        case 3:
                            //Chamar metodo para ver historico
                            menuLevel = 1;
                            break;
                        case 4:
                            //Chamar metodo para voltar
                            menuLevel = 1;
                            menus.drawMainMenu();
                            break;
                        case 0:
                            login = false;
                            Console.Clear();
                            Console.WriteLine("Adeus, volte sempre");
                            break;

                    }
                }

                catch (FormatException ex)
                {


                    Console.WriteLine("\nErro: " + ex.Message + "\n");
                   
                    Console.WriteLine("Escolha uma opção válida do menu");

                }
            }

        }

    }
}


