using System;

namespace staticDemo {

	class myClass {

		static int count = 0;
		static bool destruction = false;

		//....

		public myClass() {  // Constructor...
			count++;
		}

		public void showValue() {
			Console.WriteLine ("Value: " + count);
		}

		public bool getDestructionStatus() {
			return destruction;
		}

		~myClass() { // Destructor...
			count--;
			Console.WriteLine ("Destructing........... ");
			destruction = true;
		}
			
	}

	//============================================

	class mainClass {

		static void Main() {

			myClass obj;

			do {

				obj = new myClass ();
				obj.showValue ();

			} while(!obj.getDestructionStatus ());
			// Continue cycling the until garbage collector starts to release reserved memory addresses

		}

	}


}
