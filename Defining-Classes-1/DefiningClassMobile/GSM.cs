using System;
using System.Collections.Generic;

public class GSM
{
    #region Fields
    private string model;
    private string manufacturer;
    private float price;
    private string owner;
    private Battery battery;
    private Display display;
    private static GSM iPhone4S = new GSM ("iPhone4S", "Apple", 1200, "Apple inc.", new Battery("A8Z", BatteryType.NiH, 300, 6), new Display(3.7f, 16000000));
    private List<Call> callHistory = new List<Call>();
    #endregion

    #region Constructors
    public GSM(string model, string manufacturer)
        : this(model, manufacturer, 0)
    { 
    }

    public GSM(string model, string manufacturer, float price)
        : this(model, manufacturer, price, null)
    { 
    }

    public GSM(string model, string manufacturer, float price, string owner)
        : this(model, manufacturer, price, owner, null, null)
    { 
    }

    public GSM(string model, string manufacturer, float price, string owner, Battery battery, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.Battery = battery;
        this.Display = display;
    }
    #endregion

    #region Properties
    public string Model 
    {
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

    public string Manufacturer 
    {
        get { return this.manufacturer; }
        set {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Manufacturer cannot be empty!");
            }
            else if (value.Length > 50)
            {
                throw new ArgumentException("The manufacturer's name is too long");
            }

            this.manufacturer = value; 
        }
    }

    public float Price 
    {
        get { return this.price; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The price cannot be negative");
            }
            this.price = value; 
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }

    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public Display Display
    {
        get { return this.display; }
        set { this.display = value; }
    }

    public static GSM IPhone4S 
    {
        get { return iPhone4S; }
    }

    public List<Call> CallHistory
    {
        get { return this.callHistory; }
        set { this.callHistory = value; }
    }

    public float TotalCallsPrice
    {
        get 
        {
            float totalSeconds = 0f;

            foreach (var call in this.CallHistory)
            {
                totalSeconds += call.Duration;
            }

            float totalMinutes = totalSeconds / 60;
            
            return totalMinutes * 0.37f;
        }
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return string.Format("Model: {0}, Manufacturer: {1}, Price: {2}, Owner: {3}, Battery: {4}, Display: {5}", this.Model, this.Manufacturer, this.Price, this.Owner, this.Battery, this.Display);
    }

    public void AddCalls(Call call)
    {
        this.CallHistory.Add(call);
    }

    public void DeleteCalls(Call call)
    {
        this.CallHistory.Remove(call);
    }

    public void ClearHistory()
    {
        this.CallHistory.Clear();
    }
    #endregion
}

