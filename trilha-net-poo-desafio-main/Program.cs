using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "Tipo 1", imei: "000000", memoria: "10");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "789", modelo: "Tipo 3", imei: "000111", memoria: "520");
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("WhatsApp");
