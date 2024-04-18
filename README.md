# ASP.NET Core API Project

This is an ASP.NET Core API project for an e-commerce platform. The API provides endpoints for managing products, orders, users, and shopping carts.

## Getting Started

To run the API locally, make sure you have the following prerequisites installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Running the API

1. Clone this repository to your local machine.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build the solution to restore dependencies.
4. Set the API project as the startup project.
5. Press F5 or click on the "Start" button to run the API.

Alternatively, you can use the `dotnet run` command in the terminal to run the API from the command line.

### Configuration

The API uses an in-memory database for demonstration purposes. You can configure the database connection string and other settings in the `appsettings.json` file.

## API Endpoints

The following endpoints are available in the API:

- `/api/products`: CRUD operations for managing products.
- `/api/orders`: CRUD operations for managing orders.
- `/api/users`: CRUD operations for managing users.
- `/api/shoppingcart`: Operations for managing shopping carts.

For detailed documentation on each endpoint, refer to the Swagger UI documentation available at `/swagger` when running the API locally.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
