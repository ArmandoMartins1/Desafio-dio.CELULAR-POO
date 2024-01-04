using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "81-9.9909-8785", modelo: "modelo C-115", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Brasfoot");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");

Smartphone iphone = new Iphone(numero: "81-9.8658-8477", modelo: "Iphone 8", imei: "2222222222", memoria: 180);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();