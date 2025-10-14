# To-do Web Api pet-project

[![.NET](https://img.shields.io/badge/-.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com)
[![ASP.NET Core](https://img.shields.io/badge/-ASP.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com)
[![Entity Framework](https://img.shields.io/badge/-Entity_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://learn.microsoft.com/ef/)
[![PostgreSQL](https://img.shields.io/badge/-PostgreSQL-336791?style=for-the-badge&logo=postgresql&logoColor=white)](https://postgresql.org)
[![Swagger](https://img.shields.io/badge/-Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io)

**RESTful API для системы управления задачами**

---

## Оглавление

- [О проекте](#-о-проекте)
- [Технологии](#️-технологии)
- [Демонстрация API](#-демонстрация-api)
- [Запуск проекта](#-запуск-проекта)
- [Структура проекта](#-структура-проекта)
- [API Endpoints](#-api-endpoints)

---

## О проекте

**To-do Api предлагает документировать список задач, создание, просмотр, редактирование, удаление и завершение задач.**

---

## Технологии

**Backend:**
- ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
- ![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
- ![Entity Framework Core](https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
- ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

**База данных:**
- ![PostgreSQL](https://img.shields.io/badge/PostgreSQL-336791?style=for-the-badge&logo=postgresql&logoColor=white)

**Документация и тестирование:**
- ![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)
- ![Postman](https://img.shields.io/badge/Postman-FF6C37?style=for-the-badge&logo=postman&logoColor=white)

**Инструменты:**
- ![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)
- ![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)

---

## Демонстрация API

### Swagger UI - Документация API
![Swagger Documentation](screenshots/swagger-ui.png)
*Пояснение: Автоматически сгенерированная документация API с возможностью тестирования endpoints.*

### Пример работы с аутентификацией
![JWT Authentication](screenshots/auth-flow.gif)
*Пояснение: Получение JWT токена и его использование для доступа к защищенным ресурсам.*

### Пример ответа API
```json
{
  "id": 1,
  "title": "Implement REST API",
  "description": "Create Task Management API",
  "status": "InProgress",
  "priority": "High",
  "createdAt": "2024-01-15T10:30:00Z",
  "dueDate": "2024-01-20T23:59:00Z"
}
