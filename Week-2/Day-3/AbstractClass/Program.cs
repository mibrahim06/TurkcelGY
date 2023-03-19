using AbstractClass;

Shape[] shapes = new Shape[3];
shapes[0] = new Circle(5);
shapes[1] = new Rectangle(3, 4);
shapes[2] = new Square(5);

foreach (Shape shape in shapes)
{
    shape.PrintShape();
}
