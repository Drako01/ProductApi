# Product API - Backend en ASP.NET Core

Este proyecto es una API REST construida con **ASP.NET Core 7** que permite gestionar productos e incluye autenticación mediante **JWT**.

## 🧩 Características

- Autenticación básica con JWT (`/api/auth/login`)
- Registro de usuarios (mock) (`/api/auth/register`)
- CRUD de productos (`/api/product`)
- Documentación Swagger integrada
- Repositorio en memoria para productos

---

## 📁 Estructura del Proyecto

```
ProductApi/
│
├── Controllers/
│   ├── AuthController.cs
│   └── ProductController.cs
│
├── Models/
│   └── Product.cs
│
├── Repositories/
│   └── ProductRepository.cs
│
├── Services/
│   └── AuthService.cs
│
├── Program.cs
└── appsettings.json
```

---

## 🔧 Configuración

### 1. Variables de entorno (`appsettings.json`)

Agregá tu clave JWT segura:

```json
"Jwt": {
  "Key": "ThisIsAVerySecureAndLongJWTSecretKey123456",
  "Issuer": "ProductApi",
  "Audience": "ProductApiUser"
}
```

### 2. Requisitos

- .NET 7 SDK
- PostgreSQL (si usás `ApplicationDbContext`, opcional)
- Visual Studio / VS Code

---

## ▶️ Ejecutar el proyecto

```bash
dotnet run
```

Luego, accedé a la documentación en:

```
https://localhost:5001/swagger
```

---

## 🔐 Autenticación JWT

### Login (token de acceso)

```
POST /api/auth/login
```

Body:
```json
{
  "username": "admin",
  "password": "admin123"
}
```

Respuesta:
```json
{
  "token": "eyJhbGciOiJIUzI1NiIsIn..."
}
```

### Registro (mock)

```
POST /api/auth/register
```

Body:
```json
{
  "username": "nuevo",
  "password": "123456"
}
```

---

## 📦 Endpoints de Productos

> Todos los endpoints requieren un token JWT en el header:  
> `Authorization: Bearer {tu_token}`

### Obtener todos los productos
```
GET /api/product
```

### Obtener producto por ID
```
GET /api/product/{id}
```

### Crear nuevo producto
```
POST /api/product
```

Body:
```json
{
  "name": "Producto nuevo",
  "price": 19.99
}
```

### Actualizar producto
```
PUT /api/product/{id}
```

Body:
```json
{
  "id": 1,
  "name": "Producto actualizado",
  "price": 25.00
}
```

### Eliminar producto
```
DELETE /api/product/{id}
```

---

## 🛡️ Seguridad

- JWT almacenado en memoria (para fines demostrativos)
- No se conecta aún a una base de datos real para usuarios
- Para producción se recomienda usar Identity + hashing + DB persistente

---

## ✍️ Autor

Desarrollado por Alejandro para pruebas y prácticas con .NET y JWT.  
Contáctame si querés extender este backend o integrarlo con frontend React/Angular.

---

## 📃 Licencia

MIT
```
