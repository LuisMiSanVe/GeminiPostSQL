> [Ver en ingles/See in english](https://github.com/LuisMiSanVe/GeminiPostSQL/tree/main)

<img src="https://github.com/LuisMiSanVe/LuisMiSanVe/blob/main/Resources/GeminiPostSQL/GeminiPostSQL_banner.png" style="width: 100%; height: auto;" alt="GeminiPostSQL Banner">

# <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/icon.ico" width="40" alt="Logo de GeminiPostSQL"> GeminiPostSQL | WinForms Asistido por IA para PostgreSQL
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)](https://www.postgresql.org/)
[![image](https://img.shields.io/badge/json-5E5C5C?style=for-the-badge&logo=json&logoColor=white)](https://www.newtonsoft.com/json)
[![image](https://img.shields.io/badge/Google%20Gemini-8E75B2?style=for-the-badge&logo=googlegemini&logoColor=white)](https://aistudio.google.com/app/apikey)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

>[!NOTE]
> Dale un vistazo a las otras versiones del programa:
>- [REST API](https://github.com/LuisMiSanVe/GeminiPostSQL_API/tree/main) 
>- [ChatBot](https://github.com/LuisMiSanVe/GeminiPostSQL_ChatBot/tree/main)
>- [NuGet](https://github.com/LuisMiSanVe/GeminiPostSQL_NuGet/tree/main)
>- [Android](https://github.com/LuisMiSanVe/GeminiLiteSQL/tree/main)

Este WinForms usa la IA de Google 'Gemini 2.0 Flash' para generar consultas a bases de datos PostgreSQL.  
La IA convierte lenguaje natural a consultas SQL usando un método con sus ventajas y desventajas.

## 📋 Prerequisitos

Para que el programa funcione, necesiatarás un servidor PostgreSQL y una clave de la API de Gemini.

> [!NOTE]  
> Yo usaré pgAdmin para montar el servidor PostgreSQL.

## 🛠️ Instalación

En caso de no tenerlo, deberás descargar [pgAdmin 4 desde su página ofical](https://www.pgadmin.org/download/).  
Ahora, crea el servidor y monta la base de datos con algunas tablas y valores.

Después, obten tu clave de la API de Gemini yendo aquí: [Google AI Studio](https://aistudio.google.com/app/apikey). Asegúrate de tener tu sesión de Google abierta, y entonces dale al botón que dice 'Crear clave de API' y sigue los pasos para crear tu proyecto de Google Cloud y conseguir tu clave de API. **Guárdala en algún sitio seguro**.  
Google permite el uso gratuito de esta API sin añadir ninguna forma de pago, pero con algunas limitaciones.

En Google AI Studio, puedes monitorizar el uso de la IA haciendo clic en 'Ver datos de uso' en la columna de 'Plan' en la tabla con todos tus proyectos. Recomiendo monitorizarla desde la pestaña de 'Cuota y límites del sistema' y ordenando por 'Porcentaje de uso actual', ya que es donde más información obtienes.

Ya tienes todo lo que necesitas para hacer funcionar el programa.  
Simplemente pon los datos que acabas de conseguir en las pantallas de configuración del programa.

## 📖 Sobre el programa de WinForms
La interfaz tiene unos cuantos botones, siendo <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/key.png" width="20" alt="API Key Settings"> y <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/db.png" width="20" alt="Database Settings"> las pantallas de configuración, de la clave de la API y la base de datos respectivamente y <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/show.png" width="20" alt="Show SQL">/<img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/hide.png" width="20" alt="Hide SQL"> para mostrar u ocultar la consulta creada por la IA.

El botón <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/map.png" width="20" alt="Map DB"> saca un Gestor de Bases de Datos Mapeadas, en el que puedes Mapear a JSON cualquier base de datos que quieras y seleccionarla para usarla en futuras solicitudes a la IA. 

Estas Bases de Datos Mapeadas se guardan en tu disco por lo que siempre se cargarán al iniciar el programa. 

Recuerda que las Bases de Datos Mapeadas solo se usan al hacer una solicitud a la IA, por lo que si estás modificando una sentencia y la ejecutas, esta correrá en el Servidor PostgreSQL que tengas configurado.

Al hacer clic en 'Save' en la pantalla de Configuración de la Base de Datos o en la de Configuración de la clave de la API (si la caja de 'Remember' está marcada) un archivo se creará en la carpeta interna del programa para que la siguiente vez que se inicie, todos esos datos se carguen automaticamente.
> [!NOTE]
> Los ficheros de configuración de la API Key y los datos de la BBDD se encriptan usando AES con un [Método Basado en Sistemas Especificos](https://gist.github.com/LuisMiSanVe/6b3c53cbfc4fcd75d816377bb6eb06b5), en la que se crea la clave AES con la información de tu equipo, por lo que si alguna persona indeseada roba esos ficheros, no podrían ser desencriptados, manteniendo tus datos sensibles a salvo.

**[Método de traducción de Lenguaje Natural a SQL:](https://gist.github.com/LuisMiSanVe/2da8e2d932a06ef408b3ee8468d0d820)**  
Este método mapea la estructura de la base de datos en un JSON que Gemini analiza ([con este prompt](https://gist.github.com/LuisMiSanVe/b189c8920d2dcedf5fd46485f3403d51)) para crear una consulta SQL, la cual es ejecutada por el servidor PostgreSQL directamente.  
Ya que este método no mapea los valores de la base de datos el uso de tokens es menor, y los datos que devuelve son mas fiables pues es el mismo Servidor el que los devuelve. Sin embargo, no evita completamente los errores que cometa la IA. A veces, la consulta SQL fallará debido a que la IA inventa columnas que no existen, en ese caso deberás comprobar la consulta generada para que identifiques el fallo.

## 🚀 Lanzamientos
Una versión será lanzada solo cuando se cumplan los siguientes puntos:\
Nuevas funciones importantes y arreglos de fallos criticos causarán la salida inmediata de una nueva versión, mientras que otros cambios o arreglos menores deberán esperar una semana desde que se incluyeron en el repositorio antes de ser incluidos en la nueva versión, para que otros posibles cambios puedan ser añadidos también.
>[!NOTE]
>Estos posibles nuevos cambios no alargarán la espera de la salida de la nueva versión a más de una semana.

El número de la versión seguirá este formato: \
\[Añadido Importante\].\[Añadido Menor\].\[Arreglos de Errores\]

## 💻 Tecnologías usadas
- Lenguaje de programación: [C#](https://dotnet.microsoft.com/en-us/languages/csharp)
- Framework: [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet) 8.0 Framework
- Paquetes NuGet:
  - [Npgsql](https://www.npgsql.org/) (8.0.5)
  - [RestSharp](https://restsharp.dev/) (112.1.0)
  - [Newtonsoft.Json](https://www.newtonsoft.com/json) (13.0.3)
  - [System.Management](https://learn.microsoft.com/es-es/dotnet/api/system.management?view=netframework-1.1) (9.0.1)
- Otros:
  - [PostgreSQL](https://www.postgresql.org/) (16.3)
  - [pgAdmin 4](https://www.pgadmin.org/) (8.9)
  - Gemini API Key (2.0 Flash)
  - Pantalla de carga diseñada por [mi esposa](https://github.com/meowwan)
  - [FreeIcons](https://freeicons.io/) (Fuente original de los iconos, luego retocados por mí)
  - [Microsoft Visual Studio Installer Projects 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2022InstallerProjects) (2.0.1)
- IDE Recomendado: [Visual Studio](https://visualstudio.microsoft.com/) 2022
