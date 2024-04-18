public class Rectangle : Shape
{
    private double width = 1.0;
    private double height = 1.0;

    public Rectangle()
    {

    }

    public Rectangle(double width , double height)
    {
        this.width = width;
        this.height = height;
    }

    public Rectangle(double width , double height,string color,bool filled) : base(color, filled)
    {
        this.width = width;
        this.height = height;
    }

    public double GetWidth()
    {
        return width;
    }

    public virtual void SetWidth(double width)
    {
        this.width = width;
    }

    public double GetHeight()
    {
        return height;
    }
    public virtual void SetHeight(double height)
    {
       this.height = height;
    }
    
    public double GetArea()
    {
        return width*height;
    }
    public double GetPerimeter()
    {
        return 2*(width + height);
    }

    public override string ToString()
    {
        return " A Rectangle with Width = "
        + GetWidth() + " and Height = " + GetHeight()
        +  " which is a subclass of "
        + base.ToString();

    }
}