using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "77999999999", modelo: "C01 Plus", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone(numero: "7788888888888", modelo: "15", imei: "222222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DIO");