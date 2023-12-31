
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>(); // Iniciamos dandole valor a la lista vacia para _prompts y _questions.
    private List<string> _questions = new List<string>();
    public ReflectingActivity(string name, string description) : base(name, description)
    {    // Aquí se agrega las preguntas en el contructor, para que asi ya no sea necesario
         // colocarlas en la clase principal como parametro, y a su vez 
        _prompts.Add("Piensa en un momento en el que defendiste a otra persona.");
        _prompts.Add("Piensa en un momento en el que hiciste algo realmente difícil.");
        _prompts.Add("Piensa en un momento en el que hiciste algo verdaderamente desinteresado.");
        _prompts.Add("Piensa en un momento en el que ayudaste a alguien necesitado.");
        _questions.Add("¿Por qué fue significativa para usted esta experiencia?");
        _questions.Add("¿¿Alguna vez habías hecho algo como esto antes?");
        _questions.Add("¿Cómo empezaste?");
        _questions.Add("¿Cómo te sentiste cuando estuvo completo?");
        _questions.Add("¿Qué hizo que esta época fuera diferente a otras en las que no tuvo tanto éxito?");
        _questions.Add("¿Qué es lo que más te gusta de esta experiencia?");
        _questions.Add("¿Qué podrías aprender de esta experiencia que se aplique a otras situaciones?");
        _questions.Add("¿Qué aprendiste sobre ti mismo a través de esta experiencia?");
        _questions.Add("¿Cómo puedes tener presente esta experiencia en el futuro?");
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        DisplayEndingMessage();
    }
    public string GetRandomPrompt() // Este metodo utiliza la instancia _prompts puesto que ya tiene almacenado las preguntas en ese objeto.
    {
        int numberRandom;
        Random random = new Random();
        numberRandom = random.Next(_prompts.Count);
        return _prompts[numberRandom];
    }
    public string GetRandomQuestion()
    {
        int numberRandom;
        Random random = new Random(); // Aqui tenemos la instancia _questions de la lista, eso tiene almacenado las preguntas en el constructor.
        numberRandom = random.Next(_questions.Count);
        return _questions[numberRandom];
    }
    public void DisplayPrompt()
    {
       ShowSpinner(5);
       Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
       ShowSpinner(5); 
       Console.WriteLine(GetRandomQuestion());
    }



}