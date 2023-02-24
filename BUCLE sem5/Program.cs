//Creacion de bucle
Console.WriteLine("Ingresa el primer valor:");
int inicio = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el valor final");
    int final = int.Parse(Console.ReadLine());

    Console.WriteLine("Los numeros pares en el rango[{0},{1}]son:", inicio, final);
        for (int i = inicio; i <= final; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " ");
            }
        }