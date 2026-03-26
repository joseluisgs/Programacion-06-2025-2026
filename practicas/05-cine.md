
# 🕶️ CINE-DAW

> *"La vida es como una caja de chocolates, nunca sabes lo que te va a tocar."* — **Forrest Gump**

### 📝 1. El Regreso del Sistema

Ya conocemos nuestro cine. Lo que no sabíamos es que regresaría para ayudarnos a avanzar un poco como programadores. Nuestro cine tiene una sola sala, la cual tiene un número determinado de **butacas** organizadas en filas y columnas.

Debemos saber que existen tres tipos de sectores: **butacas normales**, **butacas VIP** y **butacas de ofertas**. Una butaca tiene:

* Un identificador único y una fecha de creación.
* Coordenadas (fila y columna).
* Un estado: **LIBRE**, **OCUPADO** o **RESERVADO**.
* Un precio base que debemos iniciar al comenzar el sistema.

### 🧩 2. Configuración e Identidad

El acceso al sistema está restringido:

* **Administrador:** Es un usuario especial. Al comenzar, se debe pedir su nombre de usuario, que siempre serán tres letras (a-z) seguidas de tres dígitos (ej. `ad123`, `jod333`).
* **Usuarios:** Para cualquier otro usuario necesitaremos su nombre real y su correo electrónico.

**Protocolo de la Sala:**
Iniciaremos la configuración indicando el número de **filas** (entre 4 y 10) y de **columnas** (5 y 15).

* **Distribución:** Indicaremos el número de butacas de Oferta (1 a 5) y VIP (3 a 10). El resto serán normales.
* **Precios:** Oferta (5,00€ a 7,00€), Normales (7,00€ a 10,00€) y VIP (10,00€ a 15,00€).
* **Complementos VIP:** Si la butaca es VIP, el usuario puede añadir un complemento: Palomitas (3€), Bebida (5€) o Completo (7€).
* **Referencia Espacial:** Las filas se referencian con letras (A, B, C...). Si hay 5 filas, serán A, B, C, D, E. *Sugerencia: aprende a sumar caracteres.*

> **Nota del Arquitecto:** Con estos datos crearás un objeto de configuración para instanciar la sala. Su **instancia debe ser única**.

### ⚡ 3. El Menú de la Matrix

Una vez dentro, el sistema presentará las siguientes opciones:

* **Ver estado de la sala:** Imprime el mapa de la sala. Usa colores o emoticonos para diferenciar estados (libre, ocupado, reservado) y tipos (VIP, normal, oferta). Muestra siempre la letra de la fila y el número de columna.
* **Reservar una butaca:** Dada una coordenada (ej. `B3`), reservará la butaca. Las reservas se guardan en un repositorio **ordenado por filas** (y columnas en caso de empate). Cada reserva incluye: ID, butaca, momento y el ID del cliente.
* **Anular reserva:** Localiza la reserva por coordenadas (ej. `B3`), busca en el repositorio y devuelve la butaca a su estado anterior.
* **Comprar entrada:** Se piden datos del usuario y coordenada (ej. `C4`). Si estaba reservada por el mismo usuario, se confirma. Se genera un **Ticket** con: ID, butaca, tipo, precio (con complementos si es VIP), momento y nombre del administrador. Los tickets se ordenan de **más nuevo a más antiguo**.
* **Devolver entrada:** Dado el ID del Ticket, se anula y la butaca queda libre.
* **Ver reservas / Ver ventas:** Muestra los listados según el orden indicado.
* **Recaudación:** Muestra el importe total de tickets vendidos.
* **Informe:** Balance total de reservas, libres, vendidas, porcentaje de ocupación, recaudación y desglose detallado por tipo de butaca y estado.

### ⚠️ 4. Reglas de las Máquinas

Para que la simulación sea aceptada, debes cumplir estos protocolos técnicos:

* **TDA Genérico:** Todas las estructuras de datos deben ser dinámicas y **Genéricas**, preparadas para cualquier tipo de dato.
* **Interfaces:** Los comportamientos deben implementarse basándose en interfaces.
* **Validación:** Todas las entradas y filtros de datos deben usar **expresiones regulares**.
* **Precisión:** Todas las salidas con decimales deben estar limitadas a **2 decimales**.
* **Arquitectura:** Realiza un diagrama de clases y un diagrama de secuencia antes de implementar.

---

**"Cualquier cosa que supongas debes analizarla con cuidado y justificar su uso."**

**¿Estás preparado para tomar el control del CineDAW?**