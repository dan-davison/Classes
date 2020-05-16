using System;

namespace Classes_Task_1_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiate a new Cookie
            //Cookie 1
            Colour C1 = new Colour(0, 128, 255);
            Cookie ck1 = new Cookie (100,"Round", C1);
            System.Console.WriteLine("Cookie 1");
            System.Console.WriteLine("Weight: " + ck1.Weight + ", Shape: " + ck1.Shape + ", Colour: " + "Red:" + C1.Red + " Green:" + C1.Green + " Blue:" + C1.Blue);

            System.Console.WriteLine();

            //Cookie 2
            Colour C2 = new Colour(0, 128, 255);
            Cookie ck2 = new Cookie (120,"Sqaure", C2);
            System.Console.WriteLine("Cookie 2");
            System.Console.WriteLine("Weight: " + ck2.Weight + ", Shape: " + ck2.Shape + ", Colour: " + "Red:" + C2.Red + " Green:" + C2.Green + " Blue:" + C2.Blue);

            System.Console.WriteLine();

            //Cookie 3
            Colour C3 = new Colour(255, 51, 51);
            Cookie ck3 = new Cookie (150,"Round", C3);
            System.Console.WriteLine("Cookie 3");
            System.Console.WriteLine("Weight: " + ck3.Weight + ", Shape: " + ck3.Shape + ", Colour: " + "Red:" + C3.Red + " Green:" + C3.Green + " Blue:" + C3.Blue);

            System.Console.WriteLine();

            //Cookie 4
            Colour C4 = new Colour(255, 51, 51);
            Cookie ck4 = new Cookie (80,"Square", C4);
            System.Console.WriteLine("Cookie 4");
            System.Console.WriteLine("Weight: " + ck4.Weight + ", Shape: " + ck4.Shape + ", Colour: " + "Red:" + C4.Red + " Green:" + C4.Green + " Blue:" + C4.Blue);

            System.Console.WriteLine();

        }
    }

    //---------------------------------------------------------

    class Cookie{
        //atributes
        public int Weight;
        public string Shape;
        public Colour CLR;

        // constructors
        public Cookie() {
         this.Weight = 0;
         this.Shape = "";
         this.CLR = null;
        }
        public Cookie(int weight, string shape, Colour c) {
            this.Weight = weight;
            this.Shape = shape;
            this.CLR = c;
        }
    }

    class Colour{
        public int Red;
        public int Green;
        public int Blue;

        public Colour() {
            this.Red = 0;
            this.Green = 0;
            this.Blue = 0;
        }

        public Colour(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }










}
