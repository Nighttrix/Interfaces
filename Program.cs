// See https://aka.ms/new-console-template for more information
TodoList tdl = new TodoList();
tdl.Add("Invite Friends");
tdl.Add("Buy decorations");
tdl.Add("Party");

PasswordManager pm = new PasswordManager("iluvpie", true);

tdl.Display();
pm.Display();

tdl.Reset();
pm.Reset();

tdl.Display();
pm.Display();
