# StringCalculator
String Calculator Kata, utilzando Fluent Assertion, intentando no leer mas alla del requisito que estoy implementando en cada momento, realizando una tarea cada vez para aprender a realizar de manera incremental. Solo se tendran en cuenta para este ejercicio las entradas correctas.

## 1-Crea una calculadora de string simple

Con un método con la siguiente firma

```
int Add(string numbers)
```

El método puede tomar hasta dos números, separados por comas y debe devolver su suma.por euemplo "" o "1" o "1,2" son entradas validas.

(Para una cadena vacia devolvera 0)

Pistas:

+ Comienza con el test mas simple para una cadena vaciía, sigue provando el caso de un número y luego el caso de dos números.
+ Recuerda resolver las tareas de la forma más simple posible, para forzarte a escrbir casos de tes que quizá no se te ocurririan de otra forma.
+ Recuerda refactorizar tras lograr llegar a verde.

## 2-Añadir la posibilidad de que el método Add reciba una cantidad indeterminada de números

## 3-Añadir la posibilidad de que el método Add soporte retornos de carro como separador ( ademas de comas).

la siguente entrada es correcta "1\n2,3" ( el resultado seria 6)

## 4-Soportar diferentes separadores

Para cambiar de separador el comienzo de la cadena deberá contener una línea separada con este formato "//[delimiter]\n[numbers...]"

Por ejemplo "//;\n1;2" deeria devolver 3 siendo el separador por defecto ";"

La primera linea es opcional. Todos los escenarios implementados hasta el momento deben seguir funcionando.

## 5-No permitir numeros negativos

Llamar al método Add con un número negativo debera lanzar una excepción "negatives not allowed" y el numero negativo pasado como argumento 

Si hay multiples negativos, muestralos todos en el mensaje de la excepcion

----------------------------------------------------------------------------------------------------------------------------------------------------

PARA AQUI SI NO HAS CONSEGUIDO COMPLETAR LOS PASOS ANTERIORES EN MENOS DE 30 MINUTOS

----------------------------------------------------------------------------------------------------------------------------------------------------

## 6-Los números mayores a 1000 deberían ignorarse

Es decir, sumar 2 + 1001 = 2

## 7-Los speparadores ahora pueden ser de cualqueir longitud si se especifican con el siguiente formato: "//[delimiter]\n"

Por ejemplo "//[***]\n1***2***3" debe devolver 6.

## 8-Soportar múltiples separadores con este formato "//[delim1][delim2]\n"

Por ejemplo "//[*][%]\n1*2%3" debe devolver 6

## 9-Asegurate que soportan múltiples separadores cuando la longitud es mayor a un caracter.


[Curso Test Driven Development de Exeal ](https://academia.exeal.com/)
