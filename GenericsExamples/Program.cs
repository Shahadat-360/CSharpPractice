using GenericsExamples;

Coordinate<double> coordinate = new Coordinate<double>(5,6);
//coordinate.x = 50;
//coordinate.y = 100;
Console.WriteLine(coordinate.x+coordinate.y);
coordinate.ThreeDimension(5, "Shahdat");
Console.WriteLine(coordinate.isSame(5, 5));