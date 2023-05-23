// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/

int opcion, a;
double num, resultado=0, b, c;

do{
    Console.Write("Que desea hacer?\n1-Calcular el valor absoluto de un numero\n2-Calcular el cuadrado de un numero\n3-Calcular la raiz cuadrada de un numero\n4-Calcular el seno de un numero\n5-Calcular el coseno de un numero\n6-La parte entera de un float\n0-SALIR\n>> ");
    string? x = Console.ReadLine();

    while (!int.TryParse(x, out opcion) || opcion < 0 || opcion > 6){

        Console.Write("\n\nDebe ingresar una opción valida\n>> ");
        x = Console.ReadLine();

    }

    if (opcion != 0){

        Console.Write("Ingrese un número: ");
        string? y = Console.ReadLine();

        while(!double.TryParse(y, out num)){
            Console.Write("\nDebe ingresar un número: ");
            y = Console.ReadLine();
        }


        switch(opcion){
            case 1: resultado = Math.Abs(num); 
            break;
            case 2: resultado = num*num; 
            break;
            case 3: resultado = Math.Sqrt(num); 
            break;
            case 4: resultado = Math.Sin(num); 
            break;
            case 5: resultado = Math.Cos(num); 
            break;
            case 6: resultado = Math.Truncate(num);
            break;
        }

        Console.Write("El resultado es: "+ resultado);

        Console.Write("\n\nDesea realizar otra operación?\n1-SI\n2-NO\n>> ");
        int.TryParse(Console.ReadLine(), out a);

        while(a!=1 && a!=2){
            Console.Write("\nIngrese una opción valida");
            int.TryParse(Console.ReadLine(), out a);
        }
    }
    else{
        a = 2;
    }

    
} while (a != 2);

Console.WriteLine("\n\nIngrese dos números:");

Console.Write("\nNúmero1: ");
bool aux1 = double.TryParse(Console.ReadLine(), out b);
Console.Write("\nNúmero2: ");
bool aux2 = double.TryParse(Console.ReadLine(), out c);
        
while(!aux1 && !aux2){

    Console.Write("\nDebe ingresar solo números");
    Console.Write("\nNúmero1: ");
    aux1 = double.TryParse(Console.ReadLine(), out b);
    Console.Write("\nNúmero2: ");
    aux2 = double.TryParse(Console.ReadLine(), out c);

}

Console.Write("\n\nElija una opción:\n1-Mostrar el máximo entre estos dos números\n2-Mostrar el mínimo entre estos dos números\n0-Nada\n>> ");
string? eleccion = Console.ReadLine();
            
while(!int.TryParse(eleccion, out opcion) || opcion <0 || opcion>2){
    Console.Write("\n\nDebe elegir una opción valida: ");
    eleccion = Console.ReadLine();
}

if(opcion !=0){
    switch(opcion){
        case 1: if(c == b){
                    Console.Write("\nNo hay máximo entre estos números");
                }
                else{
                    if(b < c){
                        Console.Write("\nEl maximo es: "+c);
                    }
                    else{
                        Console.Write("\nEl maximo es: "+b);
                    }
                }
        break;
        case 2: if(c == b){
                    Console.Write("\nNo hay mínimo entre estos números");
                }
                else{
                    if(b > c){
                        Console.Write("\nEl mínimo es: "+c);
                    }
                    else{
                        Console.Write("\nEl mínimo es: "+b);
                    }
                }
        break;
    }
}