using System;

public class Display
{
    #region Fields
    private float size;
    private int colors;
    #endregion

    #region Constructors
    public Display()
        : this(0, 0)
    {
    }

    public Display(float size, int colors)
    {
        this.Size = size;
        this.Colors = colors;
    }
    #endregion

    #region Properties
    public float Size
    {
        get { return this.size; } 
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The size cannot be negative number");
            }
            else if (value > 1000)
            {
                throw new ArgumentOutOfRangeException("The size is too big");
            }

            this.size = value;
        }
    }
    public int Colors
    {
        get { return this.colors; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The colors cannot be negative number");
            }

            this.colors = value;
        }
    }
    #endregion

    #region Methods
    public override string ToString() 
    {
        return string.Format("Size: {0}, Colors: {1}", this.Size, this.Colors);
    }
    #endregion
}