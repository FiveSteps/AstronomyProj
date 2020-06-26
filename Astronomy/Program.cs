using System;

namespace Astronomy
{
    class Program
    {
        class SolarSystemPlanet
        {
            private double diameter;
            private string name;


            public double Diameter
            {
                get { return diameter; }
                set
                {
                    if (diameter > 0) diameter = value;
                }
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (name != "") name = value;
                }
            }


            public SolarSystemPlanet() { }

            public SolarSystemPlanet(double Diameter)
            {
                diameter = Diameter;
            }
            
            public SolarSystemPlanet(string Name)
            {
                name = Name;
            }
            
            public SolarSystemPlanet(double Diameter, string Name)
            {
                diameter = Diameter;
                name = Name;
            }


            public void MoveInOrbit()
            {
                Console.WriteLine("Планета " + name + " движется по орбите\n");
            }

            public void izmenenyeImeny(string Name)
            {
                Console.WriteLine("Вы изменили планету на " + Name + "\n");
                name = Name;
            }

            public void izmenenyeDiametra(double Diameter)
            {
                Console.WriteLine("Вы изменили диаметр планеты " + name + " на " + Diameter + "\n");
                diameter = Diameter;
            }
        }

        class Earth : SolarSystemPlanet
        {
            private int positionFromTheSun;
            private bool stillHasWater;


            public int PositionFromTheSun 
            {
                get { return positionFromTheSun; }
                set
                {
                    if (positionFromTheSun == 3) positionFromTheSun = value;
                }
            }

            public bool StillHasWater
            {
                get { return stillHasWater; }
                set
                {
                    if (stillHasWater == true) stillHasWater = value;
                }
            }


            public Earth() { }

            public Earth(int PositionFromTheSun)
            {
                positionFromTheSun = PositionFromTheSun;
            }

            public Earth(bool StillHasWater)
            {
                stillHasWater = StillHasWater;
            }

            public Earth(int PositionFromTheSun, bool StillHasWater)
            {
                positionFromTheSun = PositionFromTheSun;
                stillHasWater = StillHasWater;
            }

            
            public void MakeNewIceAge(bool ch)
            {
                if (ch == true) Console.WriteLine("На земле начался новый ледниковый период\n");
                if (ch == false) Console.WriteLine("Всё тихо и спокойно на Земле, ледниковый период не предвидится\n");
            }

            public void GrowATrees()
            {
                Console.WriteLine("Где-то на туманных берегах вырос небольшой лес, все жители обрадовались такому событию\n");
            }

            public void FloodVillageOnTheShore()
            {
                Console.WriteLine("Деревня на берегу была снесена цунами\n");
            }
        }

        class TheSun
        {
            private double temperature;
            private bool outBreaksInTheSun;


            public double Temperature
            {
                get { return temperature; }
                set
                {
                    if (temperature > 0) temperature = value;
                }
            }

            public bool OutBreaksInTheSun
            {
                get { return outBreaksInTheSun; }
                set
                {
                    if (outBreaksInTheSun == true) outBreaksInTheSun = value;
                }
            }


            public TheSun() { }

            public TheSun(double Temperature)
            {
                temperature = Temperature;
            }

            public TheSun(bool OutBreaksInTheSun)
            {
                outBreaksInTheSun = OutBreaksInTheSun;
            }

            public TheSun(double Temperature, bool OutBreaksInTheSun)
            {
                temperature = Temperature;
                outBreaksInTheSun = OutBreaksInTheSun;
            }


            public void Blow()
            {
                Console.WriteLine("Солнце взорвалось и, кажется, солнечная система долго не протянет\n");
            }

            public void IncreaseTemprature(double temp)
            {
                Console.WriteLine("Температура солнца была увеличена на " + temp + " градусов(по цельсию)\n");
            }

            public void EmitUltravioletLight()
            {
                Console.WriteLine("Солнце излучает ультрафиолет\n");
            }
        }

        static void Main(string[] args)
        {
            SolarSystemPlanet ssp = new SolarSystemPlanet(86000, "Земля");
            Earth abc = new Earth(3, true);
            TheSun sss = new TheSun(5505, true);

            Console.Write("1)");
            ssp.MoveInOrbit();
            Console.Write("2)");
            ssp.izmenenyeImeny("Марс");
            Console.Write("3)");
            ssp.izmenenyeDiametra(53666);

            Console.Write("4)");
            abc.MakeNewIceAge(true);
            Console.Write("5)");
            abc.GrowATrees();
            Console.Write("6)");
            abc.FloodVillageOnTheShore();

            Console.Write("7)");
            sss.Blow();
            Console.Write("8)");
            sss.IncreaseTemprature(1200);
            Console.Write("9)");
            sss.EmitUltravioletLight();
        }
    }
}
