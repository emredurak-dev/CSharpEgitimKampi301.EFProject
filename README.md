## C# Bootcamp Camp (#301) Projects
This repository contains the #301 OOP Module: N-Tier Architecture with C# from Murat Yücedağ's C# Bootcamp.

## 📌 Project 1 -> OOP Module: Creating the Entity Layer in a Four-Layer Architecture
In this project, we will build a four-layer architecture using OOP (Object-Oriented Programming). At this stage, I created the layers of the project. Then, I created the classes in the Entity Layer and the properties within those classes.

## 📌 Project 2 -> OOP Module: Data Access Layer and Context Class in a Four-Layer Architecture
In this project, I created the Data Access Layer and the Context class for the four-layer architecture built with OOP. The Data Access Layer is the layer where structures for interacting with the database are gathered. The Context class is the class that allows Entity Framework to connect to the database.

## 📌 Project 3 -> OOP Module: Migration Operations and Abstract Interfaces in a Four-Layer Architecture
In this project, I performed migration operations in the four-layer architecture created with OOP. Migration operations are used to manage changes in the database schema. Migrations allow versioning of changes made to ensure consistency between the database and code. Afterward, I created interfaces within the Abstract folder. These interfaces were defined to specify the basic data access operations in the Data Access Layer (DAL) for different entities.

## 📌 Project 4 -> ORM Structure: Database First and Model Creation in Entity Framework
In this project, I used the Database First approach in Entity Framework. I first created a database from MS SQL Server. Then, using ADO.NET Entity Data Model, I transferred this database into C# code via Entity Framework. This way, the tables and relationships in the database were transformed into C# classes. These classes became usable C# objects corresponding to each table in the database.

## 📌 Project 5 -> ORM Structure: Entity Framework Methods for Project Implementation
In this project, I created a simple project using Entity Framework methods. I assigned operations like Listing, Adding, Deleting, Updating, and Getting by ID to buttons on a Form. Then, using these buttons, I performed database operations on a DataGridView without SQL commands using Entity Framework.

## 📌 Project 6 -> ORM Structure: Tour Project and Location Operations in Entity Framework
In this project, I added another form to the previous project I created using Entity Framework methods. On this form, I performed operations such as Listing, Adding, Deleting, and Updating on the TblLocation table in MS SQL Server, using buttons and displaying the data on a DataGridView.

## 📌 Project 7 -> ORM Structure: Entity Framework Methods and Linq Queries
In this project, I used Entity Framework methods to get statistics of the Location table from the previous project. Statistics like the number of locations, total capacity, number of guides, average capacity, average tour price, the last added country, the capacity of the Barcelona tour, the average capacity of Turkey tours, the Barcelona tour guide, the highest capacity tour, the most expensive tour, and the number of tours of Ahmetturan Karbuga were retrieved using LINQ queries from MS SQL Server and displayed on a Windows Form using labels.

![case3](https://github.com/user-attachments/assets/08a1cec7-e626-485c-93a3-44399ea6ce7a)
## 📌 Project 8 -> OOP Module: EntityState Commands, Generic Repository Class, and Entity Framework Classes in a Four-Layer Architecture
In this project, I created the GenericRepository in the four-layer architecture built with OOP. The GenericRepository is a generic implementation of the Repository Pattern, a commonly used design pattern in software development. Repository Pattern abstracts and makes the data access layer (DAL) manageable. GenericRepository generalizes this structure for all entities, eliminating repetitive code and offering a modular design. The classes I added, such as EfAdminDal and EfCustomerDal, are data access classes in the Data Access Layer (DAL) that interact with the database using Entity Framework.

## 📌 Project 9 -> OOP Module: Business Layer and Logic Rules in a Four-Layer Architecture
In this project, I created the IGenericService interface in the Business Layer of the four-layer architecture, providing templates for basic CRUD (Create, Read, Update, Delete) operations. Then, I created the ICategoryService, ICustomerService, IOrderService, and IProductService interfaces. If specific business logic is needed for Category, Customer, Order, and Product, it can be defined within these interfaces. These interfaces are derived from IGenericService<Category>, IGenericService<Customer>, IGenericService<Order>, and IGenericService<Product>. Afterward, I created the CategoryManager, CustomerManager, OrderManager, and ProductManager classes to implement the business logic and CRUD operations for each entity, bridging the Data Access Layer and the business layer, and using ICategoryDal for data operations.

## 📌 Project 10 -> OOP Module: Presentation Layer with Dependency Injection in a Four-Layer Architecture
In this project, I wrote the methods for the List, Add, Delete, Update, and Get by ID buttons in the FrmCategory form within the Presentation Layer, which I created in the previous project. I used Dependency Injection (DI) while writing these methods. DI is a design pattern that allows an object to receive its dependencies from external sources, making the software more flexible and testable by decoupling the relationships between classes.

## 📌 Project 11 -> OOP Module: Writing Entity-Specific Methods in a Four-Layer Architecture
In this project, I created a form named FrmProduct to perform CRUD operations for the Product Entity. For the listing operation, I used a method specific to the Product Entity. The GetProductsWithCategory method is written exclusively for the Product Entity to retrieve each product’s category name along with its information.

## 📌 Project 12 -> OOP Module: FrmProduct Form in a Four-Layer Architecture
In this project, I completed the Add, Delete, Update, and Get by ID operations for the FrmProduct form I created for the Product Entity in the previous project. With this, I completed the #301 module of this bootcamp.
