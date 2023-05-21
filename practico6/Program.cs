// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/


Console.WriteLine("ingrese dos numeros: ");

Console.Write("Num1: ");
string x = Console.ReadLine();

Console.Write("Num2: ");
string y = Console.ReadLine();

if(int.TryParse(x, out int num1) && int.TryParse(y, out int num2)){

    Console.Write("Elija una opcion:\n1- Sumar\n2- Restar\n3- Multiplicar\n4- Dividir >> ");

    bool aux = int.TryParse(Console.ReadLine(), out int opcion);

    while(!aux || opcion < 1 || opcion > 4){

        Console.Write("Elija una opcion:\n1- Sumar\n2- Restar\n3- Multiplicar\n4- Dividir >> ");

        aux = int.TryParse(Console.ReadLine(), out opcion);
    }

    int resultado=0;

    switch(opcion){
        case 1: resultado = num1+num2;
        break;
        case 2: resultado = num1-num2;
        break;
        case 3: resultado = num1*num2;
        break;
        case 4: resultado = num1/num2;
        break;
    }

    Console.WriteLine("El resultados es: " +resultado);

}
else{
    Console.WriteLine("Solo puede ingresar numeros");
}
