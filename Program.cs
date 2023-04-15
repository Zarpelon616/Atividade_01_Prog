using atividade01.classes;

Person[] people = new Person[]
{
    new Manager{ 
        Name = "Mr. Watson"
        , Born = new(year: 1995, month: 8, day: 20)
        , ID = "2020399"
        , ServiceHours = 10
        , IsWorker = true
        , Cargo = "Gerente"
    },
    new Supervisor{
        Name = "Peter"
        , Born = new(year:2001, month: 10, day: 12)
        , ID = "1012043"
        , ServiceHours = 8
        , IsWorker = true
        , Cargo = "Supervisor"
    },
    new Worker{
        Name = "Marcos"
        , Born = new(year:2004, month: 12, day: 20)
        , ID = "3004021"
        , ServiceHours = 8
        , IsWorker = true
        , Cargo = "Operario"
    },
    new Worker{
        Name = "Davi"
        , Born = new(year:2003, month: 01, day: 22)
        , ID = "3224021"
        , ServiceHours = 10
        , IsWorker = true
        , Cargo = "Operario"
    },

};

for (int i = 0; i < people.Length; i++)
 {

    var person = people[i]; 

    Console.WriteLine($"{i + 1}° Funcionario");
    Console.WriteLine("------------------------------");
    Console.WriteLine($"Nome: {person.Name}");
    Console.WriteLine($"Data de nascimento: {person.Born.ToShortDateString()}");
    Console.WriteLine($"ID: {person.ID}");
    Console.WriteLine($"Horas Diarias: {person.ServiceHours}");
    Console.WriteLine($"Cargo: {person.Cargo}");
    Console.WriteLine("------------------------------\n");
}
