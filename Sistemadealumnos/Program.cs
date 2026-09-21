using Sistemadealumnos;

Alumno alumno1 = new Alumno("Juan", 123, 8, 9);
Alumno alumno2 = new Alumno("María", 124, 7, 10);

Console.WriteLine(alumno1.Nombre);
Console.WriteLine(alumno1.Legajo);
Console.WriteLine(alumno2.Nombre);
Console.WriteLine(alumno2.Legajo);

//alumno1.Nombre = "Franco";

//Console.WriteLine(alumno1.Nombre);
//Console.WriteLine(alumno2.Nombre);// Etapa 1 — La primera clase

// Alumno alumno3 = new Alumno();  corresponde sin datos. Anotar el error y explicar por qué aparece.
// ya que me da error pq no hay datos suficiente para cumplir los paramentro que obligatorio del alumno
// ademas c# no permite crear el objeto sin parametro

Alumno alumno = new Alumno("Juan", 123, 8, 9);
decimal promedio = alumno.Promedio();
Console.WriteLine(promedio);

Console.WriteLine($"{alumno1.Nombre} - Promedio: {alumno1.Promedio()} - Aprobado: {alumno1.EstaAprobado()}");
Console.WriteLine($"{alumno2.Nombre} - Promedio: { alumno2.Promedio()} - Aprobado: {alumno2.EstaAprobado()}");

alumno2.SubirNota();
Console.WriteLine($"Después de SubirNota : {alumno2.Nombre} - Nota1: {alumno2.Nota1} - Nota2: {alumno2.Nota2} - Promedio: {alumno2.Promedio()} - Aprobado: {alumno2.EstaAprobado()}");

Alumno alumnoTope = new Alumno("FRANCO", 112, nota1:8.9m, 9.5m);
alumnoTope.SubirNota();
Console.WriteLine($"{alumnoTope.Nombre} - Nota1: {alumnoTope.Nota1} - Nota2: {alumnoTope.Nota2}");


