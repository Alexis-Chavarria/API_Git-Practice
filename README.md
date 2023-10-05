# API_Git-Practice

Descripción corta y concisa de tu API.

## Tabla de Contenidos

- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Configuración](#configuración)
- [Uso](#uso)
- [Ejemplos](#ejemplos)
- [Documentación](#documentación)
- [Contribución](#contribución)
- [Licencia](#licencia)

## Requisitos

Antes de comenzar, asegúrate de tener lo siguiente instalado en tu sistema:
- [.NET Core SDK]
- [Visual Studio] (opcional)


## Instalación

1. Clona este repositorio en tu máquina local:

```bash
git clone https://github.com/Alexis-Chavarria/API_Git-Practice.git
```


2. Abre el proyecto en tu entorno de desarrollo preferido (Visual Studio).


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


## Documentación
La documentación de la API se encuentra en https://localhost:7125/swagger/index.html. Puedes explorar y probar los endpoints desde allí.


## Contribución
¡Agradecemos las contribuciones! Si deseas contribuir a API_Git-Practice


## Licencia

Este proyecto está bajo la licencia VexAlexis. Consulta el archivo LICENSE para obtener más detalles.

# Este es un ejemplo de README para proyectos futuros en los que se desee implementar esta plantilla.




