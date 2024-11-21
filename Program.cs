using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(00) 12345-6789", modelo: "Nokia 3200", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo ("Facebook");
nokia.ReceberLigacao("Maria");
nokia.Desligar();

Console.WriteLine ("\n");

Console.WriteLine ("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "(99) 98765-4321", modelo: "Iphone 13 Pro Max", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao("João");
iphone.InstalarAplicativo("Instagram");
iphone.Desligar();