using System;
// en primer lugar se crea la clase Job y se crea sus clases miembros
class Program
{
  static void Main(string[] args)
  {
    //Aqui se crea el objeto job1 y le damos sus respectivos datos que queremos,
    //Recuerda que Job es el nombre de la clase y job1 es la instancia de esa clase para sustraer 
    // la accion de donde viene en esa clase como los atributos y el metodo que estan ahí.
    Job job1 = new Job();
    job1._jobTitle = "Software Engineer";
    job1._company = "Microsoft";
    job1._startYear = 2019;
    job1._endYear = 2022;

    //Aqui creamos otro objeto(instancia) job2 y le damos sus datos tambien.
    Job job2 = new Job();
    job2._jobTitle = "Manager";
    job2._company = "Apple Inc";
    job2._startYear = 2022;
    job2._endYear = 2023;

    //Aquí creamos el objeto(instancia) de la clase Resume lo cual es resume.
    Resume resume = new Resume();
    resume._namePerson = "Allison Rose";

    //Utilizamos "Add" para añadir el objeto job1 y job2 donde se iterara ultilizando
    //el objeto _jobs de la lista que se creo en la clase Resume y con eso imprimira 
    //invocando el metodo Display que esta abajo.
    resume._jobs.Add(job1);
    resume._jobs.Add(job2);

    //Llamamos al metodo Display utilizando la instancia resume para invocarlo aquí
    // y luego e muestra lo que se requiere lo que esta adentro del metodo Display
    resume.Display();








  }
}