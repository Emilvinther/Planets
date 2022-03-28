using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class Planet
    {
        private string planetname;
        private double mass;
        private int diameter;
        private int density;
        private double gravity;
        private double rotationperiod;
        private double lengthofdays;
        private double distancefromsun;
        private double obitalperiod;
        private double obitalvelocity;
        private int temperature;
        private int numberofmoons;
        private bool ringsystem = false;

        public string Planetname { get => planetname; set => planetname = value; }
        public double Mass { get => mass; set => mass = value; }
        public int Diameter { get => diameter; set => diameter = value; }
        public int Density { get => density; set => density = value; }
        public double Gravity { get => gravity; set => gravity = value; }
        public double Rotationperiod { get => rotationperiod; set => rotationperiod = value; }
        public double Lengthofdays { get => lengthofdays; set => lengthofdays = value; }
        public double Distancefromsun { get => distancefromsun; set => distancefromsun = value; }
        public double Obitalperiod { get => obitalperiod; set => obitalperiod = value; }
        public double Obitalvelocity { get => obitalvelocity; set => obitalvelocity = value; }
        public int Temperature { get => temperature; set => temperature = value; }
        public int Numberofmoons { get => numberofmoons; set => numberofmoons = value; }
        public bool Ringsystem { get => ringsystem; set => ringsystem = value; }

        public Planet(string planetname, double mass, int diameter, int density, double gravity, double rotationperiod, double lengthofdays, double distancefromsun, double obitalperiod, double obitalvelocity, int temperature, int numberofmoons, bool ringsystem)
        {
            Planetname = planetname;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            Rotationperiod = rotationperiod;
            Lengthofdays = lengthofdays;
            Distancefromsun = distancefromsun;
            Obitalperiod = obitalperiod;
            Obitalvelocity = obitalvelocity;
            Temperature = temperature;
            Numberofmoons = numberofmoons;
            Ringsystem = ringsystem;
        }

        public override string ToString()
        {
            return $"\nPlanet properties\n\n" +
            $"\nPlanet Name = {Planetname}" +
            $"\nPlanet Mass = {Mass}" +
            $"\nPlanet Diameter = {Diameter}" +
            $"\nPlanet Density = {Density}" +
            $"\nPlanet Gravity = {Gravity}" +
            $"\nPlanet Rotation Period = {Rotationperiod}" +
            $"\nPlanet Day Length = {Lengthofdays}" +
            $"\nPlanet Distance from sun = {Distancefromsun}" +
            $"\nPlanet Obital Period = {Obitalperiod}" +
            $"\nPlanet Obital Velocity = {Obitalvelocity}" +
            $"\nPlanets Medi Temperature = {Temperature}" +
            $"\nNumber of moons orbiting the planet {Numberofmoons}" +
            $"\nDoes it have a ringsystem {(Ringsystem == true ? "Yes" : "No")}";
        }
    }
}
