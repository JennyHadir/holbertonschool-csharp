using System;

///<summary>Shape class</summary>
class Shape
{
    ///<summary>Throw an exception</summary>
    ///<return></return>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>Rectangle Derived Class.</summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }


    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;   
        }
    }

    ///<summary> Calculat the area</summary>
    ///<return>Area</return>
    public new int Area()
    {
        return width * height;
    }

    ///<summary> Override</summary>
    ///<return>String representation of Rectangle</return>
    public override string ToString()
    {
        return $"[Rectangle] {this.width} / {this.height}";
    }
}

///<summary>Square class that inherits from Rectangle</summary>
class Square : Rectangle
{
    private int size;
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
                size = value;
                Height = value;
                Width = value;            
        }
    }

    ///<summary> Override</summary>
    ///<return>String representation of Square</return>
    public override string ToString()
    {
        return $"[Square] {this.size} / {this.size}";
    }
}
