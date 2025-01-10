## W14_Jwt
This project is a simple web API that uses JWT for authentication and authorization.

1. **User Model Creation**
   - Create a `User` class.
   - This class should have the following properties:
     - `Id` (int, key)
     - `Email` (string, unique)
     - `Password` (string)

2. **Database Configuration**
   - Use Entity Framework to create a `DbContext` class.
   - Add the `User` model you defined above to this class.

3. **JWT Creation**
   - Perform the following tasks:
     - Create an `AuthController` class.
     - Write a `Login` method to authenticate the user.
       - This method should take `Email` and `Password`.
       - If the user is valid, create a JWT.
       - The generated JWT should be returned to the user.

4. **JWT Validation**
   - Configure the necessary settings to validate the JWT with each request.
   - Use an `Authorize` attribute to perform JWT validation on requests.