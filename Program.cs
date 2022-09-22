using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("21-90000-1111", "Iphone Plus", "123456789", 8);

iphone.Ligar();
iphone.ReceberLigacao();

Nokia nokia = new Nokia("21-98000-2222", "Nokia Tijolão", "987654321", 16);
nokia.Ligar();
nokia.ReceberLigacao();

nokia.InstalarAplicativo("App de Banco para Nokia");
iphone.InstalarAplicativo("App de Banco para Iphone");

nokia.Numero = "456456";

//teste de private:
//nokia.Modelo = "Nokia Plus";

Console.WriteLine($"Nókia novo número: {nokia.Numero}");

nokia.ReceberLigacao();
