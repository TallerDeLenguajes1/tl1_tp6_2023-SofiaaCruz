# Ejercicio 4

### ¿String es una tipo por valor o un tipo por referencia?

String es un tipo de referencia. Esto significa que cuando creas una variable de string y le asignas un valor, la variable realmente contiene una referencia a la ubicación de memoria donde se almacenan los datos de la cadena.

### ¿Qué secuencias de escape tiene el tipo string?

\a	Campana (alerta)
\b	Retroceso
\f	Avance de página
\n	Nueva línea
\r	Retorno de carro
\t	Tabulación horizontal
\v	Tabulación vertical
\'	Comilla simple
\"	Comillas dobles
\\	Barra diagonal inversa
\?	Signo de interrogación literal
\ooo	Carácter ASCII en notación octal
\xhh	Carácter ASCII en notación hexadecimal
\xhhhh	Carácter Unicode en notación hexadecimal si esta secuencia de escape se utiliza en una constante de caracteres anchos o un literal de cadena Unicode.

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Si utilizas el carácter '@' antes de una cadena de texto , se indica la creación de una cadena verbatime, lo que significa que cualquier secuencia de escape dentro de la cadena (como \n para una nueva línea) se omite y se interpreta literalmente.
Si utilizas el carácter '$' antes de una cadena de texto , se indica la creación de una cadena interpolada, lo que significa que se pueden incluir expresiones dentro de la cadena utilizando llaves { }