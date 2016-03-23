using System;

class Halloween {

	static void Main() {
	
		String[] txt = {"Hello", 
		"C", 
		"Sharp", 
		"World"};

		int i = 0;

		foreach (String u in txt) {
			i++;
			Console.WriteLine (i + " ---> " + u);
		}

	}

}
