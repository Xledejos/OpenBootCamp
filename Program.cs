Console.WriteLine("Ejercicio 1 - WHILE");
Console.Write("Escribe un numero: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = 1;

while (num2 < 11)
{
    int resultado = num1 * num2;
    Console.WriteLine(num1 + "x" + num2 + "=" + resultado);
    num2++;
}

Console.ReadKey();

Console.WriteLine();

Console.WriteLine("Ejercicio 2 - DO WHILE");
int miNumero;
int intentos = 0;
int positivos = 0;
int negativos = 0;


do
{
    intentos++;
    Console.Write("Escribe un numero mayor o menor que cero " + intentos + " : ");
    miNumero = Convert.ToInt32(Console.ReadLine());
    if (miNumero > 0) positivos++;
    if (miNumero < 0) negativos++;

}
while (intentos < 5);

Console.WriteLine($"Tienes {positivos} numeros positivos y {negativos} numeros negtivos");

Console.WriteLine();

Console.WriteLine("Ejercicio 3 - FOR");

Console.Write("Dame el alto: ");
int alto = Convert.ToInt32(Console.ReadLine());
Console.Write("Dame el ancho: ");
int ancho = Convert.ToInt32(Console.ReadLine());
Console.Write("Cuantas veces quieres que se repita: ");
int veces = Convert.ToInt32(Console.ReadLine());    
int contador = 0;
bool relleno = true;

do
{
    for (int i = 1; i <= alto; i++)
    {
        for (int j = 1; j <= ancho; j++)
        {
            Console.Write(" ");
        }        

        //linea central
        for (int k = 1; k <= veces; k++)
        {
            Console.WriteLine("Esto se acaba de agregar");
        }

        Console.WriteLine("*");
        
    }
    contador++;
}

while (contador < veces);

Console.ReadKey();