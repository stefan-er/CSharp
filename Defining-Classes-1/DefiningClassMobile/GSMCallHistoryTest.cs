using System;
using System.Collections.Generic;

class GSMCallHistoryTest
{
    static void Main()
    {
        DateTime date1 = new DateTime(2013, 5, 24, 11, 11, 30);
        DateTime date2 = new DateTime(2013, 5, 24, 15, 23, 2);
        DateTime date3 = new DateTime(2013, 5, 31, 9, 00, 00);
        DateTime date4 = new DateTime(2013, 5, 31, 18, 12, 20);

        Call call1 = new Call(date1, "0888313233", 850);
        Call call2 = new Call(date2, "0888909090", 95);
        Call call3 = new Call(date3, "0889556677", 213);
        Call call4 = new Call(date4, "0888313233", 37);

        Battery battery = new Battery ("PX8", BatteryType.LiIon, 300, 8);
        Display display = new Display(4, 16000000);
        GSM gsm = new GSM("I900", "Samsung", 500, "Me", battery, display);

        gsm.AddCalls(call1);
        gsm.AddCalls(call2);
        gsm.AddCalls(call3);
        gsm.AddCalls(call4);

        foreach (var call in gsm.CallHistory)
        {
            Console.WriteLine(call);
        }

        Console.WriteLine("Total amount to pay: {0:C}",gsm.TotalCallsPrice);

        gsm.DeleteCalls(call1);
        Console.WriteLine("Total amount to pay: {0:C}", gsm.TotalCallsPrice);

        gsm.ClearHistory();
        Console.WriteLine("Total amount to pay: {0:C}", gsm.TotalCallsPrice);

    }
}