using SOLIDPrincipleExample;

//Circle circle = new Circle();
//circle.Radius = 5;
//Console.WriteLine(Math.Round(circle.CalculateArea(),2));

VideoPlayer videoPlayer = new VideoPlayer(new FileSystemUtility());
videoPlayer.play("hello.mp4");