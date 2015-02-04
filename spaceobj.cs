using System;
using System.Drawing;
using System.Collections.Generic;

namespace SpaceSim{
	
		
	public class SpaceObject{
		
		//Protected Variables
		protected SpaceObject pericenter;
        protected List<SpaceObject> apocenters;
		protected string name;
		protected string color;
		protected double radius_orbital;
		protected double period_orbital;
		protected double radius_object;
		protected double period_rotational;

        protected void setPericenter(SpaceObject _pericenter) { pericenter = _pericenter; }
        protected void setApocenter(List<SpaceObject> _apocenter) { apocenters = _apocenter; }
		protected void setOrbitalRadius(double _orbRad = 10) { radius_orbital = _orbRad;}
		protected void setOrbitalPeriod(double _orbPer = 10) { period_orbital = _orbPer; }
		protected void setRotationalPeriod(double _rotPer = 10){ period_rotational = _rotPer; }
		protected void setObjectRadius(double _objRad = 10){ radius_object = _objRad; }
		protected void setName(string _name){ name = _name; }
		protected void setColor(string _color = "Blue") { color = _color; }	
		
		
		//Public Variables
		public double getOrbitalRadius(){ return radius_orbital; }
		public double getOrbitalPeriod(){ return period_orbital; }
		public double getRotationalPeriod(){ return period_rotational; }
		public double getObjectRadius(){ return radius_object; }
		public string getName(){ return name;}
		public string getColor(){ return color;}

	

		//Constructors
		public SpaceObject(String _name = "Unknown Object", string _color = "Blue" , double _rotPer = 10 , double _objRad = 10 , SpaceObject _Obj = null, double _orbRad = 0 , double _orbPer = 0){
			setName(_name); 
            setPericenter(_Obj);
            setColor( _color);
        	setRotationalPeriod( _rotPer );
	        setObjectRadius(_objRad);

            if(pericenter == null){
                _orbPer = 0;
                _orbRad = 0;
            }
            setOrbitalRadius(_orbRad);
            setOrbitalPeriod(_orbPer);
		}

		//Public Methods
		/*This Method Writes the name out to Console*/
		public virtual void Draw(){
            Console.WriteLine(name /* + " ; pos.x = " + pos.X + " , pos.y = " + pos.Y*/);

		}
	
		/* This method calculates the Space Objects  position */
		public virtual Point findPosition(double time = 0){
            
            Point pos = new Point(0,0);
            
			if(pericenter != null){
            
                double rad = time % period_orbital * (2 * Math.PI);

                int x = (int)(Math.Cos(rad) * getOrbitalRadius());
                int y = (int)(Math.Sin(rad) * getOrbitalRadius());
			
                pos.X = x;
                pos.Y = y;
			
            }
			
			return pos;
		}

        public void addApocenter(SpaceObject _apo){
            // add orbital radius VS this.object.radius check -> Throw?Bool?
            apocenters.Add(_apo);
        }
	}


	public class Star : SpaceObject{

        public Star(String _name = "Unknown Object", string _color = "Blue", double _rotPer = 10, double _objRad = 10, SpaceObject _Obj = null, double _orbRad = 0, double _orbPer = 0) : 
            base(_name,_color,_rotPer,_objRad,_Obj,_orbRad,_orbPer) { }

		public override void Draw(){
			Console.Write("Star : ");
			base.Draw();
		}
	
	}

	public class Planet : SpaceObject{

        public Planet(String _name = "Unknown Object", string _color = "Blue", double _rotPer = 10, double _objRad = 10, SpaceObject _Obj = null, double _orbRad = 0, double _orbPer = 0) :
            base(_name, _color, _rotPer, _objRad, _Obj, _orbRad, _orbPer) { }
	
		public override void Draw(){
			Console.Write("Planet: ");
			base.Draw();
		}
	
	}
	
	public class Moon : SpaceObject{

        public Moon(String _name = "Unknown Object", string _color = "Blue", double _rotPer = 10, double _objRad = 10, SpaceObject _Obj = null, double _orbRad = 0, double _orbPer = 0) :
            base(_name, _color, _rotPer, _objRad, _Obj, _orbRad, _orbPer) { }
		
		public override void Draw() {
			
			Console.Write("Moon : ");
			base.Draw();
			
		}
	
	}
	
	public class Comet : SpaceObject{

        public Comet(String _name = "Unknown Object", string _color = "Blue", double _rotPer = 10, double _objRad = 10, SpaceObject _Obj = null, double _orbRad = 0, double _orbPer = 0) :
            base(_name, _color, _rotPer, _objRad, _Obj, _orbRad, _orbPer) { }
		
		public override void Draw() {
			Console.Write("Comet: ");
			base.Draw();
		
		}
		
	}
	
	public class Asteroid : SpaceObject{

        public Asteroid(String _name = "Unknown Object", string _color = "Blue", double _rotPer = 10, double _objRad = 10, SpaceObject _Obj = null, double _orbRad = 0, double _orbPer = 0) :
            base(_name, _color, _rotPer, _objRad, _Obj, _orbRad, _orbPer) { }
		
		public override void Draw() {
			Console.Write("Asteroid : ");
			base.Draw();
		
		}
	}
	
	public class AsteroidBelt : SpaceObject{

        public AsteroidBelt(String _name = "Unknown Object", string _color = "Blue", double _rotPer = 10, double _objRad = 10, SpaceObject _Obj = null, double _orbRad = 0, double _orbPer = 0) :
            base(_name, _color, _rotPer, _objRad, _Obj, _orbRad, _orbPer) { }
		
		public override void Draw() {
			Console.Write("Asteroid Belt: ");
			base.Draw();
		
		}
		
	}
	
	public class DwarfPlanet : SpaceObject{

        public DwarfPlanet(String _name = "Unknown Object", string _color = "Blue", double _rotPer = 10, double _objRad = 10, SpaceObject _Obj = null, double _orbRad = 0, double _orbPer = 0) :
            base(_name, _color, _rotPer, _objRad, _Obj, _orbRad, _orbPer) { }
		
		public override void Draw() {
			Console.Write("Dwarf Planet: ");
			base.Draw();
		
		}
		
	}
	
}