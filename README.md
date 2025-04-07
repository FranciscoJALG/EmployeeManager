# 👨‍💼 Gestor de Empleados en C# (Windows Forms + SQLite)

Este es un sistema de gestión de empleados desarrollado en **C#** utilizando **Windows Forms** como interfaz gráfica y **SQLite** como base de datos local. Permite registrar, visualizar, editar y eliminar empleados con una interfaz amigable.

## 🧰 Tecnologías utilizadas

- C# (.NET Framework)
- Windows Forms (WinForms)
- SQLite
- Visual Studio
- Git & GitHub

---

## 🚀 Funcionalidades

✅ Agregar nuevos empleados  
✅ Listar todos los empleados en un `DataGridView`  
✅ Editar datos de un empleado  
✅ Eliminar empleados  
✅ Validación de campos y control de errores  
✅ Base de datos local (`employee.db`) autogenerada

---

## 📂 Estructura del proyecto

EmployeeManager/ 
├── Main.cs # Ventana principal con los controles de la app 
├── Employee.cs # Modelo de datos del empleado 
├── EmployeeDB.cs # Acceso a la base de datos SQLite 
├── Program.cs # Punto de entrada de la aplicación 
├── employee.db # (Se genera automáticamente) 
└── README.md


---

## 🛠️ ¿Cómo ejecutar el proyecto?

1. Clona el repositorio:

   ```bash
   git clone https://github.com/FranciscoJALG/EmployeeManager.git
Abre el proyecto en Visual Studio.

Restaura los paquetes si es necesario (SQLite viene incluido con .NET Framework).

Compila y ejecuta el proyecto (F5 o botón "Iniciar").

La base de datos employee.db se generará automáticamente en la carpeta del proyecto si no existe.

📸 Capturas de pantalla
(Puedes agregar imágenes aquí mostrando tu interfaz gráfica)

📌 Notas
La app es de escritorio, por lo que no está diseñada para web o móvil.

La base de datos se guarda localmente en el mismo directorio del ejecutable.

📄 Licencia
Este proyecto está bajo la licencia MIT.

