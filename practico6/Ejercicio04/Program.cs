// See https://aka.ms/new-console-template for more information

/*OBTENER LA LONGITUD DE UNA CADENA*/ 

string? cadena1, cadena2;

do{
    Console.Write("\nIngrese una cadena: ");
    cadena1 = Console.ReadLine();
}while(string.IsNullOrEmpty(cadena1)); 

Console.WriteLine($"\nLa longitud de la cadena \"{cadena1}\" es: " + cadena1.Length);

/*CONCATENAR CADENAS*/

do{
    Console.Write("\nIngrese una segunda cadena: ");
    cadena2 = Console.ReadLine();
}while(string.IsNullOrEmpty(cadena2));

string concatenadas = cadena1 + " " +cadena2;

Console.Write("\nLas cadenas concatenadas: "+ concatenadas);

/*EXTRAER UNA SUBCADENA*/

string? x;
bool bandera = false;
int inicio, lon=0;

do{

    Console.Write("\n\nDe esta cadena \""+ concatenadas + "\" ingrese desde que posición desea formar una subcadena: ");
    x = Console.ReadLine();

}while(!int.TryParse(x, out inicio) && string.IsNullOrEmpty(x));

while(bandera == false){

    do{
        Console.Write("\n\nAhora ingrese la longitud deseada de la subcadena: ");
        x = Console.ReadLine();
    }while(!int.TryParse(x, out lon) && string.IsNullOrEmpty(x));

    if(lon > (concatenadas.Length - inicio)){
        Console.Write("\nLa Longitud ingresada no puede ser utilizada, intente nuevamente");
    }
    else{
        bandera = true;
    }
}

string subcadena = concatenadas.Substring(inicio,  lon);

Console.Write("\nLa subcadena es: " + subcadena); 

/*RECORRER LA CADENA CON UN CICLO FOREACH*/

Console.Write("\n\nMostrando elemento por elemento de las cadenas concatenadas");

foreach(char t in concatenadas) {

    Console.Write("\n" + t);

}

/*BUSCAR UNA PALABRA*/

do{

    Console.Write("\n\nIngrese una plabra que quiera buscar en la cadena\""+concatenadas+"\" :");
    x  = Console.ReadLine();

}while(string.IsNullOrEmpty(x));

int cont = 0;
int indice = concatenadas.IndexOf(x);

while(indice != -1){
    cont++;
    indice = concatenadas.IndexOf(x, indice+1);
}

Console.Write($"\n\nLa palabra \"{x}\" aparece {cont} veces en la cadena");

/*CONVERTIR CADENA A MAYÚSCULAS Y MINÚSCULAS*/

string? MayuscualasT = concatenadas.ToUpper();
string? minusculasT = concatenadas.ToLower();

Console.Write($"\n\nEl textor en mayusculas es: \"{MayuscualasT}\" \nEl texto en minusculas es:\"{minusculasT}\"");

/*CADENA SEPARADA POR UN CARACTER*/

string? cadena;

do{
    Console.WriteLine("\n\nIngrese una cadena separada por caracteres:");
    cadena = Console.ReadLine();
}while(string.IsNullOrEmpty(cadena));

Console.Write("\nIngrese el carácter separador: ");
string? separador = Console.ReadLine();
Console.WriteLine();

string[] resultado = cadena.Split(separador);

foreach (string palabra in resultado)
{
    Console.Write(palabra +" ");
}

int op;
do{
    string? ecuacion;
    char operador;
    int i = 0, aux = 0, num1, num2;

/*CALCULADORA*/
    do {

        Console.Write("\n\nIngrese una ecuacion simple: ");
        ecuacion = Console.ReadLine();

    }while(string.IsNullOrEmpty(ecuacion));


    while (i < ecuacion.Length){

        if(ecuacion[i] == '+' || ecuacion[i] == '-' || ecuacion[i] == '*' || ecuacion[i] == '/'){
            aux = i;
            i = ecuacion.Length;
        }

        i++;
    }

    operador = ecuacion[aux];

    string?[] operandos = ecuacion.Split(operador);

    if(operandos.Length > 2 ){
        Console.Write("\n\nSolo puede ingresar ecuaciones simples");
    }
    else{
        if(!int.TryParse(operandos[0], out num1) || !int.TryParse(operandos[1], out num2)){
            Console.Write("\n\nExpresión invalida");
        }
        else{
            switch (operador){
                case '+':
                Console.Write($"\n\nEl resultado de {num1} {operador} {num2} es igual a {num1 + num2}");
                break;
                case '-':
                Console.Write($"\n\nEl resultado de {num1} {operador} {num2} es igual a {num1 - num2}");
                break;
                case '*':
                Console.Write($"\n\nEl resultado de {num1} {operador} {num2} es igual a {num1 * num2}");
                break;
                case '/':
                Console.Write($"\n\nEl resultado de {num1} {operador} {num2} es igual a {num1 / num2}");
                break;
            }
        }
    }

    Console.Write("\n\nDesea realizar otra operacion?\n1-SI\n2-NO\n>> ");
    int.TryParse(Console.ReadLine(), out op);
    while(op != 1 && op != 2){

        Console.Write("\n\nDebe ingresar una opcion valida");
        int.TryParse(Console.ReadLine(), out op);
    }

}while(op != 2);


