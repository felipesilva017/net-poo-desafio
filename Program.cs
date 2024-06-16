using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "85993470294", modelo: "ms3", imei: "930403", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.ReadKey();
Console.WriteLine();


Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "85993472204", modelo: "15 pro", imei: "4343443", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.ReadKey();