using System;
  // aqui se crea la clase Job y debe ser publica tanto la clase y sus variables para asi utilizar sus campos.

public class Job{

  public string _company;
  public string _jobTitle;
  public int _startYear;
  public int _endYear;

  //aqui se crea un metodo publico para asi imprimir los objetos que estan en la clase Program.
  public void DisplayJobDetails(){

    Console.WriteLine($"{_jobTitle}-{_company}-{_startYear}-{_endYear}");

 }


}