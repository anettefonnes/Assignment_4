using System;
using System.Collections;
using SpaceSim;

class Astronomy{

	public static void Main(){
	
		ArrayList a = new ArrayList();
		
		a.Add(new Star("Sol"));
		a.Add(new Planet("Mercury"));
		a.Add(new Planet("Venus"));
		a.Add(new Planet("Terra"));
		a.Add(new Moon("Luna"));
		
		for(int i = 0; i < a.Count; i++){
			SpaceObject obj = (SpaceObject)(a[i]);
			obj.Draw();
		}
		
		Console.ReadLine();
		
	}
	
}