using System;

namespace SpaceSim{
	
	public struct Point{ 
		public int x;
		public int y;
	}
	
		
	public class SpaceObject{
		
		//Protected Variables
		protected string name;
		protected double radius_orbital;
		protected double period_orbital;
		protected double radius_object;
		protected double period_rotational;
		protected string color;

		protected void setOrbitalRadius(double _orbRad = 10) { radius_orbital = _orbRad;}
		protected void setOrbitalPeriod(double _orbPer = 10) { period_orbital = _orbPer; }
		protected void setRotationalPeriod(double _rotPer = 10){ period_rotational = _rotPer; }
		protected void setObjectRadius(double _objRad = 10){ radius_object = _objRad; }
		protected void setName(string _name = "Unknown"){ name = _name; }
		protected void setColor(string _color = "Blue") { color = _color; }	
		
		
		//Public Variables
		public double getOrbitalRadius(){ return radius_orbital; }
		public double getOrbitalPeriod(){ return period_orbital; }
		public double getRotationalPeriod(){ return period_rotational; }
		public double getObjectRadius(){ return radius_object; }
		public string getName(){ return name;}
		public string getColor(){ return color;}
	

		//Constructors
		public SpaceObject(String _name){
			name = _name;
		}
		
		//Public Methods
		/*This Method Writes the name out to Console*/
		public virtual void Draw(){
			Console.WriteLine(name);
		}
	
		/* This method calculates the Space Objects  position 
		public virtual Point findPosition(int time = 0);{
			(getOrbitalRadius() * 2 * Math.PI)*getOrbitalPeriod 
		}*/
		
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