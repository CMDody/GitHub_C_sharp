using System;

namespace TextDemo {

	class Text {

		static void Main() {

			char[] array = {'C', 'e', 'm', 'i', 'l', ' ',  
			'M', 'u', 'r', 'a', 't', ' ', 'D', 'O', 'D', 'A', 'N', 'L', 'I'};

			string str1 = new string (array);
			string str2 = "This is a test text for this program.";

			Console.WriteLine (str1);
			Console.WriteLine (str2);

			Console.WriteLine (str1.Substring (6));     // 6 karakterden sonraki kısmı sonuna kadar al
			Console.WriteLine (str1.Substring (6, 5));  // 6 karakterden sonraki 5 karakteri al

			Console.WriteLine (str2.ToUpper ());
			Console.WriteLine (str1.ToLower ());

			Console.WriteLine ("Size of the first string:  " + str1.Length);
			Console.WriteLine ("Size of the second string: " + str2.Length);

		}

	}

}
