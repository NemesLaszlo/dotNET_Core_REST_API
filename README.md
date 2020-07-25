# .NET_Core_REST_API

Full implementation of a REST API in .NET Core 3.1

#### Endpoints for the Commander Backend API:

| Entity  | Type   | URL                      | Description                | Success        | Failure                        |
| ------- | ------ | ------------------------ | -------------------------- | -------------- | ------------------------------ |
| Command | GET    | api/commands             | Read all resources.        | 200 OK         | 400 Bad Request, 404 Not Found |
|         | GET    | api/commands/{id}        | Read a single resource.    | 200 OK         | 400 Bad Request, 404 Not Found |
|         | POST   | api/commands/create      | Create a new resource.     | 201 Created    | 400 Bad Request                |
|         | PUT    | api/commands/update/{id} | Update an entire resource. | 204 No Content | 404 Not Found                  |
|         | PATCH  | api/commands/update/{id} | Update a partial resource. | 204 No Content | 404 Not Found                  |
|         | DELETE | api/commands/delete/{id} | Delete a single resource.  | 204 No Content | 404 Not Found                  |
|         | DELETE | api/commands/deleteall   | Delete all resources.      | 204 No Content | ..                             |
