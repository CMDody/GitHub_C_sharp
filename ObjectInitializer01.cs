using System;
using System.Runtime.InteropServices;


namespace Initializers {

	class myClass {

		public int alpha;
		public int beta;
		public string txt;
		//... Only public variables can be initialized...

		public myClass() {
			alpha = 0;
			beta = 0;
			txt = "Empty";
		}

		public void show(string name) {

			Console.WriteLine ("For the object:" + name);
			Console.WriteLine ("================================================");
			Console.WriteLine ("Alpha:{0}, Beta:{1}, Text:{2}", 
				alpha, 
				beta, 
				txt);

			Console.WriteLine ();
		}

	}


	class mainClass {

		static void Main() {

			myClass objA = new myClass ();
			myClass objB = new myClass () {alpha=32, beta=44, txt="This is initialized"};
										// only public variables can be initialized...
			objA.show ("A");
			objB.show ("B");

		}

	}

}
