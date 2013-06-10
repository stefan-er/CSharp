using System;
using System.Collections.Generic;

public class Call
{
    #region Fields
    private DateTime date;
    //private DateTime time;
    private string dialedPhoneNumber;
    private int duration;
    #endregion

    #region Constructors
    public Call(DateTime date, string dialedPhoneNumber, int duration)
    { 
        this.Date = date;
        //this.Time = time;
        this.DialedPhoneNumber = dialedPhoneNumber;
        this.Duration = duration;
    }
    #endregion

    #region Properties
    public DateTime Date 
    {
        get { return this.date.Date; }
        set { this.date = value; }
    }
    public TimeSpan Time
    {
        get { return this.date.TimeOfDay; }
    }
    public string DialedPhoneNumber
    {
        get { return this.dialedPhoneNumber; }
        set { this.dialedPhoneNumber = value; }
    }
    public int Duration
    {
        get { return this.duration; }
        set { this.duration = value; }
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return string.Format("Date: {0}, Time: {1}, DialedPhoneNumber: {2}, Duration: {3}", this.Date, this.Time, this.DialedPhoneNumber, this.Duration);
    }
    #endregion

}