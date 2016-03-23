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

		public Building(int Floor, int Area, int Occupants) {

			this.Floor = Floor;
			this.Area = Area;
			this.Occupants = Occupants;

			Console.WriteLine ("Building Object Constructed With Predefined Values...");

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


	public class BuildingUse {

		static void Main() {

			Building ob1 = new Building ();
			Building ob2 = ob1; // ob2 is pointing to reference object ob1
			// As a result of this situation ob1 and ob2 points the same object;
			Building ob3 = new Building(10, 20, 30);

			ob1.Floor = 5;
			ob1.setArea (12, 7);
			ob1.Occupants = 48;

			ob2.Floor = 10;

			Console.WriteLine ("--- Ob1 --- \n" + ob1.getBuildingData ());
			Console.WriteLine ("--- Ob2 --- \n" + ob2.getBuildingData ());
			Console.WriteLine ("--- Ob3 --- \n" + ob3.getBuildingData ());

		}

	}
}

