

# 🕶️ EL EQUIPO DE SIÓN (NODO FOOTBALL)

> *"La realidad es una ilusión, aunque muy persistente."* - Albert Einstein

### 📝 1. El Escenario

Las máquinas han creado una simulación deportiva para mantener entretenidos a los humanos conectados. Sin embargo, la resistencia en Sión necesita identificar a los mejores "Jugadores" para una misión de infiltración. Debes programar un sistema que gestione la plantilla de un equipo de fútbol.

### 🧩 2. Definición de Entidades (Jugadores)

Cada **Jugador** en la Matrix se identifica por:

* **DNI/ID Único:** (No puede haber dos jugadores con el mismo ID).
* **Nombre**, **Dorsal** y **Valor de Mercado**.
* **Tipo de Jugador:**
* **Portero:** Tiene un atributo específico de **Reflejos (0-100)**.
* **Jugador de Campo:** Tiene un atributo de **Resistencia (0-100)** y una **Posición** (Defensa, Medio, Delantero).



**Requisitos:**

* No utilices herencia de clases. Define el comportamiento común mediante una **Interfaz** (ej. `IJugador`).
* Implementa los métodos `Pedir()` y `Mostrar()` para cada tipo.
* El equipo no permite **elementos repetidos** (debes asegurar esto mediante el ID al insertar en la colección).

### ⚡ 3. El Oráculo Funcional (Funciones de Extensión)

Para manipular la información, no puedes usar los métodos por defecto del sistema. Debes programar tus propias **Funciones de Extensión** en una clase estática para cualquier `List<IJugador>`:

1. **`Filtrar(Func<IJugador, bool> predicado)`**: Debe devolver una nueva lista con los jugadores que cumplan la condición (equivalente a un *Filter*).
2. **`ContarSi(Func<IJugador, bool> predicado)`**: Debe devolver el número de jugadores que cumplen la condición (equivalente a un *CountIf*).
3. **`Buscar(Func<IJugador, bool> predicado)`**: Debe devolver el primer jugador que cumpla la condición o `null` si no existe (equivalente a un *Find*).

> **Nota:** Estas funciones deben trabajar con **Delegados o Lambdas**.

### 📊 4. Dinámica de la Simulación (Consultas)

Utilizando tus funciones de extensión, el programa debe mostrar por consola:

* **Listado de Porteros** con reflejos superiores a 80.
* **Búsqueda** del jugador con el dorsal número 10.
* **Conteo** de cuántos "Jugadores de Campo" tienen una resistencia mayor a 70.
* **Recaudación:** Valor de mercado total de todos los jugadores (puedes añadir una función de extensión `Sumar` si te sientes inspirado).

### ⚠️ 5. Reglas de las Máquinas

* **Robustez:** El sistema debe validar que los dorsales estén entre 1 y 99 y que los nombres no estén vacíos.
* **Colecciones:** Utiliza la colección que consideres más adecuada para evitar repetidos de forma eficiente.
* **Precisión:** Todos los valores monetarios deben mostrarse con **2 decimales**.

---

**"No intentes doblar la cuchara (o el balón), eso es imposible. En su lugar, intenta comprender la verdad... que no hay balón, solo un `List<T>`."**
