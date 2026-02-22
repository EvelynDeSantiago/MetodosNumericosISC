# Métodos Numéricos ISC

En este repositorio se encuentra información acerca de lo mas relevante de metodos numericos asi como ejercicios y ejemplos.

# Introduccion

- [Definicion Metodos Numericos y para que sirven](#definicion-metodos-numericos-y-para-que-sirven)
- [Funcion](#funcion)

---

# Tema 2

- [Definicion Metodos de solucion de ecuaciones](#definicion-metodos-de-solucion-de-ecuaciones)

1. [Metodo de biseccion](#metodo-de-biseccion)
   - [Ejemplos Metodo de biseccion](#ejemplos-metodo-de-biseccion)

2. [Regla Falsa](#regla-falsa)
   - [Ejemplos Regla Falsa](#ejemplos-regla-falsa)

3. [Metodo Newton](#metodo-newton)
   - [Ejemplos Metodo Newton](#ejemplos-metodo-newton)

4. [Metodo de la Secante](#metodo-de-la-secante)
   - [Ejemplos Metodo de la Secante](#ejemplos-metodo-de-la-secante)

---

# Desarrollo

## Definicion Metodos Numericos y para que sirven

Los métodos numéricos son un conjunto de técnicas matemáticas que se utilizan para resolver 
problemas en los que se requiere obtener soluciones aproximadas o numéricas, 
especialmente cuando no es posible o práctico encontrar una solución 
exacta mediante métodos analíticos. 


Los métodos numéricos sirven para resolver una variedad de problemas en los que es 
necesario obtener soluciones aproximadas mediante cálculos numéricos. 
Algunas de las razones por las que se utilizan estos métodos incluyen:

---

## Funcion

Una función es una regla de correspondencia entre dos conjuntos de tal manera que a cada elemento 
del primer conjunto le corresponde uno y sólo un elemento del segundo conjunto.

---

# Tema 2

## Definicion Metodos de solucion de ecuaciones

Los métodos de solución de ecuaciones son técnicas o procedimientos utilizados para encontrar las soluciones 
de una ecuación dada. Una ecuación es una igualdad matemática que involucra una o más incógnitas, y su solución 
consiste en encontrar los valores de las incógnitas que hacen que la ecuación sea verdadera.

Existen varios métodos para resolver ecuaciones, y la elección del método adecuado depende de la naturaleza de la 
ecuación y de las herramientas matemáticas disponibles.La elección del método adecuado depende de varios factores, 
como la complejidad de la ecuación, la disponibilidad de herramientas matemáticas y la precisión requerida en la 
solución.

---

## Metodo de biseccion

El metodo de biseccion es un algoritmo utilizado para encontrar las raices de una funcion continua en un intervalo dado.  
Este metodo es simple pero efectivo y se basa en el teorema del valor intermedio.

El metodo de biseccion garantiza la convergencia a una raiz debido a que en cada iteracion se reduce a la mitad la longitud del intervalo que contiene la raiz. Sin embargo, puede ser relativamente lento en comparacion con otros metodos.

### Algoritmo

1. Definir el intervalo [a, b].
2. Calcular el punto medio: c = (a + b) / 2.
3. Evaluar f(c).
4. Si f(c) es cercano a 0, terminar.
5. Si f(a) y f(c) tienen signos opuestos, hacer b = c.
6. Si no, hacer a = c.
7. Repetir hasta alcanzar la tolerancia deseada.

### Implementacion en C#

```csharp
using System;

class Program
{
    static double Funcion(double x)
    {
        return Math.Pow(x, 3) - x - 2;
    }

    static double Biseccion(double a, double b, double tolerancia)
    {
        double c;

        if (Funcion(a) * Funcion(b) > 0)
        {
            Console.WriteLine("No hay cambio de signo en el intervalo.");
            return double.NaN;
        }

        while ((b - a) >= tolerancia)
        {
            c = (a + b) / 2;

            if (Math.Abs(Funcion(c)) < tolerancia)
                return c;

            if (Funcion(a) * Funcion(c) < 0)
                b = c;
            else
                a = c;
        }

        return (a + b) / 2;
    }

    static void Main()
    {
        double raiz = Biseccion(1, 2, 0.0001);
        Console.WriteLine("La raiz aproximada es: " + raiz);
    }
}
```

---

### Ejemplos Metodo de biseccion


Los ejemplos se encuentran en la carpeta:

[Ver ejemplos de biseccion](./Ejemplos_Biseccion)

---

## Regla Falsa

Aqui va la informacion...

### Ejemplos Regla Falsa

Aqui van los ejemplos...

---

## Metodo Newton

Aqui va la informacion...

### Ejemplos Metodo Newton

Aqui van los ejemplos...

---

## Metodo de la Secante

Aqui va la informacion...

### Ejemplos Metodo de la Secante

Aqui van los ejemplos...as permiten analizar el comportamiento de funciones matemáticas y obtener soluciones aproximadas mediante procedimientos computacionales.n analizar el comportamiento de funciones matemáticas y obtener soluciones aproximadas mediante procedimientos computacionales.oritmos y cálculos repetitivos (iteraciones) que permiten encontrar resultados con un margen de error controlado. Son fundamentales en áreas como ingeniería, física, economía y programación, ya que muchos problemas reales requieren soluciones aproximadas obtenidas con ayuda de computadoras.