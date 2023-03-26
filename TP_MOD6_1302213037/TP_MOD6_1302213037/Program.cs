using System.Diagnostics.Contracts;

public class SayaTubeVideo{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title) 
    {
        Contract.Requires(title != null && title.Length <= 100);

        this.title = title;
        Random videoID = new Random();
        this.id = videoID.Next(10000,999999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int InputplayCount) 
    {
        Contract.Requires(playCount <= 10000000);
       
        try
        {
            checked
            {
                this.playCount += InputplayCount;
            }
            
        }
        catch (OverflowException e) 
        {
            Console.WriteLine(e.Message);
        }
        
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: "+id);
        Console.WriteLine("Video Title: "+title);
        Console.WriteLine("Video playCount: "+playCount);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo VideoTuto = new SayaTubeVideo("Tutorial Design By Contract - Liyan M. L. WAYAN");
        for(int i = 0; i <215;  i++)
        {
            VideoTuto.IncreasePlayCount(10000000);
            VideoTuto.PrintVideoDetails();
        }
    }
}
