using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("(55) 5555-5555","N1", "f1sd65f4asd5", 4096);
Iphone iphone = new Iphone("(66) 6666-6666","I1", "hj0dsagf51d5g", 4096);

Console.WriteLine("Ligação Nokia");
nokia.Ligar();
Console.WriteLine("Recebendo ligação Iphone");
iphone.ReceberLigacao();

Console.WriteLine("Ligação Iphone");
iphone.Ligar();
Console.WriteLine("Recebendo ligação Nokia");
nokia.ReceberLigacao();

nokia.InstalarAplicativo("App de teste");
iphone.InstalarAplicativo("Teste de app");
