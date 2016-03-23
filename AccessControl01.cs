using System;

namespace ObjAccessControlDemo {

	class myClass {

		private int Alpha;
		int Beta;           // by default this is same as ---> private int Beta;
		public int Delta;

		//.....

		public myClass() {  // Constructor;
			Alpha = 0;
			Beta = 0;
			Delta = 0;
		}

		public myClass(int Alpha, int Beta, int Delta) {  // Constructor;
			this.Alpha = Alpha;
			this.Beta = Beta;
			this.Delta = Delta;
		}

		//________________________________

		public void setAlpha(int Alpha) {
			this.Alpha = Alpha;
		}

		public int getAlpha() {
			return Alpha;
		}

		//________________________________

		public void setBeta(int Beta) {
			this.Beta = Beta;
		}

		public int getBeta() {
			return Beta;
		}

		//________________________________

		// No need to define getter and setter methods for Delta 
		// Because Delta is already public


	}

	class AccessDemo {

		static void Main() {

			myClass obA = new myClass ();
			myClass obB = new myClass (10, 20, 30);
			myClass obC = obB;

			obA.setAlpha (43);
			obA.setBeta (32);
			obA.Delta = 21;

			Console.WriteLine ("Object A ---> " +
				"Alpha={0}, " +
				"Beta={1}, " +
				"Delta={2} ", obA.getAlpha (), obA.getBeta (), obA.Delta);


			Console.WriteLine ("Object B ---> " +
				"Alpha={0}, " +
				"Beta={1}, " +
				"Delta={2} ", obB.getAlpha (), obB.getBeta (), obB.Delta);

			Console.WriteLine ("Object C ---> " +
				"Alpha={0}, " +
				"Beta={1}, " +
				"Delta={2} ", obC.getAlpha (), obC.getBeta (), obC.Delta);

			Console.WriteLine ("\nAfter changing the values of Object C");
			

			obC.setAlpha (31);
			obC.setBeta (42);
			obC.Delta = 53;


			Console.WriteLine ("Object B ---> " +
				"Alpha={0}, " +
				"Beta={1}, " +
				"Delta={2} ", obB.getAlpha (), obB.getBeta (), obB.Delta);

			Console.WriteLine ("Object C ---> " +
				"Alpha={0}, " +
				"Beta={1}, " +
				"Delta={2} ", obC.getAlpha (), obC.getBeta (), obC.Delta);
			



		}

	}


}
