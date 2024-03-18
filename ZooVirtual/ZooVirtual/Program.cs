using static System.Runtime.InteropServices.JavaScript.JSType;

public virtual void EmitirSonido()
{
    Console.WriteLine("El animal emite un sonido...");
}

public override string ToString()
{
    return $"Nombre: {Nombre}\nEspecie: {Especie}";
}
}

class Elefante : Animal
{
    public Elefante(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Elefante") { }

    public override void Alimentar()
    {
        Console.WriteLine("El elefante come hojas...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El elefante hace 'UHHH'...");
    }
}

class Jirafa : Animal
{
    public Jirafa(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Jirafa") { }

    public override void Alimentar()
    {
        Console.WriteLine("La jirafa come hojas...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("La jirafa hace 'aaahhhhhhhhhhh'...");
    }
}

class Tigre : Animal
{
    public Tigre(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Tigre") { }

    public override void Alimentar()
    {
        Console.WriteLine("El tigre come carne...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El tigre hace 'GARRRRRRR'...");
    }
}

class Mono : Animal
{
    public Mono(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Mono") { }

    public override void Alimentar()
    {
        Console.WriteLine("El mono come frutas...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El mono hace 'UUUUAAAAAAH'...");
    }
}
class Oso : Animal
{
    public Oso(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Oso") { }

    public override void Alimentar()
    {
        Console.WriteLine("El oso come carne...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El oso hace 'ARR'...");
    }
}


class Cocodrilo : Animal
{
    public Cocodrilo(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Cocodrilo") { }

    public override void Alimentar()
    {
        Console.WriteLine("El cocodrilo come carne...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El cocodrilo hace 'HHHHHHHRRRRRR'...");
    }
}


class Serpiente : Animal
{
    public Serpiente(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Serpiente") { }

    public override void Alimentar()
    {
        Console.WriteLine("La serpiente come ratones...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("La serpiente hace 'shhhhhshshhsh'...");
    }
}


class Pinguino : Animal
{
    public Pinguino(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Pinguino") { }

    public override void Alimentar()
    {
        Console.WriteLine("El pingüino come peces...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El pingüino hace 'AH AH AH AH AH'...");
    }
}


class Lobo : Animal
{
    public Lobo(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Lobo") { }

    public override void Alimentar()
    {
        Console.WriteLine("El lobo come carne...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El lobo hace 'AUUUUUUUUUUUUU'...");
    }
}

// Clase Cebra
class Cebra : Animal
{
    public Cebra(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Cebra") { }

    public override void Alimentar()
    {
        Console.WriteLine("La cebra come hierbas...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("La cebra hace 'GUGUGUGU'...");
    }
}

// Clase Rinoceronte
class Rinoceronte : Animal
{
    public Rinoceronte(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Rinoceronte") { }

    public override void Alimentar()
    {
        Console.WriteLine("El rinoceronte come hierbas y frutas...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El rinoceronte hace 'grrrrrrrrr'...");
    }
}

// Clase Panda
class Panda : Animal
{
    public Panda(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Panda") { }

    public override void Alimentar()
    {
        Console.WriteLine("El panda come bambú...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El panda hace 'ja ja ja'...");
    }
}

// Clase PavoReal
class PavoReal : Animal
{
    public PavoReal(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Pavo Real") { }

    public override void Alimentar()
    {
        Console.WriteLine("El pavo real come insectos y semillas...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El pavo real hace 'MA MA MA MA'...");
    }
}

// Clase Tortuga
class Tortuga : Animal
{
    public Tortuga(string nombre, int altura, int peso, string sexo, int edad) : base(nombre, altura, peso, sexo, edad, "Tortuga") { }

    public override void Alimentar()
    {
        Console.WriteLine("La tortuga come plantas...");
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("La tortuga hace 'ah ah ah ah'...");
    }
}



class Program
{
    static void Main(string[] args)
    {

        Elefante elefante = new Elefante("Dumbo", 300, 5000, "Macho", 10);
        Jirafa jirafa = new Jirafa("Melman", 500, 1500, "Macho", 5);
        Tigre tigre = new Tigre("Shere Khan", 120, 250, "Macho", 8);
        Mono mono = new Mono("Abu", 50, 10, "Macho", 3);
        Oso oso = new Oso("Baloo", 150, 300, "Macho", 15);
        Cocodrilo cocodrilo = new Cocodrilo("Croc", 80, 200, "Hembra", 6);
        Serpiente serpiente = new Serpiente("Kaa", 15, 5, "Hembra", 12);
        Pinguino pinguino = new Pinguino("Skipper", 60, 30, "Macho", 7);
        Lobo lobo = new Lobo("Lupin", 80, 120, "Macho", 9);
        Cebra cebra = new Cebra("Marty", 150, 200, "Macho", 4);
        Rinoceronte rinoceronte = new Rinoceronte("Rhino", 140, 1800, "Macho", 20);
        Panda panda = new Panda("Po", 100, 150, "Macho", 6);
        PavoReal pavoReal = new PavoReal("Pepe", 50, 10, "Macho", 2);
        Tortuga tortuga = new Tortuga("Donatello", 30, 20, "Hembra", 50);

        Console.WriteLine("Bienvenido al zoológico virtual!");
        Console.WriteLine("Información del elefante:");
        Console.WriteLine(elefante);
        elefante.Alimentar();
        elefante.EmitirSonido();

        Console.WriteLine("\nInformación de la jirafa:");
        Console.WriteLine(jirafa);
        jirafa.Alimentar();
        jirafa.EmitirSonido();

        Console.WriteLine("\nInformación del tigre:");
        Console.WriteLine(tigre);
        tigre.Alimentar();
        tigre.EmitirSonido();

        Console.WriteLine("\nInformación del mono:");
        Console.WriteLine(mono);
        mono.Alimentar();
        mono.EmitirSonido();

        Console.WriteLine("\nInformación del oso:");
        Console.WriteLine(oso);
        oso.Alimentar();
        oso.EmitirSonido();

        Console.WriteLine("\nInformación del cocodrilo:");
        Console.WriteLine(cocodrilo);
        cocodrilo.Alimentar();
        cocodrilo.EmitirSonido();

        Console.WriteLine("\nInformación de la serpiente:");
        Console.WriteLine(serpiente);
        serpiente.Alimentar();
        serpiente.EmitirSonido();

        Console.WriteLine("\nInformación del pinguino:");
        Console.WriteLine(pinguino);
        pinguino.Alimentar();
        pinguino.EmitirSonido();

        Console.WriteLine("\nInformación del lobo:");
        Console.WriteLine(lobo);
        lobo.Alimentar();
        lobo.EmitirSonido();

        Console.WriteLine("\nInformación de la cebra:");
        Console.WriteLine(cebra);
        cebra.Alimentar();
        cebra.EmitirSonido();

        Console.WriteLine("\nInformación del panda:");
        Console.WriteLine(panda);
        panda.Alimentar();
        panda.EmitirSonido();

        Console.WriteLine("\nInformación de la jirafa:");
        Console.WriteLine(jirafa);
        jirafa.Alimentar();
        jirafa.EmitirSonido();

        Console.WriteLine("\nInformación de la jirafa:");
        Console.WriteLine(jirafa);
        jirafa.Alimentar();
        jirafa.EmitirSonido();

        Console.WriteLine("\nInformación de la jirafa:");
        Console.WriteLine(jirafa);
        jirafa.Alimentar();
        jirafa.EmitirSonido();

        Console.WriteLine("\nInformación de la jirafa:");
        Console.WriteLine(jirafa);
        jirafa.Alimentar();
        jirafa.EmitirSonido();




        Console.ReadLine();
    }
}