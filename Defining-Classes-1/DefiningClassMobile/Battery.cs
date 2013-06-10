using System;

public class Battery
{
    #region Fields
    private string model;
    private BatteryType batteryType;
    private float hoursIdle;
    private float hoursTalk;
    #endregion

    #region Constructors
    public Battery(string model, BatteryType batteryType)
        : this(model, batteryType, 0, 0)
    {
    }

    public Battery(string model, BatteryType batteryType, float hoursIdle, float hoursTalk)
    {
        this.Model = model;
        this.BatteryType = batteryType;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }
    #endregion

    #region Properties
    public string Model {
        get { return this.model; }
        set {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model cannot be empty!");
            }
            else if (value.Length > 50)
            {
                throw new ArgumentException("The model's name is too long");
            }

            this.model = value; 
        }
    }
    public BatteryType BatteryType 
    {
        get { return this.batteryType; }
        set { this.batteryType = value; }
    }
    public float HoursIdle 
    {
        get { return this.hoursIdle; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The hours in idle cannot be negative");
            }

            this.hoursIdle = value; 
        }
    }
    public float HoursTalk 
    {
        get { return this.hoursTalk; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The hours talking cannot be negative");
            }

            this.hoursTalk = value;
        }
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return string.Format("Model: {0}, Battery type: {1}, Hours idle: {2}, Hours talk: {3}", this.Model, this.BatteryType, this.HoursIdle, this.HoursTalk);
    }

    internal bool IsLetterAllowedInNames(char ch)
    {
        bool isAllowed = char.IsLetter(ch) || ch == '-' || ch == ' ';
        return isAllowed;
    }
    #endregion
}