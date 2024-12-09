using System.Buffers;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "443322", modelo: "Modelo 1", imei: "11111",memoria: 64);
nokia.MostrarDados();
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "332211", modelo: "Modelo 2", imei: "22222", memoria: 128);
iphone.MostrarDados();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
