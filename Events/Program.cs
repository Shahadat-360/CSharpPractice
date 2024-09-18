using Events;

Fan fan=new Fan();
Switch swich1 = new Switch();
swich1.OnPress += fan.Rotating;

while (Console.ReadLine()!="e")
{
    swich1.Press();
}