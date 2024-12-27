> [Ver en ingles/See in english](https://github.com/LuisMiSanVe/GeminiPostSQL/tree/main)
# <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/icon.ico" width="40" alt="Logo de GeminiPostSQL"> GeminiPostSQL | WinForms Asistido por IA para PostgreSQL
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)](https://www.postgresql.org/)
[![image](https://img.shields.io/badge/json-5E5C5C?style=for-the-badge&logo=json&logoColor=white)](https://www.newtonsoft.com/json)
[![image](https://img.shields.io/badge/Google%20Gemini-8E75B2?style=for-the-badge&logo=googlegemini&logoColor=white)](https://aistudio.google.com/app/apikey)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

>[!NOTE]
> Esta es la versión de WinForms pensada para ser usada como cliente. Hay una versión de [REST API](https://github.com/LuisMiSanVe/AIPostgreAssistant_API/tree/spanish) pensada para su uso en servidores o clientes con la interfaz de Swagger.

Esta REST API usa la IA de Google 'Gemini 1.5 Flash' para generar consultas a bases de datos PostgreSQL.  
La IA convierte lenguaje natural a consultas SQL usando un método con sus ventajas y desvenajas.

## 📋 Prerequisitos

Para que la API funcione, necesiatarás un servidor PostgreSQL y una clave de la API de Gemini.

> [!NOTE]  
> Yo usaré pgAdmin para montar el servidor PostgreSQL.

## 🛠️ Instalación

Si no lo tienes, descarga [pgAdmin 4 desde su página ofical](https://www.pgadmin.org/download/).  
Ahora, crea el servidor y monta la base de datos con algunas tablas y valores.

Después, obten tu clave de la API de Gemini yendo aqui: [Google AI Studio](https://aistudio.google.com/app/apikey). Asegurate de tener tu sesión de Google abierta, y encontes dale al botón que dice 'Crear clave de API' y sigue los pasos para crear tu proyecto de Google Cloud y conseguir tu clave de API. **Guardala en algún sitio seguro**.  
Google permite el uso gratuito de esta API sin añadir ninguna forma de pago, pero con algunas limitaciones.

En Google AI Studio, puedes monitorizar el uso de la IA haciendo clic en 'Ver datos de uso' en la columna de 'Plan' en la tabla con todos tus proyectos. Recomiendo monitorizarla desde la pestaña de 'Cuota y límites del sistema' y ordenando por 'Porcentaje de uso actual', ya que es donde más información obtienes.

Ya tienes todo lo que necesitas para hacer funcionar el programa.  
Simplemente pon los datos que acabas de conseguir en las pantallas de configuración del programa.

## 📖 Sobre el programa de WinForms
La interfaz tiene unos cuantos botones, siendo <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/key.png" width="20" alt="API Key Settings"> y <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/db.png" width="20" alt="Database Settings"> las pantallas de configuración, de la clave de la API y la base de datos respectivamente y <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/show.png" width="20" alt="Show SQL">/<img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/hide.png" width="20" alt="Hide SQL"> para mostrar u ocultar la consulta creada por la IA.

Al hacer clic en 'Save' en la pantalla de Configuración de la  Base de  Datos o en la de Configuración de la clave de la API (si la caja de 'Remember' está marcada) un archivo se creará en la carpeta interna del programa para que la siguiente vez que se inicie, todos esos datos se carguen automaticamente.
> [!WARNING]
> Ten en cuenta que estos archivos no están encriptados por el momento, por lo que cualquier persona indeseada podría acceder a ellos.

**Método de traducción de Lenguaje Natural a SQL:**  
Este método mapea la estructura de la base de datos en un JSON que Gemini analiza para crear una consulta SQL, la cual es ejecutada por el servidor PostgreSQL directamente.  
Ya que este método no mapea los valores de la base de datos el uso de tokens es menor, y los datos que devuelve son mas fiables pues es el mismo Servidor el que los devuelve. Sin embargo, no evita completamente los errores que cometa la IA. A veces, la consulta SQL fallará debido a que la IA se inventa columnas que no existen, en ese caso deberás comprobar la consulta generada para que identifiques el fallo.

## 💻 Tecnologías usadas
- Lenguaje de programación: [C#](https://dotnet.microsoft.com/en-us/languages/csharp)
- Framework: [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet) 8.0 Framework
- Paquetes NuGet:
  - [Npgsql](https://www.npgsql.org/) (8.0.5)
  - [RestSharp](https://restsharp.dev/) (112.1.0)
  - [Newtonsoft.Json](https://www.newtonsoft.com/json) (13.0.3)
- Otros:
  - [PostgreSQL](https://www.postgresql.org/) (16.3)
  - [pgAdmin 4](https://www.pgadmin.org/) (8.9)
  - Gemini API Key (1.5 Flash)
  - [FreeIcons](https://freeicons.io/) (Fuente original de los iconos, luego retocados por mi)
- IDE Recomendado: [Visual Studio](https://visualstudio.microsoft.com/) 2022
