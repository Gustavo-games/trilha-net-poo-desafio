using DesafioPOO.Models;

Smartphone iphone = new Iphone("1234568", "Modelo 1", "121212121", 256);
iphone.InstalarAplicativo("Bloco de notas");
iphone.Ligar();

Smartphone nokia = new Nokia("99988888", "Modelo13", "333333333", 32);
nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();