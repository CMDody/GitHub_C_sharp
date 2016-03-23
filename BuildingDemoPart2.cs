using System;
using System.Configuration;

namespace BuildingDemo
{
	public class Building
	{

		public int Floor;
		public int Area;
		public int Occupants;

		public Building ()
		{
			Floor = 0;
			Area = 0;
			Occupants = 0;

			Console.WriteLine ("Building Object Constructed...");

		}

		public void setArea(int x, int y) {
			Area = x * y;
		}

		public string getBuildingData() {

			string txt = "Floor = " + Floor.ToString () + " \n";
			txt += "Area = " + Area.ToString () + " \n";
			txt += "Occupants = " + Occupants.ToString () + " \n";

			return txt;

		}

		~Building ()
		{
			Console.WriteLine ("Building Object Destructed...");
		}

	}

	// This program need to be compiled with "BuildingDemoPart1.cs" file

}

