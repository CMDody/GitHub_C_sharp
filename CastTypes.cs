using System;
using System.Runtime.InteropServices;

namespace CastingDataTypes {

	class caster {

		static void Main() {
		
			int a;
			long b;
			short c;
			double d;
			decimal e;
			float f;
			byte u;

			e = 22.4m;
			f = 832.77F;

			d = ((double) e) / ((double) f);

			Console.WriteLine ("Double: {0}, Float:{1} , Decimal:{2}", d, f, e);

			a = (int)f;
			b = 27613990726;
			c = (short)b;
			u = (byte)c;

			Console.WriteLine ("Integer:{0}, Long:{1}, Short:{2}, byte:{3}", a, b, c, u);

			Console.WriteLine ("Casting Decimal To Integer: {0}", (int) e);
			Console.WriteLine ("Casting Float to Short: {0}", (short) f);

			Console.WriteLine ("Square root of {0} is ---> {1} ", d, Math.Sqrt (d));
			Console.WriteLine ("Casting result in place {0, 3:C}", (decimal) Math.Sqrt (f));


		}

	}

}
