Gym Management System
This project is a Gym Management System using C# .NET Windows Forms and SQL Server. The system manages customers, gym classes, and enrollments.

Database Setup
First, create a database named GymManagementDB. Then, create three tables: CUSTOMERS, GYMCLASS, and ENROLLMENT. The CUSTOMERS table will store customer details such as last name, first name, middle name, and address. The GYMCLASS table will store gym class details including class name, instructor name, and monthly fee. The ENROLLMENT table will store enrollment details, including the customer ID, class ID, length of enrollment in months, and the enrollment date and time. The ENROLLMENT table will have foreign key relationships with the CUSTOMERS and GYMCLASS tables to ensure referential integrity.

Project Setup
Clone the repository and open the project in Visual Studio. Update the connection string in the SetConnection method of your Form1.cs file to connect to your SQL Server instance. The connection string should include the data source, initial catalog, user ID, and password.

Connecting to SQL Server
In your C# project, establish a connection to the SQL Server database using SqlConnection. Use SqlCommand to execute SQL queries and SqlDataReader to read data from the database. Implement methods to load data from the CUSTOMERS and GYMCLASS tables into DataGridView controls on the Windows Form. Implement methods to insert, update, and delete records in the CUSTOMERS, GYMCLASS, and ENROLLMENT tables based on user interactions.

Features
The application allows you to add, update, and delete customers and gym classes. It also allows you to enroll customers in gym classes, update enrollment details, and cancel enrollments. You can view all customers and the gym classes they are enrolled in by selecting a customer from the list.