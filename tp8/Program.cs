// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la ruta de la carpeta:");
string carpeta = Console.ReadLine();

if (Directory.Exists(carpeta))
{
    string[] archivos = Directory.GetFiles(carpeta);

    // Crear archivo "index.csv" y escribir los datos
    using (StreamWriter writer = new StreamWriter("index.csv"))
    {
        writer.WriteLine("Índice,Nombre,Extensión");

        for (int i = 0; i < archivos.Length; i++)
        {
            string nombreArchivo = Path.GetFileName(archivos[i]);
            string extension = Path.GetExtension(archivos[i]);
            writer.WriteLine($"{i + 1},{nombreArchivo},{extension}");
        }
    }

    Console.WriteLine("Listado de archivos guardado en \"index.csv\".");
}
else
{
    Console.WriteLine("La carpeta especificada no existe.");
}