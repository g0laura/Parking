using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject
{
	internal class Zones
	{
		private double hourRate;
		private int duration;
		private int capacity;
		private string[] parkingSlots;
		private double total;
		private int zone;

		public Zones(double hourRate, int duration, int capacity)
		{
			this.HourRate = hourRate;
			this.Duration = duration;
			this.Capacity = capacity;
			this.ParkingSlots = parkingSlots;
			this.Total = total;
			this.Zone = zone;
		}

		public double HourRate { get => hourRate; set => hourRate = value; }
		public int Duration { get => duration; set => duration = value; }
		public int Capacity { get => capacity; set => capacity = value; }
		public string[] ParkingSlots { get => parkingSlots; set => parkingSlots = value; }//string da minha capacidade .ToString()
		public double Total { get => total; set => total = value; }
		public int Zone { get => zone; set => zone = value; }

		public void getZoneInfo()
		{
			Console.WriteLine("Tarifa da zona: " + hourRate);
			Console.WriteLine("Duração de estacionamento: " + duration);
			Console.WriteLine("Capacidade: " + capacity + "\n");
		}

		public void parkCar()
		{
			Boolean login = true;
			double total = 0;
			double coins = 0;
			int parkingSpot = 0;
			this.parkingSlots = new string[this.capacity];
			int zone = 0;

			while (login == true)
			{
				Console.WriteLine("Introduza as moedas. Prima 0 para terminar");
				coins = double.Parse(Console.ReadLine());

				if (coins == 0)
				{
					Console.WriteLine("Introduziu um total de" + total + "euros");



					Console.WriteLine("Esta é a lista de lugares: ");

					//parkingSpot
					for (int i = 0; i < capacity; i++)
					{


						if (string.IsNullOrEmpty(parkingSlots[i]))
						{
							Console.WriteLine((i + 1) + ".-Esta vazio. ");
						}

						else
						{
							Console.WriteLine((i + 1) + ".-Esta ocupado. ");
						}

					


					}
					login = false;
				}
				else
				{
					total = total + coins;
					
				}
			}

		}
	}
}

Console.WriteLine("Introduza a matricula: ");
string mat = Console.ReadLine();

Console.WriteLine("Qual é o lugar que quer estacionar?");

//array para os lugares verificação