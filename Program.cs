using DesafioPOO.Models;

Console.WriteLine("Testes com o Smartphone Nokia:");
Smartphone nokia = new Nokia("2014", "Nokia 3310", "123456789", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Testes com o Smartphone Iphone:");
Smartphone iphone = new Iphone("8708", "Iphone XR", "987654321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");
