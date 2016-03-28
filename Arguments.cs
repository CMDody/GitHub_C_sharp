using System;

namespace Arg {

	class mainClass {

		static int Main(string[] Arg) {

			if (Arg.Length == 0) {
				
				Console.WriteLine ("No argument was entered to command line...");

			} else if (Arg.Length > 0) {

				int c = 0;
				foreach (string u in Arg) {
					c++;
					Console.WriteLine ("Order:{0, 2} ---> Argument:{1} ", c, u);
				}

			} else {

				Console.WriteLine ("Faulty argument handling...");

				return 1; // Return code 1 to system means that program finalized by fault

			}


			return 0;  // Returning code 0 to system means that program finalized by success

		}

	}

}
