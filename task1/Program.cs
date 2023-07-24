using task1;

var obj=new Time(23,59,50);

while (true)
{
    obj.nextSecond();
    System.Console.WriteLine(obj.ToString());
    Thread.Sleep(1000);
    Console.Beep();
}