// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

Console.WriteLine("Ingrese un numero: ");
if (int.TryParse(Console.ReadLine(), out int num)){

    int invertido = 0;

    while (num > 0){
        invertido = invertido*10 + num%10;
        num /= 10;
    }

    Console.WriteLine("El numero invertido es: " +invertido);
}
else{
    Console.WriteLine("No es un numero");
}