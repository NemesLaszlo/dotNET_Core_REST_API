# .NET_Core_REST_API

Full implementation of a REST API in .NET Core 3.1

#### Endpoints for the Commander Backend API:

| Entity  | Type   | URL                      | Description                         | Success        | Failure                                          |
| ------- | ------ | ------------------------ | ----------------------------------- | -------------- | ------------------------------------------------ |
| User    | POST   | api/users/login          | Authenticate a user.                | 200 OK         | 400 Bad Request                                  |
|         | POST   | api/users/register       | Register a user.                    | 200 OK         | 400 Bad Request                                  |
|         | GET    | api/users                | Read all users.                     | 200 OK         | 401 Unauthorized                                 |
|         | GET    | api/users/{id}           | Read a single user.                 | 200 OK         | 401 Unauthorized, 404 Not Found                  |
|         | PUT    | api/users/update/{id}    | Update entire or partial user data. | 200 OK         | 401 Unauthorized, 400 Bad Request                |
|         | DELETE | api/users/delete/{id}    | Delete a single user.               | 200 OK         | 401 Unauthorized, 404 Not Found                  |
| Command | GET    | api/commands             | Read all resources.                 | 200 OK         | 401 Unauthorized, 400 Bad Request, 404 Not Found |
|         | GET    | api/commands/{id}        | Read a single resource.             | 200 OK         | 401 Unauthorized, 400 Bad Request, 404 Not Found |
|         | POST   | api/commands/create      | Create a new resource.              | 201 Created    | 401 Unauthorized, 400 Bad Request                |
|         | PUT    | api/commands/update/{id} | Update an entire resource.          | 204 No Content | 401 Unauthorized, 404 Not Found                  |
|         | PATCH  | api/commands/update/{id} | Update a partial resource.          | 204 No Content | 401 Unauthorized, 404 Not Found                  |
|         | DELETE | api/commands/delete/{id} | Delete a single resource.           | 204 No Content | 401 Unauthorized, 404 Not Found                  |
|         | DELETE | api/commands/deleteall   | Delete all resources.               | 204 No Content | 401 Unauthorized, ..                             |
