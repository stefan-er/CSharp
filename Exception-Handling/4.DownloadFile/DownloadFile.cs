using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        string address = "http://www.devbg.org/img/Logo-BASD.jpg";
        string fileName = @"d:\Logo-BASD.jpg";
        using (WebClient webClient = new WebClient())

        try
        {
            webClient.DownloadFile(address, fileName);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address parameter is null.\n-or-\nThe fileName parameter is null");
        }
        catch (WebException)
        {
            Console.WriteLine("The address is invalid.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("	The method has been called simultaneously on multiple threads.");
        }
        finally
        {
            webClient.Dispose();
        }
    }
}