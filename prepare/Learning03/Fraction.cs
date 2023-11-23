using System;

public class Fraction{

 private int _top;
 private int _bottom;


 public Fraction(){
   //inicializa por defecto 1/1
    _top = 1;
    _bottom = 1;
 }

 public Fraction(int wholeNumber){
    // el wholeNumber es donde ira arriba de la fraccion, cuando se de un numero cualquiera
    // seria x/1(fraccion)
   _top = wholeNumber;
   _bottom = 1;


 }

 public Fraction(int top, int bottom){

     _top = top;
     _bottom = bottom;

 }

 public string GetFractionString(){
   // Este es para que imprima.

    string text = $"{_top}/{_bottom}";
    return text;
 }

 public double GetDecimalValue(){
    // Este es para que haga el calculo respectivo.
    return (double)_top / (double)_bottom;

 }
  


}