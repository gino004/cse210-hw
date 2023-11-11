using System;

public class Resume
{

    public string _namePerson;
    // Aquí se crea una lista la cual el objeto que se utilizara es _jobs y se pone
    //el nombre de la clase Job la cual tomará esos datos de ahí.
    public List<Job> _jobs = new List<Job>();

    // Creamos el metodo Display.
    public void Display()
    {
        // Aquí ponemos el metodo de impresión para la salida
        // y desde la clase Program esta ubicado su instancia resume con el nombre ALlison Rose.
        Console.WriteLine($"Name: {_namePerson}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
        //This calls the DisplayJobDetails method on each job,
        //este metodo DsiplayJobDetails es lo que se invoca usando la palabra job 
        //y luego eso itera los datos de ese metodo que esta en la clase Job.
            job.DisplayJobDetails();
        }



    }

}