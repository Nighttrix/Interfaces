class TodoList : IDisplayable, IResetable {
    
    //Properties
    public string[] Todos { get; private set; }
    private int nextOpenIndex;

    //Constructors
    public TodoList() {
        Todos = new string[5];
        nextOpenIndex = 0;
    }
    //Methods
    public void Add(string todo) {
        Todos[nextOpenIndex] = todo;
        nextOpenIndex++;
    }

    public void Display() {
        Console.WriteLine("Todo List:");
        foreach (string todo in Todos) {
            Console.WriteLine(todo);
        }
    }

    public void Reset() {
        Todos = new string[5];
        nextOpenIndex = 0;
    }
}