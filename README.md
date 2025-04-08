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
![image](https://github.com/user-attachments/assets/f35135b4-7374-4f68-8295-c861362f1876)

![image](https://github.com/user-attachments/assets/f43b2b65-b55b-4e78-8b07-2a8a09f10cf1)

![image](https://github.com/user-attachments/assets/d8d66573-5c72-4a4f-912f-d5c7461bd06a)

![image](https://github.com/user-attachments/assets/0f8f5f8c-9cd4-4bac-93e9-423dede932d0)

![image](https://github.com/user-attachments/assets/25679ecd-d041-41af-8239-59d888961440)

![image](https://github.com/user-attachments/assets/422b355b-47c2-45c1-ac94-b31af9dc3caf)

![image](https://github.com/user-attachments/assets/b371be6a-e644-43e1-aaff-c5ef8fcf9650)

![image](https://github.com/user-attachments/assets/216aa991-5d76-4505-8d24-4ba80f27becc)


📌 Notas
La app es de escritorio, por lo que no está diseñada para web o móvil.

La base de datos se guarda localmente en el mismo directorio del ejecutable.

📄 Licencia
Este proyecto está bajo la licencia MIT.

