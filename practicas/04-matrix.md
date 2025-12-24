

# 🕶️ BIENVENIDO AL MUNDO REAL (MATRIX JL)

> *"¿Qué es real? ¿Cómo defines 'real'? Si estás hablando de lo que puedes sentir, lo que puedes oler, lo que puedes saborear y ver, entonces 'real' son simplemente señales eléctricas interpretadas por tu cerebro."* — **Morpheus**

### 📝 1. El Secuestro

La historia comienza con un secuestro. Éramos programadores en la nave *Nebuchadnezzar*, tan buenos, tan buenos, que las máquinas nos han secuestrado. Necesitan que un programador humano les haga una simulación, ya que sólo un humano es capaz de captar pequeñas sutilezas que las máquinas son incapaces de percibir.

Los cacharros estos están algo preocupadillos por la evolución del **virus Smith**, la influencia de **Neo** en el sistema y la tendencia que tienen el resto de los **personajes** a morir inesperadamente.

### 🧩 2. Definición de Entidades

En Matrix, los personajes tienen un **id**, un **nombre**, una **localización** (compuesta de latitud y longitud de localización principal y nombre de la ciudad de nacimiento) y una **edad**. También tendrán una **fecha de creación** en el sistema.

Sin embargo, el sistema presenta anomalías específicas:

* **Agente Smith:** Además tendrá un número porcentaje que indicará su **capacidad de infectar**.
* **Neo:** Tendrá un atributo para indicar si se cree que es **el elegido** o no.
* **Personajes genéricos:** Tendrán, además, un número porcentaje con la **probabilidad de morir** que tienen.

**Protocolos obligatorios:**

* Todos los personajes deben implementar los métodos `Generar()`, `Pedir()` y `Mostrar()`.
* Debemos permitir la creación de personajes genéricos.
* Debemos llevar la cuenta del **total de personajes creados**.

### 🛡️ 3. El Almacén Genérico

Debes programar un **Almacén Genérico** para el manejo de esta información. Debemos ser capaces de gestionar cualquier tipo de personaje con nuestro almacén. Las máquinas no aceptan estructuras rígidas; el almacén debe ser la base de toda la simulación.

### ⚡ 4. Dinámica de la Simulación

Las máquinas nos dicen que en cada actuación de personaje debemos mostrar un mensaje, para ver lo que pasa y ayudarnos a saber que nuestro programa funciona bien. El flujo del tiempo en la Matrix es el siguiente:

* Cada **10 segundos** aparecen 5 personajes en Matrix desde nuestro almacén si hay hueco disponible.
* Cada **30 segundos** podemos introducir un nuevo personaje genérico, pidiéndole los datos por consola.

### 📊 5. Salida y Consultas

Al final de la simulación, aparte del estado del sistema (estado de la Matrix y la posición de Neo), el Oráculo nos exige:

1. La lista de personajes generados por el sistema y ordenados por su **id**.
2. La lista de **virus Smith** ordenada por **fecha** de manera descendente.

### ⚠️ 6. Reglas de las Máquinas

* **Clase Auxiliar:** Las máquinas son muy organizadas y nos sugieren amablemente, retorciéndonos un poco un brazo, que todas las funciones auxiliares (leer un entero, leer un real o generar un número al azar) estén organizadas en una clase auxiliar (yo les haría caso).
* **Robustez:** Nuestro programa debe ser robusto; es decir, que se controlen posibles errores.
* **Documentación:** Debes realizar el **Diagrama de Clases** y un gráfico que muestre cómo funciona todo el tinglado este que se trae la simulación con las máquinas.

---

### 📤 La Elección Final

Como recompensa, nos darán a elegir las famosas pastillitas. Si elegimos la azul..., bueno, eso será otra historia. Aunque lo mismo prefieres un buen aprobado.

> *"Programar sin una arquitectura o diseño en mente es como explorar una gruta sólo con una linterna: no sabes dónde estás, dónde has estado ni hacia dónde vas"* — **Danny Thorpe**

**¿Pastilla roja o pastilla azul? Tú eliges.**
