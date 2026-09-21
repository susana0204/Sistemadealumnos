using Sistemadealumnos;

Alumno alumno1 = new Alumno("Juan", 33);
Alumno alumno2 = new Alumno("María",88);

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

Alumno alumno = new Alumno(nombre:" juan", 33);
decimal promedio = alumno.Promedio();
Console.WriteLine(promedio);

Console.WriteLine($"{alumno1.Nombre} - Promedio: {alumno1.Promedio()} - Aprobado: {alumno1.EstaAprobado()}");
Console.WriteLine($"{alumno2.Nombre} - Promedio: { alumno2.Promedio()} - Aprobado: {alumno2.EstaAprobado()}");

alumno2.SubirNota();
Console.WriteLine($"Después de SubirNota : {alumno2.Nombre} - Nota1: {alumno2.Nota1} - Nota2: {alumno2.Nota2} - Promedio: {alumno2.Promedio()} - Aprobado: {alumno2.EstaAprobado()}");

Alumno alumnoTope = new Alumno("FRANCO", 22);
alumnoTope.SubirNota();
Console.WriteLine($"{alumnoTope.Nombre} - Nota1: {alumnoTope.Nota1} - Nota2: {alumnoTope.Nota2}");

bool CargarNota = alumno1.CargarNotas(7, 23);
if (CargarNota)
{
     Console.WriteLine("Notas ya esta cargada");    
}
else
{
     Console.WriteLine("Notas no esta carga incorrecto");
}

List<Alumno> alumnos = new List<Alumno>();
int opcion;
bool opcionValida;

do
{
     Console.WriteLine("MENU DE OPCIONES");
     Console.WriteLine("1. Agregar alumno");
     Console.WriteLine("2. Listar alumnos");
     Console.WriteLine("3. Buscar alumno por legajo");
     Console.WriteLine("4. Promedio general del curso");
     Console.WriteLine("5. Cantidad de alumnos aprobados");
     Console.WriteLine("6. Salir");
     Console.Write("Elegí una opción: ");
     opcion = int.Parse(Console.ReadLine());
     opcionValida = opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5
                    || opcion == 5 || opcion == 6;
     if (!opcionValida)
     {
        Console.WriteLine("Opcion ingresada no valida. Intenta de nuevo");  
     }

     switch (opcion)
     {
          case 1:
               AgregarAlumno(alumnos);
               break;
          case 2:
               ListarAlumnos(alumnos);
               break;
          case 3:
               BuscarAlumno(alumnos);
               break;
          case 4:
               PromedioGeneral(alumnos);
               break;
          case 5:
               CantidadAprobados(alumnos);
               break;
          default:
               Console.WriteLine("Opción inválida. Elegí un número del 1 al 6.");
               break;
     }

} while (opcion != 6);

void AgregarAlumno(List<Alumno> lista)
{
     Console.Write("Nombre: ");
     string nombre = Console.ReadLine();

     Console.Write("Legajo: ");
     int legajo = int.Parse(Console.ReadLine());

     Console.Write("Nota 1: ");
     decimal nota1 = decimal.Parse(Console.ReadLine());

     Console.Write("Nota 2: ");
     decimal nota2 = decimal.Parse(Console.ReadLine());

     Alumno nuevo = new Alumno(nombre, legajo);
     lista.Add(nuevo);
     Console.WriteLine("Alumno agregado.");

     bool notacargada = nuevo.CargarNotas(nota1, nota2);
     if (!notacargada)
     {
          Console.WriteLine("Las notas deben estar entre 0 y 10. Se agregó el alumno sin notas cargadas.");
     }

}
void ListarAlumnos(List<Alumno> lista)
{
     if (lista.Count == 0)
     {
          Console.WriteLine("No hay Alumnos cargados.");
          return;
     }

     foreach (Alumno a in lista)
     {
          Console.WriteLine(a.ToString());
     }
}

void BuscarAlumno(List<Alumno> lista)
{
     Console.WriteLine("Ingresa el legajo el alumno");
     int legajo = int.Parse(Console.ReadLine());
     Alumno encontrado = null;
     foreach (var Alumno in lista )
     {
          if (alumno.Legajo == legajo)
          {
               encontrado = Alumno;
               break;
          }
     }

     if (encontrado == null)
     {
          Console.WriteLine("NO encontrado");
     }
     else
     {
          Console.WriteLine(encontrado.ToString());
     }
}
void PromedioGeneral(List<Alumno> lista)
{
     if (lista.Count == 0)
     {
          Console.WriteLine("No hay alumnos cargados todavía.");
          return;
     }
     decimal suma = 0;
     foreach (Alumno alumno in lista)
     {
          suma += alumno.Promedio(); 
     }
     decimal promedioGeneral = suma / lista.Count;
     Console.WriteLine($"El promedio general del curso: {promedioGeneral}");
}

void CantidadAprobados(List<Alumno> lista)
{
     int aprobados = 0;
     foreach (Alumno alumno in lista)
     {
          if (alumno.EstaAprobado())
          {
               aprobados++; 
          }
     }
     Console.WriteLine($"Cantidad de alumnos aprobados: {aprobados}");
}

