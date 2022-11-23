using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone tijolo = new Nokia("91981765608", "Nokia 5510", "111111111", 128);
Smartphone sj = new Iphone("1283121312", "Iphone 13", "2222222222", 256);

tijolo.Ligar();
tijolo.InstalarAplicativo("The Sims");


sj.ReceberLigacao();
sj.InstalarAplicativo("Pou");