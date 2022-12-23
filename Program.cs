using DesafioPOO.Models;

Nokia nokia = new Nokia("55923929", "Nokia X6", "358", 64);
Iphone iphone = new Iphone("5598278337", "Iphone X", "243", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");