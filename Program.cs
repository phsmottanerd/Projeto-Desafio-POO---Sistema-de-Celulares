using DesafioPOO.Models;

Console.WriteLine("Testando Nokia:");
Smartphone nokia = new Nokia("9999-9999", "Nokia Tijolão", "IMEI12345", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\nTestando iPhone:");
Smartphone iphone = new Iphone("8888-8888", "iPhone 14", "IMEI67890", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
