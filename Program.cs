// En un curso de estudiantes que aun no se matriculam // se ha realizado dos examenes de entrada // se necesita ingresar dichas notas de todos los estudiantes

System.Console.WriteLine("Ingreso de notas de Curso");
int x = 0;
while (x == 0)
{
    for (int i = 1; i < 4; i++)
    {
        System.Console.WriteLine("Ingrese nota " + i);
        int nota = int.Parse(Console.ReadLine());
    }

    System.Console.WriteLine("Necesita ingresar nuevo estudiante? (s/n)");
    char estudiante = char.Parse(Console.ReadLine());
    if (estudiante == 's') x = 0;
    else x = 1;
}
