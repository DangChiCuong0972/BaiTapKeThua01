public class Shape
{
    // Color
    private string color = " Green ";
     private bool filled = true ;

    public string GetColor()
    {
        return color;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    // Filled
   

    public bool isFilled()
    {
        return filled;
    }
    public void SetFilled(bool filled)
    {
        this.filled = filled;
    }

    public Shape()
    {

    }

    public Shape ( string color , bool filled)
    {
        this.color = color;
        this.filled = filled;
    }

    public override string ToString()
    {
        return "A  shape with color of " 
        + GetColor() + " and " 
        + (isFilled() ? "filled" : "not filled");
    }
    
}


