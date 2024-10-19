# Code Challenge: App WinForms para Servicio de Facturación
### Desarrollado por Luis Jesus Ferrufino

---

# InvoiceManager.WinForms - Sistema de Facturación Electrónica

## Descripción del Proyecto

Este proyecto es una aplicación **Windows Forms** para la gestión de facturas electrónicas, la cual interactúa con una **API simulada** de facturación. Está desarrollado en **C#**, utilizando las siguientes tecnologías:

- **.NET 8**
- **ASP.NET Core**
- **Entity Framework Core**
- **SQLite**

El objetivo principal es permitir a los usuarios gestionar facturas, consultar facturas existentes, registrar nuevas facturas y sus ítems, visualizar el detalle de una factura específica, y exportar una factura como **PDF**.

---

## Requisitos Previos

Para ejecutar el proyecto correctamente, es importante asegurarse de que el entorno esté configurado de la siguiente manera:

1. **Instalación de .NET 8**:
    - Asegúrese de tener instalada la versión 8 de .NET en su máquina. Esto es necesario para ejecutar tanto el backend como la aplicación de escritorio.

2. **Base de datos SQLite**:
    - El proyecto se ejecuta de forma local, utilizando una base de datos **SQLite**. No es necesario configurar una base de datos externa, ya que SQLite se maneja de manera local dentro del sistema del usuario.

3. **Servicio de Facturación (Backend)**:
    - El servicio de facturación, que se describe en la siguiente sección, debe estar ejecutándose en segundo plano para que la aplicación Windows Forms funcione correctamente.

---

## Instrucciones de Instalación y Ejecución

### 1. Clonar el repositorio

Primero, debe clonar el repositorio en su máquina local:

```bash
git clone https://github.com/JesusFerru/winforms-invoicing-challenge
```

### 2. Configurar y ejecutar la API de Facturación

El servicio de facturación está escrito en **C#** utilizando **.NET 8**, **ASP.NET Core**, **Entity Framework Core** y **SQLite**. A continuación, se indican los pasos para ejecutar la API localmente:

1. Abra una terminal en la carpeta del proyecto.
2. Ejecute los siguientes comandos para restaurar las dependencias, construir el proyecto y ejecutar el servicio:

```bash
dotnet restore
dotnet build
dotnet run --project InvoiceServiceMock --urls=http://localhost:5050/
```

Este comando iniciará el servicio de la API en la URL http://localhost:5050/, donde estará escuchando para recibir solicitudes. 
Es importante dejar el servicio corriendo en segundo plano mientras se ejecuta la aplicación de escritorio.

### 3. Ejecutar la aplicación **Windows Forms**

Con la API de facturación ejecutándose, puede iniciar la aplicación **Windows Forms** desde **Visual Studio**. Siga los siguientes pasos:

1. En **Visual Studio**, asegúrese de que el proyecto **InvoiceManager.WinForms** esté seleccionado como el proyecto de inicio.
2. Ejecute la aplicación usando cualquiera de las siguientes opciones:
    - **Iniciar sin depurar**.
    - **Iniciar con depuración**.

Ambas opciones permiten que la aplicación se conecte al servicio de facturación que se está ejecutando en segundo plano.

---

## Funcionalidades Principales

El proyecto proporciona 4 funcionalidades clave, que pueden probarse para verificar su correcto funcionamiento:

### 1. Consultar Facturas

- **Descripción**: Permite consultar todas las facturas almacenadas en la base de datos local.
- **Pasos para probar**:
  1. Abra la aplicación.
  2. Haga clic en el botón **"Consultar Facturas"**.
  3. Si no hay facturas almacenadas, proceda a probar la funcionalidad **Nueva Factura** para registrar una.

### 2. Nueva Factura

- **Descripción**: Permite registrar una nueva factura junto con los ítems de dicha factura.
- **Pasos para probar**:
  1. Haga clic en el botón **"Nueva Factura"**.
  2. Complete los campos obligatorios: **NIT**, **Nombre del Cliente**, seleccione un **Producto**, especifique la **Cantidad** y el **Precio Unitario**.
  3. Haga clic en **Añadir Producto** para agregar ítems a la factura.
  4. Después de añadir los ítems, haga clic en **Guardar** para registrar la factura.

**Nota**: Una vez que haya registrado al menos una factura, vuelva a probar la funcionalidad **Consultar Facturas** para asegurarse de que se liste la factura recién creada.

### 3. Ver Factura Individual

- **Descripción**: Permite ver los detalles de una factura específica seleccionada de la lista de facturas.
- **Pasos para probar**:
  1. En la lista de facturas, haga clic en la fila correspondiente a una factura.
  2. Se abrirá una nueva ventana mostrando los detalles de la factura seleccionada.

### 4. Guardar Como PDF

- **Descripción**: Permite guardar una factura en formato **PDF** desde la vista de detalle de una factura.
- **Pasos para probar**:
  1. Abra la vista de detalle de una factura como se indicó en el paso anterior.
  2. Haga clic en el botón **Guardar como PDF**.
  3. Seleccione la ubicación donde desea guardar el archivo y confirme.

---

## Sugerencias para Mejoras Futuras

A continuación, se propone algunas sugerencias para mejorar el sistema en futuras versiones:

1. **Filtrar facturas antes de guardarlas como PDF**:
    - Implementar la opción de filtrar facturas por fecha, NIT o nombre del cliente antes de exportarlas a PDF.

2. **Edición de ítems en la factura**:
    - Agregar la funcionalidad de editar los ítems de una factura antes de registrarla para prevenir errores de entrada.

3. **Estado de Anulación de Facturas**:
    - Incluir la opción de **anular** facturas, agregando un nuevo estado llamado "Anulada".

4. **Mejorar el formato del PDF**:
    - Optimizar la interfaz del PDF generado para mejorar su diseño y presentación visual.

---

## Conclusión

Este documento proporciona una guía detallada para ejecutar el proyecto de manera correcta y probar sus funcionalidades. 
Si surge alguna duda o inconveniente durante la instalación o ejecución del sistema, no dude en contactarnos para brindar el soporte necesario.

Agradezco su evaluación de este proyecto.
