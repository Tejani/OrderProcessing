# Distributed Order Processing Microservice

A simple .NET Core 8 Web API that simulates a distributed order processing system.

## Features

- Create a new order
- Fetch order status
- Publish order confirmation events to an in-memory queue
- Swagger documentation
- SQLite database integration using Entity Framework Core

## Setup Instructions

1. **Clone the repository**
    ```bash
    git clone https://github.com/Tejani/OrderProcessing.git
    cd OrderProcessing
    ```

2. **Update the database**
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

3. **Run the application**
    ```bash
    dotnet run
    ```

4. **Access Swagger UI**
    - Navigate to `https://localhost:7254/swagger/index.html`

## Module Responsibilities

- **Models**: Define the database models.
- **Data**: Setup EF Core context and repository.
- **Services**: Handle business logic and event publishing.
- **Controllers**: Handle HTTP requests.

## API Endpoints

curl -X 'POST' \
  'https://localhost:7254/api/Order' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "id": 1,
  "productName": "iPhone",
  "quantity": 4,
  "createdAt": "2025-04-27T10:40:31.722Z",
  "status": "Confirmed"
}'

curl -X 'GET' \
  'https://localhost:7254/api/Order/1' \
  -H 'accept: */*'

## Screenshots

### Swagger UI

Post: ![image](https://github.com/user-attachments/assets/743d2fc1-140f-453b-a57e-328bad50cf53)
Get: ![image](https://github.com/user-attachments/assets/b2e3bacb-150e-43dd-94db-fc3c2d60bd90)

---
