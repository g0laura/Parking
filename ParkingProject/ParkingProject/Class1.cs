using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject
{ class Ticket
	{
		private string matricula;
		private double time;
		private double cost;
		private int zone;
		private double change;

		public Ticket(string matricula, int zone, double time, double cost, double change)
		{
			this.Matricula = matricula;
			this.Time = time;
			this.Cost = cost;
			this.Zone = zone;
			this.Change = change;
		}

		public string Matricula { get => matricula; set => matricula = value; }
		public double Time { get => time; set => time = value; }
		public double Cost { get => cost; set => cost = value; }
		public int Zone { get => zone; set => zone = value; }
		public double Change { get => change; set => change = value; }


		public void CalcularDuracion(double saldo, int zone)
		{
			switch (zone)
			{
				case 1:
					// costo por hora 1.15€
					// duracion maxima 45 minutos
					if (cost >= 0.75)
					{
						time = 45;
					}
					else
					{
						time = cost / 1.15;
					}
					break;
				case 2:
					// costo por hora 1€
					// duracion maxima 2 horas
					if (cost >= 2)
					{
						time = 120;
					}
					else
					{
						time = cost / 1;
					}
					break;
				case 3:
					// costo por hora 0.62€
					// no tiene duracion maxima
					time = cost / 0.62;
					break;
				default:
					Console.WriteLine("Zona no valida");
					break;
			}
		}
	}

}
















//public void calcularCosto(string zone, double duration)

//{
//		double cost = 0;
//		double maxDuration = 0;
//		double change = 0;

//		if (zone == "Zona 1")
//		{
//			cost = duration * 1.15;
//			maxDuration = 45;
//		}
//		else if (zone == "Zona 2")
//		{
//			cost = duration * 1;
//			maxDuration = 120;
//		}
//		else if (zone == "Zona 3")
//		{
//			cost = duration * 0.62;
//			maxDuration = double.PositiveInfinity;
//		}
//		if (duration > maxDuration)
//		{
//			Console.WriteLine("La duracion maxima permitida para esta zona es de " + maxDuration + " minutos. Por favor, ingrese una duracion valida.");
//		}
//		else
//		{
//			Console.WriteLine("Introduzca el saldo: ");
//			double saldo = double.Parse(Console.ReadLine());
//			if (saldo < cost)
//			{
//				Console.WriteLine("Saldo insuficiente. El costo total es de " + cost + " euros.");
//			}
//			else
//			{
//				change = saldo - cost;
//				Console.WriteLine("El costo total es de " + cost + " euros. El troco es de " + change + " euros.");
//				//this.cost = cost;
//				//this.change = change;
//			}
//		}
//	}

//}

