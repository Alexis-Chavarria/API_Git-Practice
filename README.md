# API_Git-Practice

Descripción corta y concisa de tu API.
<br> <!-- Este es un salto de línea -->

## Tabla de Contenidos

- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Configuración](#configuración)
- [Uso](#uso)
- [Ejemplos](#ejemplos)
- [Documentación](#documentación)
- [Contribución](#contribución)
- [Licencia](#licencia)

<br> <!-- Este es un salto de línea -->

## Requisitos

Antes de comenzar, asegúrate de tener lo siguiente instalado en tu sistema:
- [.NET Core SDK]
- [Visual Studio] (opcional)

<br> <!-- Este es un salto de línea -->

## Instalación

1. Clona este repositorio en tu máquina local:

```bash
git clone https://github.com/Alexis-Chavarria/API_Git-Practice.git
```


2. Abre el proyecto en tu entorno de desarrollo preferido (Visual Studio).

<br> <!-- Este es un salto de línea -->

## Configuración

La configuración de la API se realiza a través del archivo "appsettings.json". Abre este archivo y modifica las siguientes configuraciones según tus necesidades:

```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MyAPIDB;User Id=usuario;Password=contraseña;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  },
  "AllowedHosts": "*"
}
```
<br> <!-- Este es un salto de línea -->

## Ejecución

1. Abre una terminal en la raíz del proyecto y ejecuta el siguiente comando para crear la base de datos:
```bash
dotnet ef database update
```

2. Luego, ejecuta la aplicación con el siguiente comando:
```bash
dotnet run
```
La API estará disponible en https://localhost:7125/WeatherForecast

<br> <!-- Este es un salto de línea -->

## Documentación
La documentación de la API se encuentra en https://localhost:7125/swagger/index.html. Puedes explorar y probar los endpoints desde allí.

<br> <!-- Este es un salto de línea -->

## Contribución
¡Agradecemos las contribuciones! Si deseas contribuir a API_Git-Practice

<br> <!-- Este es un salto de línea -->

## Licencia

Este proyecto está bajo la licencia VexAlexis. Consulta el archivo LICENSE para obtener más detalles.

<br> <!-- Este es un salto de línea -->

*Este es un ejemplo de README para proyectos futuros en los que se desee implementar esta plantilla.*
**FIN**
> Esto es una cita.
`var ejemplo = 42. (código en línea)`
```python
def funcion_ejemplo():
    return "Hola, mundo"
(bloques de código del lenguaje de programación)
```
---
Separar secciones
***
Tablas: 
Utilizando barras verticales (|) para separar columnas y guiones (-) para definir la fila de encabezado

| Encabezado 1 | Encabezado 2 |
|--------------|--------------|
| Celda 1,1    | Celda 1,2    |
| Celda 2,1    | Celda 2,2    |


---

## cada una de las capas de tu arquitectura en una aplicación ASP.NET con SQL Server

## conexion a base de datos utilizando ASP.NET Core

## Dame una lista de los conceptos, principios y/o buenas practicas que se utilizan en el desarrollo de un API Rest ASP.NET y SQLServer con la siguiente arquitectura: Controllers, Models, Services, Data (DataAccess)


## Ahora dame una lista de principios y buenas practicas que se implementan

## Dame una lista de tecnologias, herramientas y buenas practicas que se utilizan para mi API desarrollada en ASP.NET y SQL Serve

## Quiero añadirle asincronia, para ello necesito que me ayudes arreglando mi codigo

## Dame el codigo en C# y ASP.NET para implementar autenticacion y autorizacion a mi API Rest

## Que otras etiquetas o simbolos son utilizados para archivos README
(API ASP.NET Buena Practica)

