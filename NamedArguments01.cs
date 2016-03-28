using System;

namespace CallingArgumentsByName {

	class myClass {

		public void show(int alpha, double beta, string name) {

			Console.WriteLine ("Alpha:{0}, Beta:{1}, Name:{2}", 
				alpha, 
				beta, 
				name);

		}

	}

	class mainClass {

		static void Main() {

			myClass obj = new myClass ();

			obj.show (12, 23.45, "Murat");  
			// Calling arguments by order...

			obj.show (name: "Burak", alpha: 35, beta: 23.45);  
			// Calling all arguments by name...

			obj.show (34, name: "Gonul", beta: 45.67); 
			// Calling first argument by order, the others called by name...
			// in other terms this is called, mix calling of arguments...

			// obj.show (beta: 88.99, alpha: 56, "Guner");
			// this is faulty because...
			// if mix calling of arguments will be applied to a method...
			// only left side of the expression can be called by order, 
			// and right side of the expression can be called by name 

		}

	}


}
