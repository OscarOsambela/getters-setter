using System;

class MainClass {
  public static void Main (string[] args) {
    
    Coche obj = new Coche();
    obj.setInfoCoche(true, "cuero");//llamando al setter
    Console.WriteLine(obj.getInfoCoche());
  }
}

//clase Coche

//Coche partial 1
partial class Coche{
  //constructor vacío
  public Coche(){
    tapiceria = "tela";
  }
}  

//coche partial 2
partial class Coche{
  //get devuelve informacion
  //set establece informacion, no lleva return porque es vacío
  //en caso definamos el parametro con el mismo nombre del campo de clase es posible utilizando la palabra "this" delante del campo de clase, caso contrario el setter dejará de funcionar 
  public void setInfoCoche(bool climatizador, string tapiceria){
    this.climatizador = climatizador;
    this.tapiceria = tapiceria;
  }
  public string getInfoCoche(){
    return "Extras del coche:\n" +
           "Tapicería: " + tapiceria + "\n" +
           "Climatizador: " + climatizador;
  }

  private bool climatizador;
  private string tapiceria;
}