using System;

class MainClass {
  public static void Main (string[] args) {

    Euclides euclides = new Euclides();
    ForcaBruta forcabruta = new ForcaBruta();



    //Euclides
    var euclidesResult = euclides.PrimoByEuclides(1,2581) ? "É PRIMO!!!!" : "NÃO É PRIMO!!!";
    Console.WriteLine(euclidesResult);


  //Força Bruta
  var prime = forcabruta.checkPrime(4,6);
  Console.WriteLine(prime);
  }
}