using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://24.media.tumblr.com/1d0abaa63c88ab57b7c03a5011d810c1/tumblr_mhc42dR6dN1ruuh66o1_1280.jpg", @"pic.jpg");
        }
        catch (WebException)
        {
            Console.WriteLine("Remote server returned error: Forbidden.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Address cannot null.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}