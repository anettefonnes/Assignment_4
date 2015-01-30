using System;

namespace SpaceSim{
	
	public struct Point{ 
		int x = 0;
		int y = 0;
	}
	
		
	public class SpaceObject{
		
		//Protected Variables
		protected String name;
		protected double radius_orbital;
		protected double period_orbital;
		protected double radius_object;
		protected double period_rotational;
		protected string color;

		protected void setOrbitalRadius(double = 10);
		protected void setOrbitalPeriod(double = 10);
		protected void setRotationalPeriod(double = 10);
		protected void setObjectRadius(double = 10);
		protected void setName(string = "Unknown");		
		
		
		//Public Variables
		public double getOrbitalRadius();
		public double getOrbitalPeriod();
		public double getRotationalPeriod();
		public double getObjectRadius();
		public string getName();
	

		//Constructors
		public SpaceObject(String _name){
			name = _name;
		}
		
		//Public Methods
		/*This Method Writes the name out to Console*/
		public virtual void Draw(){
			Console.WriteLine(name);
		}
	
		/* This method calculates the Space Objects  position */
		public virtual Point findPosition(int time = 0);{
			(getOrbitalRadius() * 2 * Math.PI)*getOrbitalPeriod 
		}
		
	}


	public class Star : SpaceObject{

		public Star(String _name): base(_name){}

		public override void Draw(){
			Console.Write("Star : ");
			base.Draw();
		}
	
	}

	public class Planet : SpaceObject{
	
		public Planet(String _name):base(_name){}
	
		public override void Draw(){
			Console.Write("Planet: ");
			base.Draw();
		}
	
	}
	
	public class Moon : SpaceObject{
		
		public Moon(String _name):base(_name){}
		
		public override void Draw() {
			
			Console.Write("Moon : ");
			base.Draw();
			
		}
	
	}
	
	public class Comet : SpaceObject{
	
		public Comet(String _name):base(_name){}
		
		public override void Draw() {
			Console.Write("Comet: ");
			base.Draw();
		
		}
		
	}
	
	public class Asteroid : SpaceObject{
		
		public Asteroid(String _name):base(_name){}
		
		public override void Draw() {
			Console.Write("Asteroid : ");
			base.Draw();
		
		}
	}
	
	public class AsteroidBelt : SpaceObject{
		
		public AsteroidBelt(String _name):base(_name){}
		
		public override void Draw() {
			Console.Write("Asteroid Belt: ");
			base.Draw();
		
		}
		
	}
	
	public class DwarfPlanet : SpaceObject{
		
		public DwarfPlanet(String _name):base(_name){}
		
		public override void Draw() {
			Console.Write("Dwarf Planet: ");
			base.Draw();
		
		}
		
	}
	
}