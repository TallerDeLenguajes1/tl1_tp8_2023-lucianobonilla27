// See https://aka.ms/new-console-template for more information
using EspacioTarea;
Random rand = new();
string input;
int menu;
int id;
string input2;
int n = 3;
var pendientes = new List<Tarea>();
var realizadas = new List<Tarea>();

for (int i = 0; i < n; i++)
{
    Tarea t = new();
    Console.WriteLine("Ingrese la descripcion de la tarea {0}:",i+1);

    t.Descripcion = Console.ReadLine();
    t.Duracion = rand.Next(10,101);
    t.TareaID = i+1;
    pendientes.Add(t);
    Console.WriteLine(" "); 

}

do
{
    Console.WriteLine("Ingrese:");
    Console.WriteLine("1-Mostrar tareas pendientes:");
    Console.WriteLine("2-Mostrar tareas realizadas:");
    Console.WriteLine("3-Realizar tarea:");
    Console.WriteLine("4-Buscar en pendientes por descripcion:");
    Console.WriteLine("5-Salir:");
    input = Console.ReadLine();
    menu = int.Parse(input);
   
   
using (StreamWriter writer = new StreamWriter("archivo.txt"))
{
    int Tiempo=0;
    foreach (var item in pendientes)
    {
        Tiempo += item.Duracion;
    }
    writer.WriteLine("Tiempo de trabajo para realizadas todas las tareas: {0} horas",Tiempo);
    
   
}


    switch (menu)
    {
        case 1:
        foreach (var item in pendientes)
        { 
           Console.WriteLine("TAREA {0}:",item.TareaID);
           Console.WriteLine("\t Descripcion: {0}",item.Descripcion);
           Console.WriteLine("\t Duracion: {0}",item.Duracion);
           Console.WriteLine(" "); 
        }
        break;

        case 2:
        foreach (var item in realizadas)
        { 
           Console.WriteLine("TAREA {0}:",item.TareaID);
           Console.WriteLine("\t Descripcion: {0}",item.Descripcion);
           Console.WriteLine("\t Duracion: {0}",item.Duracion);
           Console.WriteLine(" "); 
        }
        break;
       
        case 3:
           Console.WriteLine("Ingrese el id de la tarea a realizar: ");
           input2 = Console.ReadLine();
           id = int.Parse(input2);
           foreach (var item in pendientes)
           {
            if (item.TareaID == id)
            {
                realizadas.Add(item);
                
            }
           }
           foreach (var item in realizadas)
           {
            
                pendientes.Remove(item);
        
           }
           
           Console.WriteLine("Tarea Realizada! "); 

         
        break;

        case 4:
        Console.WriteLine("Ingrese la descripcion de la tarea: ");
        string busqueda = Console.ReadLine();
        bool encontrada = false;
        foreach (var item in pendientes)
        {
            if (item.Descripcion == busqueda)
            {
                Console.WriteLine("Tarea encontrada! ");
                Console.WriteLine("TAREA {0}:",item.TareaID);
                Console.WriteLine("\t Descripcion: {0}",item.Descripcion);
                Console.WriteLine("\t Duracion: {0}",item.Duracion);
                Console.WriteLine(" ");
                encontrada = true;
            }
        }
        if (encontrada == false)
        {
            Console.WriteLine(" ");
            Console.WriteLine("No se encontre la tarea");
            Console.WriteLine(" ");

        }
        break;
       
        case 5:
        Console.WriteLine("Adios!");
        break;
        default:
        Console.WriteLine("Ingrese un numero valido");
        break;
    }




} while (menu != 5);
