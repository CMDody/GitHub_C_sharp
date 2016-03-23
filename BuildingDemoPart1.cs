using System;
using System.Configuration;

namespace BuildingDemo
{

	public class BuildingUse {

		static void Main() {

			Building ob1 = new Building ();
			ob1.Floor = 5;
			ob1.setArea (12, 7);
			ob1.Occupants = 48;

			Console.WriteLine (ob1.getBuildingData ());

		}

	}

	// This program need to be compiled with "BuildingDemoPart2.cs" file

}

