using System;

namespace StringSwitch {

	class StringDemo {

		static void Main() {

			String[] txt = {"Zero", "One", "Two",
			"Three", "Four", "Five", "Six", 
			"Seven", "Eight", "Nine", "Ten"};

			int c = 0;

			foreach (string u in txt) {

				switch (u) {

				case "Zero":
					c = 0;
					break;

				case "One":
					c = 1;
					break;

				case "Two":
					c = 2;
					break;

				case "Three":
					c = 3;
					break;

				case "Four":
					c = 4;
					break;

				case "Five":
					c = 5;
					break;

				case "Six":
					c = 6;
					break;

				case "Seven":
					c = 7;
					break;

				case "Eight":
					c = 8;
					break;

				case "Nine":
					c = 9;
					break;

				case "Ten":
					c = 10;
					break;

					default:
					c=-1;
					break;

				}

				Console.Write (u + "(" + c + ") ");

			}

			Console.WriteLine ();

		}

	}

}
