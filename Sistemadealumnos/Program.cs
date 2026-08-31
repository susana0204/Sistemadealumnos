using Sistemadealumnos;

Alumno alumno1 = new Alumno("Juan", 123, 8, 9);
Alumno alumno2 = new Alumno("María", 124, 7, 10);

Console.WriteLine(alumno1.Nombre);
Console.WriteLine(alumno1.Legajo);
Console.WriteLine(alumno2.Nombre);
Console.WriteLine(alumno2.Legajo);

alumno1.Nombre = "Franco";

Console.WriteLine(alumno1.Nombre);
Console.WriteLine(alumno2.Nombre);// Etapa 1 — La primera clase

// Alumno alumno3 = new Alumno();  corresponde sin datos. Anotar el error y explicar por qué aparece.
// ya que me da error pq no hay datos suficiente para cumplir los paramentro que obligatorio del alumno
// ademas c# no permite crear el objeto sin parametro