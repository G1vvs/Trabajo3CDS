Gestión de Alumnos y Asignaturas en C#
Este proyecto es una aplicación de escritorio desarrollada en C# que implementa un CRUD (Create, Read, Update, Delete) para gestionar registros de Alumnos y Asignaturas en una base de datos.
Características Principales
Gestión de Alumnos: Crear, visualizar, modificar y eliminar registros.
Gestión de Asignaturas: Crear, visualizar, modificar y eliminar registros.
Validaciones de Datos: Verifica campos vacíos y formatos de datos.
Tecnologías Utilizadas
Lenguaje: C#
Framework: .NET Windows Forms
Base de Datos: SQL Server
Interfaz: Windows Forms con DataGridView
Requisitos Previos
Visual Studio
SQL Server o un motor de base de datos compatible
Instrucciones de Instalación y Ejecución
Clona o descarga el repositorio de este proyecto.
Abre el archivo .sln en Visual Studio.
Configura la cadena de conexión a la base de datos en la capa de acceso a datos si es necesario.
Ejecuta el proyecto desde Visual Studio.
Uso de la Aplicación
Crear y Modificar: Completa los campos requeridos en el formulario y haz clic en “Guardar” para agregar o modificar registros.
Eliminar: Selecciona un registro en la tabla y usa el menú contextual para eliminarlo.
Validaciones: La aplicación asegura que los datos sean válidos antes de guardarlos.
Estructura del Proyecto
ALUMNOSBOL: Capa de negocio con la entidad AlumnosBOL.
ASIGNATURABOL: Capa de negocio con la entidad AsignaturaBOL.
ALUMNOSBL: Capa de lógica de negocio que gestiona las operaciones relacionadas con los alumnos.
ASIGNATURABL: Capa de lógica de negocio que gestiona las operaciones relacionadas con las asignaturas.
ALUMNOSDAL: Capa de acceso a datos que gestiona las operaciones CRUD en la base de datos para los alumnos.
ASIGNATURADAL: Capa de acceso a datos que gestiona las operaciones CRUD en la base de datos para las asignaturas.
INTERFAZ_USUARIO: Capa de interfaz de usuario con los formularios para gestionar Alumnos y Asignaturas.
Posibles Problemas y Soluciones
Error de conexión: Verifica que la cadena de conexión esté correctamente configurada y que la base de datos esté activa.
Datos repetidos: La aplicación mostrará un mensaje si intentas registrar datos que ya existen en la base de datos.
Campos vacíos: Se validará que todos los campos requeridos estén llenos antes de realizar cualquier operación.
