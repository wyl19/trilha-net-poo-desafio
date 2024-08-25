using DesafioPOO.Models;

Console.WriteLine("Teste Nokia");
Smartphone nokia = new Nokia(numero:"99999", modelo: "tijolar", imei: "1234", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Olx");

Console.Write($"\n Teste Iphone");
Smartphone iphone = new Iphone(numero:"88888", modelo: "modelo x", imei: "4321", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");