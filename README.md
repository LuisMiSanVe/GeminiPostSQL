> [See in spanish/Ver en español](https://github.com/LuisMiSanVe/GeminiPostSQL/tree/spanish)
# <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/icon.ico" width="40" alt="GeminiPostSQL Logo"> GeminiPostSQL | AI-Assisted WinForms for PostgreSQL
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)](https://www.postgresql.org/)
[![image](https://img.shields.io/badge/json-5E5C5C?style=for-the-badge&logo=json&logoColor=white)](https://www.newtonsoft.com/json)
[![image](https://img.shields.io/badge/Google%20Gemini-8E75B2?style=for-the-badge&logo=googlegemini&logoColor=white)](https://aistudio.google.com/app/apikey)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

>[!NOTE]
> This is the WinForms version meant for client use. There is a [REST API](https://github.com/LuisMiSanVe/AIPostgreAssistant_API/tree/main) version meant for servers and client use by Swagger interface.

This WinForms program uses Google's AI 'Gemini 1.5 Flash' to make queries to PostgreSQL databases.  
The AI interprets natural language into SQL queries using one method, with its pros and cons.

## 📋 Prerequisites
To make this program work, you'll need a PostgreSQL Server and a Gemini API Key.

> [!NOTE]  
> I'll use pgAdmin to build the PostgreSQL Server.

## 🛠️ Setup
If you don't have it, download [pgAdmin 4 from the official website](https://www.pgadmin.org/download/).  
Now, create the PostgreSQL Server and set up a database with a few tables and insert values.

Next, obtain your Gemini API Key by visiting [Google AI Studio](https://aistudio.google.com/app/apikey). Ensure you're logged into your Google account, then press the blue button that says 'Create API key' and follow the steps to set up your Google Cloud Project and retrieve your API key. **Make sure to save it in a safe place**.  
Google allows free use of this API without adding billing information, but there are some limitations.

In Google AI Studio, you can monitor the AI's usage by clicking 'View usage data' in the 'Plan' column where your projects are displayed. I recommend monitoring the 'Quota and system limits' tab and sorting by 'actual usage percentage,' as it provides the most detailed information.

You now have everything needed to make the program work.  
Simply put that data you just got into the setting windows in the program.

## 📖 About the WinForms program
The interface have a few buttons, being <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/key.png" width="20" alt="API Key Settings"> and <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/db.png" width="20" alt="Database Settings"> setting windows, for configuring the API Key and the database respectively and <img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/show.png" width="20" alt="Show SQL">/<img src="https://github.com/LuisMiSanVe/GeminiPostSQL/blob/main/AiPostgreWinForms/Resources/hide.png" width="20" alt="Hide SQL"> to show or hide the AI's generated query.

When you click 'Save' in the Database Settings Window or in the API Key Settings Window (if the 'Remember' box is checked) a file will be created in the internal folder of the program so the next time the program is started, all this data gets loaded automaticly.
> [!NOTE]
> It haves encryption to the API Key and DB data configuration files using AES with a Specific System Based Method, where the AES Key is made with your system's specs, so if any unwanted person steals those files, they couldn't be decrypted, maintaining your sensitive data secure.

**Natural Language to SQL Translation Method:**  
This method maps the database structure into a JSON that Gemini analyzes to create an SQL query, which is then run by the PostgreSQL Server, returning the requested data.  
Since this method does not map the database values, token usage is lower, and the data is more reliable because it comes directly from the PostgreSQL Server. However, it doesn't completely prevent AI-generated errors. Occasionally, the SQL query might fail due to non-existing columns, in which case you should check the generated query to detect the error.

## 🚀 Releases
The version will be released using these versioning policies:
- A new version will drop when a major feature is added.
When a bug is fixed in the repository, instead of releasing a new version immediately, we will wait one week from the date the fix was made.
  - Reason: This waiting period allows for the inclusion of any additional bug fixes that may arise, reducing the need to release multiple consecutive versions for individual fixes.
  - Exception: In critical cases where a bug severely impacts the functionality of the project, an immediate release might be considered.

The version number will follow this format: \
\[Major Feature\].\[Minor Feature\].\[Bug Fix\]

## 💻 Technologies Used
- Programming Language: [C#](https://dotnet.microsoft.com/en-us/languages/csharp)
- Framework: [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet) 8.0 Framework
- NuGet Packages:
  - [Npgsql](https://www.npgsql.org/) (8.0.5)
  - [RestSharp](https://restsharp.dev/) (112.1.0)
  - [Newtonsoft.Json](https://www.newtonsoft.com/json) (13.0.3)
  - [System.Management](https://learn.microsoft.com/es-es/dotnet/api/system.management?view=netframework-1.1) (9.0.1)
- Other:
  - [PostgreSQL](https://www.postgresql.org/) (16.3)
  - [pgAdmin 4](https://www.pgadmin.org/) (8.9)
  - Gemini API Key (1.5 Flash)
  - [FreeIcons](https://freeicons.io/) (Icons source, later retouched by me)
- Recommended IDE: [Visual Studio](https://visualstudio.microsoft.com/) 2022
