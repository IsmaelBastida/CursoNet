using Curso;

// Foo foo = new Foo {Name="Ismael"};
// Foo foo1 = new Foo {Name="Ismael Bastida"};

//Inferencia de tipos --> Desconozco el valor de la izquierta, ya que va a ser lo que me devuelva la derecha
// var foo3 = new Foo() {Name="Ismael Bastida Gutierrez"};

//Sugar Sintax --> Crea el objeto y luego le asigna las props
// Foo foo4 = new Foo() {Name="Ismael Bastida Gutierrez"};


// Foo foo = new Foo(1,"hola");
// Foo foo2 = new Foo(1,"hola");

// Console.WriteLine(foo.Name);
// Console.WriteLine(foo1.Name);

Pinguino pingu = new Pinguino(5);
Aguila aguila = new Aguila(10, 100);

System.Console.WriteLine("Pinguino -  Peso: " + pingu.Peso);
System.Console.WriteLine("Aguila - Peso: " + aguila.Peso + " Velocidad: " + aguila.Velocidad);

