using Sistemadealumnos;

Alumno alumno1= new Alumno()
{
    Nombre = "Julian",
    Legajo = 12345,
};
Alumno alumno2 = new Alumno()
{
    Nombre = "Candela",
    Legajo = 67890,
};

Console.WriteLine(alumno1.Nombre);
Console.WriteLine(alumno1.Legajo);
Console.WriteLine(alumno2.Nombre);
Console.WriteLine(alumno2.Legajo);

alumno1.Nombre = "Franco";
Console.WriteLine(alumno1.Nombre);
Console.WriteLine(alumno2.Nombre);//Etapa 1 — La primera clase