using System;

namespace Demo {

	class Stack {

		string[] stck;
		int size;
		int capacity;

		//.....

		public Stack(int capacity) {  // Constructor;
			this.capacity = capacity;
			size = 0;
			stck = new string[capacity];
		}

		public Stack() {   // Constructor with default size
			this.capacity = 4;
			this.size = 0;
			stck = new string[capacity];
		}

		//__________________________

		public int getCapacity() {
			return capacity;
		}

		public int getSize() {
			return size;
		}

		public double getCapacityRatio() {
			
			double capacityRatio;

			capacityRatio = (((double) size) / ((double) capacity));
			capacityRatio *= 100;

			return capacityRatio;

		}

		public bool hasMoreVolume() {
			return (capacity>size);
		}

		public bool isEmpty() {
			return ((size==0) ? true : false);
		}

		//__________________________

		public void push(string data) {

			if (hasMoreVolume ()) {
				stck [size] = data;
				size++;
			} 
			else {
				expandVolume ();
				push (data);      // recursion...
			}
		}

		public string pop() {

			string val = "[ Stack is EMPTY! ]";

			if (size > 0) {
				size--;
				val = stck [size];
			}

			return val;

		}

		//__________________________

		private void expandVolume() {

			int oldCapacity = this.capacity;
			int nextCapacity = oldCapacity * 2;

			string[] tmp = new string[oldCapacity];

			for (int i = 0; i < oldCapacity; i++) {
				tmp [i] = stck [i];                 // Copy data to temprory variable 
			}

			stck = new string[nextCapacity];

			for (int i = 0; i < oldCapacity; i++) {
				stck [i] = tmp [i];
			}

			this.capacity = nextCapacity;

		}

	}

	//=============================================================================================

	class StackDemo {

		static void Main() {

			Stack u = new Stack ();

			Console.WriteLine ("Initial state ---> Size:{0}, Capacity:{1}, Capacity Ratio:{2, 2}% ", 
				u.getSize (), 
				u.getCapacity (), 
				u.getCapacityRatio ());

			u.push ("Inci");
			u.push ("Ayben");
			u.push ("Nihal");
			u.push ("Murat");
			u.push ("Burak");

			Console.WriteLine ("After pushing some data --->Size:{0}, Capacity:{1}, Capacity Ratio:{2, 2}% ", 
				u.getSize (), 
				u.getCapacity (), 
				u.getCapacityRatio ());


			u.push ("Gonul");
			u.push ("Guner");
			u.push ("Cem");
			u.push ("Hasan");
			u.push ("Bahar");
			u.push ("Cemil");
			u.push ("Nil");
			u.push ("John");
			u.push ("Mike");
			u.push ("Ron");
			u.push ("Rok");
			u.push ("David");
			u.push ("Phillipe");
			u.push ("Murat");
			u.push ("Coco");
			u.push ("Napoleon");
			u.push ("Katja");
			u.push ("Montesque");
			u.push ("Descartes");
			u.push ("Carnot");

			Console.WriteLine ("After pushing all data --->Size:{0}, Capacity:{1}, Capacity Ratio:{2, 2}% ", 
				u.getSize (), 
				u.getCapacity (), 
				u.getCapacityRatio ());

			for (int j = 0; j < 6; j++) {
				Console.WriteLine (u.pop ());
			}

			Console.WriteLine ("After poping 6 datas --->Size:{0}, Capacity:{1}, Capacity Ratio:{2, 2}% ", 
				u.getSize (), 
				u.getCapacity (), 
				u.getCapacityRatio ());

			for (int j = 0; j < 6; j++) {
				Console.WriteLine (u.pop ());
			}

			Console.WriteLine ("After poping 6 more datas --->Size:{0}, Capacity:{1}, Capacity Ratio:{2, 2}% ", 
				u.getSize (), 
				u.getCapacity (), 
				u.getCapacityRatio ());
			



			while (!u.isEmpty ()) {
				Console.WriteLine (u.pop ());
			}

			Console.WriteLine (u.pop ());

			Console.WriteLine ("Final State ---> Size:{0}, Capacity:{1}, Capacity Ratio:{2, 2}% ", 
				u.getSize (), 
				u.getCapacity (), 
				u.getCapacityRatio ());


		}

	}

}
