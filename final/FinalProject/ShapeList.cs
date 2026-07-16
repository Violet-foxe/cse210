public class ShapeList
{
	private List<FlatShapes> _shapes = new();
	private bool _saved;
	private bool _loaded;

	public ShapeList()
	{
		_saved = false;
		_loaded = false;
	}

	public void SaveList(string filename)
	{
		FileInfo fileInfo = new FileInfo(filename);
		// if loaded or starting with nothing in the file
		if (_loaded || fileInfo.Length == 0)
		{
			using (StreamWriter outputFile = new StreamWriter(filename))
			{
				// lines are a shape
				foreach (FlatShapes shape in _shapes)
				{
					string saveString = shape.GetSaveString();
					outputFile.WriteLine(saveString);
				}
			}
		}

		// if not loaded (adds onto the end)
		else if (!_loaded)
		{
			using (StreamWriter outputFile = new StreamWriter(filename, append: true))
			{
				// lines are the shapes added to the end
				foreach (FlatShapes shape in _shapes)
				{
					string saveString = shape.GetSaveString();
					outputFile.WriteLine(saveString);
				}
			}
		}

		// saved is now true
		_saved = true;
	}
	public void LoadList(string filename)
	{
		// if not saved, then save
		if (!_saved)
		{
			SaveList(filename);
		}

		// blank the shape list to make sure it doesn't dublicate shapes from a previous load
		_shapes.Clear();

		// just get the whole list
		string[] lines = System.IO.File.ReadAllLines(filename);

		foreach (string line in lines)
		{
			string[] parts = line.Split("|");

			string shape = parts[0];
			string info = parts[1];

			if (shape == "Circle")
			{
				string[] sParts = info.Split(",");
				double radius = double.Parse(sParts[0]);
				string color = sParts[1];

				FlatShapes triangle = new Circle(radius, color);
				_shapes.Add(triangle);
			}
			else if (shape == "Triangle")
			{
				string[] sParts = info.Split(",");
				double sideA = double.Parse(sParts[0]);
				double sideB = double.Parse(sParts[1]);
				double sideC = double.Parse(sParts[2]);
				string color = sParts[3];

				FlatShapes triangle = new Triangle(sideA, sideB, sideC, color);
				_shapes.Add(triangle);
			}
			else if (shape == "RightTriangle")
			{
				string[] sParts = info.Split(",");
				double sideA = double.Parse(sParts[0]);
				double sideB = double.Parse(sParts[1]);
				string color = sParts[2];

				FlatShapes triangle = new RightTriangle(sideA, sideB, color);
				_shapes.Add(triangle);
			}
			else if (shape == "IsoTriangle")
			{
				string[] sParts = info.Split(",");
				double side = double.Parse(sParts[0]);
				double height = double.Parse(sParts[1]);
				string color = sParts[2];

				FlatShapes triangle = new IsoTriangle(side, height, color);
				_shapes.Add(triangle);
			}
			else if (shape == "EqualTriangle")
			{
				string[] sParts = info.Split(",");
				double sides = double.Parse(sParts[0]);
				string color = sParts[1];

				FlatShapes triangle = new EqualTriangle(sides, color);
				_shapes.Add(triangle);
			}
			else if (shape == "Trapezoid")
			{
				string[] sParts = info.Split(",");
				double sideA = double.Parse(sParts[0]);
				double sideB = double.Parse(sParts[1]);
				double sideC = double.Parse(sParts[2]);
				double sideD = double.Parse(sParts[3]);
				string color = sParts[5];

				FlatShapes trapezoid = new Trapezoid(sideA, sideB, sideC, sideD, color);
				_shapes.Add(trapezoid);
			}
			else if (shape == "Rectangle")
			{
				string[] sParts = info.Split(",");
				double length = double.Parse(sParts[0]);
				double width = double.Parse(sParts[1]);
				string color = sParts[2];

				FlatShapes trapezoid = new Rectangle(length, width, color);
				_shapes.Add(trapezoid);
			}
			else if (shape == "Parallelogram")
			{
				string[] sParts = info.Split(",");
				double sideA = double.Parse(sParts[0]);
				double sideB = double.Parse(sParts[1]);
				double angle = double.Parse(sParts[2]);
				string color = sParts[3];

				FlatShapes trapezoid = new Parallelogram(sideA, sideB, angle, color);
				_shapes.Add(trapezoid);
			}
			else if (shape == "Square")
			{
				string[] sParts = info.Split(",");
				double sides = double.Parse(sParts[0]);
				string color = sParts[1];

				FlatShapes trapezoid = new Square(sides, color);
				_shapes.Add(trapezoid);
			}
			else if (shape == "Rhombus")
			{
				string[] sParts = info.Split(",");
				string color = sParts[0];
				double sides = double.Parse(sParts[1]);
				double height = double.Parse(sParts[2]);

				FlatShapes trapezoid = new Rhombus(color, sides, height);
				_shapes.Add(trapezoid);
			}
			else { Console.WriteLine($"Error in shape type {shape}"); }
		}

		// it is now loaded
		_loaded = true;
	}
	public void AddShape()
	{
		Console.Clear();

		// choose kind of shape to make
		Console.WriteLine("Basic Shapes:");
		Console.WriteLine("1. Triangle \n2. Quadrilateral \n3. Circle");

		bool choosingBaseShape = true;
		do
		{
			Console.Write("Choose shape: ");
			int baseShape = int.Parse(Console.ReadLine());
			Console.WriteLine();

			if (baseShape == 1)
			{
				// choose which triangle
				Console.WriteLine("Triangles:");
				Console.WriteLine("1. Generic Triangle \n2. Right Triangle \n3. Isoceles Triangle \n4. Equalateral Triangle");
				bool choosingTriangle = true;
				do
				{
					Console.Write("Choose Triangle: ");
					int chosen = int.Parse(Console.ReadLine());
					Console.WriteLine();

					if (chosen == 1) //generic
					{
						Console.Write("Length of side 1: ");
						double sideA = double.Parse(Console.ReadLine());
						Console.Write("Length of side 2: ");
						double sideB = double.Parse(Console.ReadLine());
						Console.Write("Length of side 3: ");
						double sideC = double.Parse(Console.ReadLine());

						Console.Write("Color of Triangle: ");
						string color = Console.ReadLine();

						FlatShapes triangle = new Triangle(sideA, sideB, sideC, color);
						Console.WriteLine(triangle.DisplayInfo());
_shapes.Add(triangle);

						choosingTriangle = false;
					}
					else if (chosen == 2) //right
					{
						Console.Write("Length of side A: ");
						double sideA = double.Parse(Console.ReadLine());
						Console.Write("Length of side B: ");
						double sideB = double.Parse(Console.ReadLine());

						Console.Write("Color of Triangle: ");
						string color = Console.ReadLine();

						FlatShapes rTriangle = new RightTriangle(sideA, sideB, color);
						Console.WriteLine(rTriangle.DisplayInfo());
						_shapes.Add(rTriangle);

						choosingTriangle = false;
					}
					else if (chosen == 3) //isosolese
					{
						Console.Write("Create Isoceles Triangle using \n1. Base and Height? \n or \n2. Side lengths?\n");
						int isoChoice = int.Parse(Console.ReadLine());

						bool isoChoosing = true;
						do
						{
							if (isoChoice == 1)
							{
								Console.Write("Length of Base: ");
								double baseS = double.Parse(Console.ReadLine());
								Console.Write("Length of Height: ");
								double height = double.Parse(Console.ReadLine());

								Console.Write("Color of Triangle: ");
								string color = Console.ReadLine();

								FlatShapes iTriangle = new IsoTriangle(baseS, height, color);
								Console.WriteLine(iTriangle.DisplayInfo());
								_shapes.Add(iTriangle);

								isoChoosing = false;
							}
							else if (isoChoice == 2)
							{

								Console.Write("Length of Base side: ");
								double baseS = double.Parse(Console.ReadLine());
								Console.Write("Length of Side: ");
								double side = double.Parse(Console.ReadLine());

								Console.Write("Color of Triangle: ");
								string color = Console.ReadLine();

								FlatShapes iTriangle = new IsoTriangle(color, baseS, side);
								Console.WriteLine(iTriangle.DisplayInfo());
								_shapes.Add(iTriangle);

								isoChoosing = false;
							}
							else { isoChoosing = true; }
						} while (isoChoosing == true);
						choosingTriangle = false;
					}
					else if (chosen == 4) //equalateral
					{
						Console.Write("Length of sides: ");
						double sides = double.Parse(Console.ReadLine());

						Console.Write("Color of Triangle: ");
						string color = Console.ReadLine();

						FlatShapes eTriangle = new EqualTriangle(sides, color);
						Console.WriteLine(eTriangle.DisplayInfo());
						_shapes.Add(eTriangle);

						choosingTriangle = false;
					}
					else
					{
						choosingTriangle = true;
					}
				} while (choosingTriangle == true);
				choosingBaseShape = false;
			}
			else if (baseShape == 2)
			{
				// choose which quadrilateral
				Console.WriteLine("Quadtrilaterals:");
				Console.WriteLine("1. Trapezoid \n2. Parallelogram \n3. Rhombus \n4. Rectangle \n5. Square");
				bool choosingQuad = true;
				do
				{
					Console.Write("Choose Quadrilateral: ");
					int chosen = int.Parse(Console.ReadLine());

					if (chosen == 1) //trapezoid
					{
						Console.Write("Create Trapezoid using \n1. All side lengths?\n or \n2. Top, Bottom and Height?\n");
						int trapChoice = int.Parse(Console.ReadLine());

						bool trapChoosing = true;
						do
						{
							if (trapChoice == 1)
							{
								Console.Write("Length of Bottom: ");
								double sideC = double.Parse(Console.ReadLine());
								Console.Write("Length of Top: ");
								double sideA = double.Parse(Console.ReadLine());
								Console.Write("Length of Right Side: ");
								double sideB = double.Parse(Console.ReadLine());
								Console.Write("Length of Left Side: ");
								double sideD = double.Parse(Console.ReadLine());

								Console.Write("Color of Trapezoid: ");
								string color = Console.ReadLine();

								FlatShapes trap = new Trapezoid(sideA, sideB, sideC, sideD, color);
								Console.WriteLine(trap.DisplayInfo());
								_shapes.Add(trap);

								trapChoosing = false;
							}
							else if (trapChoice == 2)
							{
								Console.Write("Length of Bottom: ");
								double bottom = double.Parse(Console.ReadLine());
								Console.Write("Length of Top: ");
								double top = double.Parse(Console.ReadLine());
								Console.Write("Length of height: ");
								double height = double.Parse(Console.ReadLine());

								Console.Write("Color of Trapezoid: ");
								string color = Console.ReadLine();

								FlatShapes trap = new Trapezoid(top, bottom, height, color);
								Console.WriteLine(trap.DisplayInfo());
								_shapes.Add(trap);

								trapChoosing = false;
							}
							else { trapChoosing = true; }
						} while (trapChoosing == true);
						choosingQuad = false;
					}
					else if (chosen == 2) //parallelogram
					{
						Console.Write("Create Parallelogram using \n1. Side lengths and an Angle? \n or \n2. Base and Height?\n");
						int paraChoice = int.Parse(Console.ReadLine());

						bool paraChoosing = true;
						do
						{
							if (paraChoice == 1)
							{
								Console.Write("Length of Side 1: ");
								double horizontal = double.Parse(Console.ReadLine());
								Console.Write("Length of Side 2: ");
								double vertical = double.Parse(Console.ReadLine());
								Console.Write("Angle in Degrees: ");
								double angle = double.Parse(Console.ReadLine());

								Console.Write("Color of Parallelogram: ");
								string color = Console.ReadLine();

								FlatShapes para = new Parallelogram(horizontal, vertical, angle, color);
								Console.WriteLine(para.DisplayInfo());
								_shapes.Add(para);

								paraChoosing = false;
							}
							else if (paraChoice == 2)
							{
								Console.Write("Length of Bottom: ");
								double bottom = double.Parse(Console.ReadLine());
								Console.Write("Length of Top: ");
								double top = double.Parse(Console.ReadLine());
								Console.Write("Length of height: ");
								double height = double.Parse(Console.ReadLine());

								Console.Write("Color of Parallelogram: ");
								string color = Console.ReadLine();

								FlatShapes para = new Parallelogram(top, bottom, height, color);
								Console.WriteLine(para.DisplayInfo());
								_shapes.Add(para);

								paraChoosing = false;
							}
							else { paraChoosing = true; }
						} while (paraChoosing == true);
						choosingQuad = false;
					}
					else if (chosen == 3) //rhombus
					{
						Console.Write("Create Rhombus using \n1. Side length and Angle? \n or \n2. Base and Height?\n");
						int rhomChoice = int.Parse(Console.ReadLine());

						bool rhomChoosing = true;
						do
						{
							if (rhomChoice == 1)
							{
								Console.Write("Length of Sides: ");
								double sides = double.Parse(Console.ReadLine());
								Console.Write("Angle in Degrees: ");
								double angle = double.Parse(Console.ReadLine());

								Console.Write("Color of Rhombus: ");
								string color = Console.ReadLine();

								FlatShapes rhom = new Rhombus(sides, angle, color);
								Console.WriteLine(rhom.DisplayInfo());
								_shapes.Add(rhom);

								rhomChoosing = false;
							}
							else if (rhomChoice == 2)
							{
								Console.Write("Length of Base: ");
								double sides = double.Parse(Console.ReadLine());
								Console.Write("Length of height: ");
								double height = double.Parse(Console.ReadLine());

								Console.Write("Color of Rhombus: ");
								string color = Console.ReadLine();

								FlatShapes rhom = new Rhombus(color, sides, height);
								Console.WriteLine(rhom.DisplayInfo());
								_shapes.Add(rhom);

								rhomChoosing = false;
							}
							else { rhomChoosing = true; }
						} while (rhomChoosing == true);
						choosingQuad = false;
					}
					else if (chosen == 4) //rectangle
					{
						Console.Write("Length: ");
						double length = double.Parse(Console.ReadLine());
						Console.Write("Width: ");
						double width = double.Parse(Console.ReadLine());

						Console.Write("Color of Rectangle: ");
						string color = Console.ReadLine();

						FlatShapes rect = new Rectangle(length, width, color);
						Console.WriteLine(rect.DisplayInfo());
						_shapes.Add(rect);

						choosingQuad = false;
					}
					else if (chosen == 5) //square
					{
						Console.Write("Length of Sides: ");
						double sides = double.Parse(Console.ReadLine());

						Console.Write("Color of Square: ");
						string color = Console.ReadLine();

						FlatShapes square = new Square(sides, color);
						Console.WriteLine(square.DisplayInfo());
						_shapes.Add(square);
						choosingQuad = false;
					}
					else { choosingQuad = true; }
				} while (choosingQuad == true);
				choosingBaseShape = false;
			}
			else if (baseShape == 3)
			{
				Console.Write("Length of Radius: ");
				double radius = double.Parse(Console.ReadLine());

				Console.Write("Color of Circle: ");
				string color = Console.ReadLine();

				Circle circle = new Circle(radius, color);
				Console.WriteLine(circle.DisplayInfo());
				_shapes.Add(circle);

				choosingBaseShape = false;
			}
			else
			{
				choosingBaseShape = true;
			}
		} while (choosingBaseShape == true);
	}
	public void DisplayShapes()
	{
		foreach (FlatShapes shape in _shapes)
		{
			Console.WriteLine(shape.DisplayInfo());
		}
		Console.WriteLine();
	}
}