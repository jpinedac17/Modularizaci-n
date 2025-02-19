int programa;
int num1 = 0;
int num2 = 0;


// Calculadora básica
void CalculadoraBasica() {
    int opcion;
    bool esNumero;

    static int resta(int n1, int n2)
{
    int resultado = 0;
    resultado = n1 - n2;
    return resultado;
}

static int suma(int n1, int n2)
{
    int resultado;
    resultado = n1 + n2;
    return resultado;
}

static int multiplicacion(int n1, int n2)
{
    int resultado = 0;
    resultado = n1 * n2;
    return resultado;
}

static int division(int n1, int n2)
{
    int resultado = 0;
    resultado = n1 / n2;
    return resultado;
}

void ValidarNumero(ref int numero) {
    esNumero = int.TryParse(Console.ReadLine(), out numero);

    while (!esNumero)
    {
        Console.WriteLine("Escribe un número válido");
        esNumero = int.TryParse(Console.ReadLine(), out numero);
    }
}

Console.WriteLine("Escribe el primer número");
ValidarNumero(ref num1);

Console.WriteLine("Escribe el segundo número");
ValidarNumero(ref num2);

Console.WriteLine("Elige una opción:");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicación");
Console.WriteLine("4. División");
opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        int resultadoSuma = suma(num1, num2);
        Console.WriteLine($"El resultado de la suma es: {resultadoSuma}");
        break;
    case 2:
        int resultadoResta = resta(num1, num2);
        Console.WriteLine($"El resultado de la resta es: {resultadoResta}");
        break;
    case 3:
        int resultadoMultiplicacion = multiplicacion(num1, num2);
        Console.WriteLine($"El resultado de la multiplicación es: {resultadoMultiplicacion}");
        break;
    case 4:
        int resultadoDivision = division(num1, num2);
        Console.WriteLine($"El resultado de la división es: {resultadoDivision}");
        break;
    default:
        Console.WriteLine("Escribe una opción valida");
        break;
}
}

// Validación de contraseña
void ValidarPassword() {
    int contraseña = 1234;

    Console.WriteLine("Escribe la contraseña");
    int contraseñaUsuario = int.Parse(Console.ReadLine());

    if (contraseñaUsuario == contraseña) {
        Console.WriteLine("Contraseña correcta, acceso concedido");
    } else  {
        do {
            Console.WriteLine("Contraseña incorrecta, inténtalo de nuevo");
            contraseñaUsuario = int.Parse(Console.ReadLine());
        } while (contraseñaUsuario != contraseña);

        Console.WriteLine("Contraseña correcta, acceso concedido");
    }
}

// Números primos
void NumerosPrimos() {
    Console.WriteLine("Escribe un número para verificar si es primo");
    int numero = int.Parse(Console.ReadLine());

    int contador = 0;

    for (int i = 1; i <= numero; i++) {
        if (numero % i == 0) {
            contador++;
        }
    }

    if (contador == 2) {
        Console.WriteLine($"El número {numero} es primo");
    } else {
        Console.WriteLine($"El número {numero} no es primo");
    }
}

// Suma de números pares
void SumarEnteros() {
    int numero = 1;
    int resultado = 0;

    while(numero != 0) {
        Console.WriteLine("Escribe un número entero (0 para terminar)");
        numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0) {
            resultado += numero;
        }
    }

    Console.WriteLine($"La suma de los números pares es: {resultado}");
}

// Conversion de temperatura
static void ConvertirCelsiusAFahrenheit()
{
    Console.WriteLine("Ingrese la temperatura en grados Celsius");
    string entrada = Console.ReadLine();
    if (double.TryParse(entrada, out double celsius))
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius} grados Celsius son {fahrenheit} grados Fahrenheit");
    }
    else
    {
        Console.WriteLine("Entrada no válida, por favor ingrese un número");
    }
}

static void ConvertirFahrenheitACelsius()
{
    Console.WriteLine("Ingrese la temperatura en grados Fahrenheit");
    string entrada = Console.ReadLine();
    if (double.TryParse(entrada, out double fahrenheit))
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} grados Fahrenheit son {celsius} grados Celsius");
    }
    else
    {
        Console.WriteLine("Entrada no válida, por favor ingrese un número");
    }
}

void ConversionTemperatura() {
    int opcion;

    Console.WriteLine("Elige la conversión que deseas realizar: ");
    Console.WriteLine("1. Convertir grados Celsius a Fahrenheit");
    Console.WriteLine("2. Convertir grados Fahrenheit a Celsius");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion) {
        case 1:
            ConvertirCelsiusAFahrenheit();
            break;
        case 2:
            ConvertirFahrenheitACelsius();
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    } 
}

// Contador de vocales
static void ContadorDeVocales()
{
    Console.WriteLine("Ingrese una frase");
    string frase = Console.ReadLine();
    int numeroDeVocales = ContarVocales(frase);
    Console.WriteLine($"La frase contiene {numeroDeVocales} vocales");
}

static int ContarVocales(string texto)
{
    int contador = 0;
    string vocales = "aeiouAEIOU";
    foreach (char c in texto)
    {
        if (vocales.Contains(c))
        {
            contador++;
        }
    }
    return contador;
}

// Calcular factorial
void CalcularFactorial() {
    int numero;

    Console.WriteLine("Escribe un número para calcular su factorial");
    numero = int.Parse(Console.ReadLine());

    int factorial = 1;

    for (int i = 1; i <= numero; i++) {
        factorial *= i;
    }

    Console.WriteLine($"El factorial de {numero} es: {factorial}");
}

// Juego de adivinanza
void JuegoAdivinanza() {
    int numeroAleatorio = new Random().Next(1, 100);
    int numeroUsuario;

    Console.WriteLine("Adivina el número entre 1 y 100:");
    numeroUsuario = int.Parse(Console.ReadLine());

    while (numeroUsuario != numeroAleatorio) {
        if (numeroUsuario < numeroAleatorio) {
            Console.WriteLine("Demasiado bajo");
        } else {
            Console.WriteLine("Demasaio alto");
        }

        Console.WriteLine("Inténtalo de nuevo:");
        numeroUsuario = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("¡Felicidades! Adivinaste el número");
}

// Paso por referencia: intercambiar números
void PasoPorReferencia() {
    int num1, num2;

    static void Intercambiar(ref int numero1, ref int numero2)
    {
        int temp = numero1; 
        numero1 = numero2;
        numero2 = temp;    
    }

    Console.WriteLine("Escribe el primer número");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Escribe el segundo número");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Antes del intercambio: primer número = {num1}, segundo número = {num2}");

    Intercambiar(ref num1, ref num2);

    Console.WriteLine($"Después del intercambio: primer número = {num1}, segundo número = {num2}");
}

// Tabla de multiplicar
void TablaMultiplicar() {
    int numero;

    Console.WriteLine("Escribe un número para mostrar su tabla de multiplicar");
    numero = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++) {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}

Console.WriteLine("Elige uno de los siguientes programas:");

Console.WriteLine("1. Calculadora básica"); 
Console.WriteLine("2. Validación de contraseña"); 
Console.WriteLine("3. Número primos"); 
Console.WriteLine("4. Suma de números pares"); 
Console.WriteLine("5. Conversión de temperatura"); 
Console.WriteLine("6. Contador de vocales");
Console.WriteLine("7. Cálculo de factorial");   
Console.WriteLine("8. Juego de adivinanza"); 
Console.WriteLine("9. Paso por referencia"); 
Console.WriteLine("10. Tabla de multiplicar"); 
programa = int.Parse(Console.ReadLine());

switch (programa) {
    case 1:
        CalculadoraBasica();
        break;
    case 2:
        ValidarPassword();
        break;
    case 3:
        NumerosPrimos();
        break;
    case 4:
        SumarEnteros();
        break;
    case 5:
        ConversionTemperatura();
        break;
    case 6:
        ContadorDeVocales();
        break;
    case 7:
        CalcularFactorial();
        break;
    case 8:
        JuegoAdivinanza();
        break;
    case 9:
        PasoPorReferencia();
        break;
    case 10:
        TablaMultiplicar();
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}