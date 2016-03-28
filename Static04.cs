using System;

namespace StaticDemo {

	class myClass {

		static int i;
		int j;

		static myClass() {  // static yapılandıcı hiç bir değer almaz ve değer döndürmez.

			i = 32;  // static bir yapılandırıcı sadece static değişkenlere atama yapabilir.
			Console.WriteLine ("Static construction done!");

			// static yapılandırıcı hiçbir zaman çağrılmaz 
			// ancak tüm yapılandırıcılardan önce static yapılandırıcı kendiliğinden çağrılır.
		}

		public myClass(int j) { // Normal yapılandırıcı
			this.j = j;
			Console.WriteLine ("Instence construction done!");
		}

		public void show() {
			Console.WriteLine ("Values are i={0}, j={1} ", i, j);
		}

	}

	class mainClass {

		static void Main() {

			myClass obj = new myClass (88);
			obj.show ();

		}

	}

}
