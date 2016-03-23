using System;


namespace StringArray {

	class StringDemo {

		static void Main() {

			string[] str = {"This", 
				"is", 
				"a", 
				"test", 
				"text"};

			foreach (string u in str) {
				Console.Write (u + "(" + u.Length + ") ");
			}
			Console.WriteLine ();


		}

	}

}
