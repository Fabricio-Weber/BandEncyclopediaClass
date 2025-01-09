using BandEncyclopediaClass;

Main();
return;

void Main()
{
   // Music music1 = new Music("East Hastings", "Godspeed You! Black Emperor", "F#A#", "Post Rock", 1020, true); 
   // Console.WriteLine($"{music1.Description}");

    Album whitePony = new Album();
    whitePony.Name = "White Pony";
    
    Music music1 = new Music();
    music1.Name = "Digital Bath";
    music1.Artist = "Deftones";
    music1.Runtime = 240;
    
    Music music2 = new Music();
    music2.Name = "Pink Maggit";
    music2.Artist = "Deftones";
    music2.Runtime = 360;

    whitePony.AddMusic(music1);
    whitePony.AddMusic(music2);

    whitePony.ShowMusics();
}