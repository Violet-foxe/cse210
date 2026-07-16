using System;

class Program
{
	static void Main(string[] args)
	{
		// Console.WriteLine("Hello FinalProject World!");
		Console.Clear();

		// List<FlatShapes> myShapes = new List<FlatShapes>();

		// myShapes.Add(new Circle());
		// myShapes.Add(new Circle(2, "red")); //done

		// myShapes.Add(new Triangle());
		// myShapes.Add(new Triangle(2, 4, 4, "orange")); //done
		// myShapes.Add(new Triangle(2, 3, 6, "dark orange")); // -- doesn't work
		// myShapes.Add(new RightTriangle());
		// myShapes.Add(new RightTriangle(6, 8, "yellow")); //done
		// myShapes.Add(new RightTriangle(6, -1, "dark yellow")); //done
		// myShapes.Add(new IsoTriangle());
		// myShapes.Add(new IsoTriangle("chartruese", 2, 3)); //done
		// myShapes.Add(new IsoTriangle("dark chartruese", 2, -1)); //done
		// myShapes.Add(new IsoTriangle(2, 3, "green")); //done
		// myShapes.Add(new IsoTriangle(-1, 3, "dark green")); //done
		// myShapes.Add(new EqualTriangle());
		// myShapes.Add(new EqualTriangle(3, "sea green")); //done
		// myShapes.Add(new EqualTriangle(-3, "sea green")); //done

		// myShapes.Add(new Trapezoid());
		// myShapes.Add(new Trapezoid(3, 2, 4, 2, "cyan")); //done
		// myShapes.Add(new Trapezoid(3, 20, 14, 2, "dark cyan")); // -- dosn't work
		// myShapes.Add(new Trapezoid(2, 4, 3, "sky blue")); //done
		// myShapes.Add(new Trapezoid(-2, -4, 3, "dark sky blue")); //done
		// myShapes.Add(new Rectangle());
		// myShapes.Add(new Rectangle(3, 2.5, "blue")); //done
		// myShapes.Add(new Rectangle(-3, 2.5, "dark blue")); //done
		// myShapes.Add(new Parallelogram());
		// myShapes.Add(new Parallelogram(4, 2, 60, "purple")); //done
		// myShapes.Add(new Parallelogram(4, 2, 60, "dark purple")); //done
		// myShapes.Add(new Parallelogram(-3, -3, "violet")); //done
		// myShapes.Add(new Parallelogram(-3, -3, "dark violet")); //done
		// myShapes.Add(new Square());
		// myShapes.Add(new Square(5, "magenta"));//done
		// myShapes.Add(new Square(-5, "dark magenta"));//done
		// myShapes.Add(new Rhombus());
		// myShapes.Add(new Rhombus(4, 70, "pink")); //done
		// myShapes.Add(new Rhombus(4, 120, "dark pink")); //done
		// myShapes.Add(new Rhombus("scarlet", 3, 2)); //done
		// myShapes.Add(new Rhombus("dark scarlet", -3, -2)); //done

		ShapeList shapeList = new ShapeList();

		bool choosing = true;
		do
		{
			// menu 
			// -make shape
			// -display list of shapes
			// -save shapes
			// -load shapes 
			Console.WriteLine();
			Console.WriteLine("1. Create a Shape \n2. List Shapes \n3. Save Shapes \n4. Load Shapes\n5. Quit");
			Console.Write("What do? ");
			int answer = int.Parse(Console.ReadLine());

			Console.WriteLine();
			if (answer == 1) //Create shape
			{
				shapeList.AddShape();
			}
			else if (answer == 2) //List Shapes
			{
				shapeList.DisplayShapes();
			}
			else if (answer == 3) //Save Shapes
			{
				Console.Write("Save to what file? ");
				string filename = Console.ReadLine();
				shapeList.SaveList(filename);
			}
			else if (answer == 4) //Load Shapes
			{
				Console.Write("Load from what file? ");
				string filename = Console.ReadLine();
				shapeList.LoadList(filename);
			}
			else //Quit
			{
				choosing = false;
			}
		} while (choosing == true);
	}
}