namespace EspacioTarea;
class Tarea
{
    private int tareaID; //Numerado en ciclo iterativo
    public int TareaID { get => tareaID; set => tareaID = value; }

    string descripcion;
    public string Descripcion { get => descripcion; set => descripcion = value; }

    private int duracion; // entre 10 – 100
    public int Duracion { get => duracion; set => duracion = value; }
}