# LibraryApi

REST API для библиотеки на ASP.NET Core Web API.

## Стек

- **C# / .NET 10**
- **ASP.NET Core Web API** — контроллеры, DI
- **Entity Framework Core** — ORM, миграции
- **SQL Server** — база данных

## Функциональность

- CRUD для книг
- Валидация входных данных (Data Annotations)
- DTO для запросов и ответов
- Swagger UI для тестирования

## Эндпоинты

| Метод | URL | Описание |
|-------|-----|----------|
| GET | `/api/books` | Все книги |
| GET | `/api/books/{id}` | Книга по Id |
| POST | `/api/books` | Создать книгу |
| PUT | `/api/books/{id}` | Обновить книгу |
| DELETE | `/api/books/{id}` | Удалить книгу |

## Модель

**Book:**
- `Id` — идентификатор
- `Title` — название
- `Author` — автор
- `Year` — год издания
- `Price` — цена

## Как запустить

1. Установить **.NET 10 SDK** и **SQL Server Express**.
2. Клонировать репозиторий:
   ```bash
   git clone https://github.com/danila-markevich/LibraryApi.git