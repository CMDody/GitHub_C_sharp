using System;

namespace refCall {

	class myClass {

		int alpha, beta;

		public myClass(int alpha, int beta) {
			this.alpha = alpha;
			this.beta = beta;
		}

		public bool isSame(myClass ob) {
			if ((ob.alpha == this.alpha) && (ob.beta == this.beta))
				return true;
			else
				return false;
		}

		public void copy(myClass ob) {
			this.alpha = ob.alpha;
			this.beta = ob.beta;
		}

		public void show() {
			Console.WriteLine ("Alpha:{0}, Beta={1}", alpha, beta);
		}

	}

	//==================

	class PassObject {


		static void Main() {

			myClass ob1 = new myClass (10, 30);
			myClass ob2 = new myClass (44, 77);

			Console.Write ("Object 1:");
			ob1.show ();

			Console.Write ("Object 2:");
			ob2.show ();

			if (ob1.isSame (ob2))
				Console.WriteLine ("Object 1 and Object 2 are same.");
			else
				Console.WriteLine ("Object 1 and Object 2 are different");


			Console.WriteLine ();

			ob1.copy (ob2);


			Console.Write ("Object 1:");
			ob1.show ();

			Console.Write ("Object 2:");
			ob2.show ();

			if (ob1.isSame (ob2))
				Console.WriteLine ("Object 1 and Object 2 are same.");
			else
				Console.WriteLine ("Object 1 and Object 2 are different");
			


		}
	}

}
