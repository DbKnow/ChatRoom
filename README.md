# 💬 Chat en Red Local

Aplicación de chat en tiempo real que permite a varios usuarios conectados a la **misma red Wi-Fi** comunicarse mediante salas de chat.

Este proyecto fue desarrollado como una práctica para aprender y aplicar conceptos relacionados con la **comunicación en tiempo real, conexiones dentro de una red local, SignalR, WebSockets, HTML y CSS**.

---

## 🚀 Características

* 💬 Envío de mensajes en tiempo real.
* 🌐 Comunicación entre dispositivos conectados a la misma red Wi-Fi.
* 🏠 Salas de chat.
* 🔐 Protección de las salas mediante contraseña.
* 👥 Varios usuarios pueden conectarse a una misma sala.
* ⚡ Actualización de mensajes en tiempo real mediante **SignalR**.
* 🎨 Interfaz de chat desarrollada con HTML y CSS.
* 📱 Acceso desde diferentes dispositivos conectados a la misma red.

---

## 🌐 ¿Cómo funciona?

La aplicación se ejecuta en un dispositivo que funciona como **servidor del chat**.

### 1. Iniciar la aplicación

Ejecuta la aplicación en el dispositivo que alojará el chat.

Desde ese mismo dispositivo puedes acceder utilizando:

```text
http://localhost:5265/Chat
```

### 2. Conectar otro dispositivo

Cualquier otro dispositivo conectado a la **misma red Wi-Fi** puede acceder utilizando la dirección IP del dispositivo donde se está ejecutando la aplicación:

```text
http://IP-SERVIDOR:5265/Chat
```

Por ejemplo:

```text
http://192.168.1.100:5265/Chat
```

> Reemplaza `IP-SERVIDOR` por la dirección IP local del dispositivo que está ejecutando la aplicación.

---

## 🔐 Salas de chat

Las salas de chat se configuran actualmente **directamente desde el código**.

La contraseña predeterminada de las salas es:

```text
1234
```

Esta contraseña también puede modificarse directamente desde el código.

> ⚠️ Esta configuración está pensada para fines de aprendizaje y desarrollo. Para un entorno real sería necesario implementar un sistema de autenticación y gestión de contraseñas más seguro.

---

## 🛠️ Tecnologías utilizadas

* **C#**
* **.NET**
* **SignalR**
* **WebSockets**
* **HTML5**
* **CSS3**
* **JavaScript**

---

## 📂 Estructura del proyecto

```text
Chat/
│
├── Controllers/
├── Hubs/
├── Views/
│   └── Chat/
│
├── wwwroot/
│   ├── css/
│   └── js/
│
├── Program.cs
└── ...
```

---

## ⚡ Comunicación en tiempo real

La aplicación utiliza **SignalR** para establecer la comunicación en tiempo real entre los usuarios conectados.

Cuando un usuario envía un mensaje, este se transmite mediante la conexión de SignalR y aparece en los demás dispositivos conectados a la sala **sin necesidad de actualizar la página**.

---

## 📋 Requisitos

Para ejecutar el proyecto necesitas:

* Tener instalado el **.NET SDK**.
* Dos o más dispositivos conectados a la **misma red Wi-Fi** para realizar pruebas entre dispositivos.
* Permitir el acceso a través del puerto utilizado por la aplicación (`5265`).

---

## ▶️ Ejecutar el proyecto

Clona el repositorio:

```bash
git clone https://github.com/TU-USUARIO/TU-REPOSITORIO.git
```

Entra en la carpeta del proyecto:

```bash
cd TU-REPOSITORIO
```

Ejecuta la aplicación:

```bash
dotnet run
```

Desde el dispositivo que ejecuta la aplicación:

```text
http://localhost:5265/Chat
```

Desde otro dispositivo conectado a la misma red:

```text
http://IP-SERVIDOR:5265/Chat
```

---

## 🎯 Objetivo del proyecto

Este proyecto fue creado como una **práctica de aprendizaje** para desarrollar una aplicación web con comunicación en tiempo real y comprender mejor cómo pueden comunicarse diferentes dispositivos dentro de una misma red local.

Durante su desarrollo practiqué conceptos como:

* Comunicación en tiempo real.
* SignalR.
* WebSockets.
* Conexiones dentro de una red local.
* Salas de chat.
* Gestión de usuarios conectados.
* Desarrollo de interfaces con HTML y CSS.
* Interacción entre frontend y backend mediante JavaScript.

---

## 🔮 Mejoras futuras

Algunas funcionalidades que podrían incorporarse en futuras versiones:

* [ ] Crear y eliminar salas desde la interfaz.
* [ ] Permitir cambiar las contraseñas desde la aplicación.
* [ ] Añadir nombres de usuario.
* [ ] Mostrar usuarios conectados/desconectados.
* [ ] Guardar mensajes en una base de datos.
* [ ] Añadir fecha y hora a los mensajes.
* [ ] Mejorar el diseño responsive.
* [ ] Implementar autenticación.
* [ ] Mejorar la seguridad de las contraseñas.
* [ ] Permitir configurar el puerto desde la aplicación.

---

## 👩‍💻 Autora

**Deborah Rodriguez Martinez**

Estudiante de Ingeniería Informática | Desarrollo Backend con .NET | Aprendiendo Frontend y React Native

---

⭐ Si te parece interesante el proyecto, puedes explorar el código y seguir mi progreso mientras continúo aprendiendo y desarrollando nuevos proyectos.
