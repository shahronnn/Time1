using task2;

var mahmud=new Account(1,500);
mahmud.Credit(500);

var ravshan=new Account(2,800);

System.Console.WriteLine(mahmud.ToString());
System.Console.WriteLine(ravshan.ToString());

mahmud.TransferTo(200, ravshan);

System.Console.WriteLine("------------------------");
System.Console.WriteLine(mahmud.ToString());
System.Console.WriteLine(ravshan.ToString());

mahmud.TransferTo(500, ravshan);

System.Console.WriteLine("------------------------");
System.Console.WriteLine(mahmud.ToString());
System.Console.WriteLine(ravshan.ToString());