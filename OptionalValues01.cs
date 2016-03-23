using System;

namespace OptionalValues {

class defOptVal {

  public void show(int alpha, int beta = 21, int gamma = 32, string name = "Halloween") {
    Console.WriteLine("Alpha:{0}, Beta:{1}, Gamma:{2}, Name:{3}",
      alpha,
      beta,
      gamma,
      name);
  }


}

class mainClass {

  static void Main() {
      defOptVal obj = new defOptVal();

      obj.show(12);     // 'beta', 'gamma' and 'name' variables are optional default value
      obj.show(12, 23);     // 'gamma' and 'name' variables are optional default value
      obj.show(23, 34, 45);   // 'name' variable is optional default value
      obj.show(34, 45, 56, "CMDody");   // all variables are determined...
      

  }

}


}
