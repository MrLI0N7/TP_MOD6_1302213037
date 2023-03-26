public class SayaTubeVideo{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title) 
    { 
        this.title = title;
        Random videoID = new Random();
        this.id = videoID.Next(9999,100000);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int InputplayCount) 
    {
        this.playCount += InputplayCount;
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
        VideoTuto.IncreasePlayCount(1969);
        VideoTuto.PrintVideoDetails();
    }
}
