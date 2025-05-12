# 📊 AnalyticsService – StopBullies Platform

The **AnalyticsService** is a microservice built using Clean Architecture in .NET 8. It is responsible for collecting, aggregating, and providing analytics on user activity, moderation alerts, and platform interactions.

---

## 🎯 Purpose

Provide metrics and reports to assist parents, educators, and administrators in understanding trends and behaviors across the platform.

---

## 🧩 Core Responsibilities

- Collect raw events (e.g. moderation flags, user activity)
- Aggregate analytics metrics
- Generate downloadable reports
- Expose metrics through RESTful API

---

## 🧠 Key Components

| Component             | Description                                                  |
|-----------------------|--------------------------------------------------------------|
| `AnalyticsController` | API interface for dashboards and reports                     |
| `EventConsumer`       | Ingests events from a message broker                         |
| `AggregatorService`   | Aggregates and stores metrics                                |
| `ReportGenerator`     | Builds and formats downloadable reports                      |
| `AnalyticsRepository` | Handles persistence of analytics events and metrics          |

---

## 🗃️ Project Structure

```
AnalyticsService/
├── Domain/
│   ├── Entities/
│   └── Interfaces/
├── Application/
│   ├── UseCases/
│   ├── DTOs/
│   └── Interfaces/
├── Infrastructure/
│   ├── Messaging/
│   ├── Persistence/
│   └── Reporting/
├── Presentation/
│   └── Controllers/
├── Program.cs
└── appsettings.json
```

---

## ⚙️ Tech Stack

- .NET 8 / ASP.NET Core
- Entity Framework Core
- PostgreSQL or TimeScaleDB
- RabbitMQ / Azure Event Hub (for event ingestion)
- Redis (optional caching)
- Swagger / OpenAPI
- Docker support

---

## 🚀 How to Run

```bash
dotnet restore
dotnet build
dotnet run
```

Visit `http://localhost:5000/api/analytics/overview` to test the service.

---

## 📦 Sample Endpoints

| Method | Endpoint                    | Description                     |
|--------|-----------------------------|---------------------------------|
| GET    | /api/analytics/overview     | Summary metrics                 |
| GET    | /api/analytics/report       | Triggers report generation      |
| GET    | /api/analytics/alerts       | Alerts data by time             |
| GET    | /api/analytics/users        | Usage and engagement stats      |

---

## 🧪 Tests

_Unit and integration tests to be added in `/tests` directory in later stage._

---

## 📄 License

MIT License

---

## 🤝 Contributions

Feel free to fork the repo, submit PRs, or open issues to collaborate.
