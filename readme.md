# Práctica 1 - Scripts de Movimiento

**Asignatura:** Interfaces Inteligentes  
**Universidad:** Universidad de La Laguna  
**Titulación:** Grado en Ingeniería Informática  
**Curso:** 2026/2027  
**Fecha:** 2 de octubre de 2026

Repositorio con los scripts desarrollados para los ejercicios de movimiento en Unity. Cada ejercicio incluye una descripción de lo implementado, los hitos relevantes y una prueba de ejecución en GIF.

## Estructura del repositorio

```
.
├── readme.md
├── ChangeColor.cs
├── DistanceToObjects.cs
└── VectorOperations.cs
```

## Índice

1. [Ejercicio 1: Color aleatorio cada N frames](#ejercicio-1)
2. [Ejercicio 2: Operaciones con vectores](#ejercicio-2)
3. [Ejercicio 3: Posición de la esfera](#ejercicio-3)
4. [Ejercicio 4: Distancia del cubo y el cilindro a la esfera](#ejercicio-4)

<a id="ejercicio-1"></a>
## Ejercicio 1: Color aleatorio cada N frames

**Script:** `ChangeColor.cs`

**Qué hace:** inicializa un vector de 3 posiciones con valores entre 0.0 y 1.0, que se interpreta como color RGB. Cada `waitingFrames` frames elige una posición aleatoria del vector, le asigna un nuevo valor aleatorio y aplica el color resultante al material del objeto.

**Hitos relevantes:**
- Variable pública `waitingFrames` (por defecto 120), editable desde el inspector.
- Uso de `Random.Range(0, 3)` para elegir la posición y `Random.Range(0f, 1f)` para el nuevo valor.
- Un contador de frames en `Update()` que se reinicia al llegar al valor configurado.
- El color se asigna con `GetComponent<Renderer>().material.color = new Color(values[0], values[1], values[2])`.

**Prueba de ejecución:**

[](./gifs/ejercicio_1.gif)

<a id="ejercicio-2"></a>
## Ejercicio 2: Operaciones con vectores

**Script:** `VectorOperations.cs`

**Qué hace:** declara dos `Vector3` públicos cuyos componentes se configuran desde el inspector y muestra por consola:

- **a)** La magnitud de cada vector (`Vector3.magnitude`).
- **b)** El ángulo que forman (`Vector3.Angle(v1, v2)`).
- **c)** La distancia entre ambos (`Vector3.Distance(v1, v2)`).
- **d)** Un mensaje indicando cuál de los dos está a mayor altura (comparando la componente `y`).

**Hitos relevantes:**
- Los resultados se guardan también en variables públicas (`magnitudeA`, `magnitudeB`, `angle`, `distance`) para verlos en el inspector.
- Se controla el caso en que las alturas son iguales.

**Prueba de ejecución:**

./docs/demo.gif

<a id="ejercicio-3"></a>
## Ejercicio 3: Posición de la esfera

**Script:** `VectorOperations.cs`

**Qué hace:** muestra por consola el vector con la posición de la esfera.

**Hitos relevantes:**
- La posición es una propiedad del componente `Transform`, que se obtiene con `transform.position`.

**Prueba de ejecución:**

https://github.com/user-attachments/assets/31b8e120-5076-402c-8c3d-801618fe077b

<a id="ejercicio-4"></a>
## Ejercicio 4: Distancia del cubo y el cilindro a la esfera

**Script:** `VectorOperations.cs`

**Qué hace:** muestra en consola la distancia a la que están el cubo y el cilindro respecto a la esfera.

**Hitos relevantes:**
- El cubo y el cilindro se localizan por etiqueta con `GameObject.FindWithTag("cube")` y `GameObject.FindWithTag("cylinder")`.
- A partir del `GameObject` se obtiene su `Transform` y se calcula `Vector3.Distance(transform.position, cubeTransform.position)`.
- Se necesita asignar las etiquetas `cube` y `cylinder` al cubo y al cilindro en el editor.

**Prueba de ejecución:**

https://github.com/user-attachments/assets/8039c26c-3639-47c5-b4a2-8efa6dfe27ff
