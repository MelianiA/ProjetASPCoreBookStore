using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetASPCore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Big data ", "books of big data" },
                    { 2, "Database ", "books of database" },
                    { 3, "Front-End ", "books of Front-End" },
                    { 4, "Back-End ", "books of Back-End" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://images-na.ssl-images-amazon.com/images/I/51p6wBow%2B3L._SX389_BO1,204,203,200_.jpg", true, "Big data management is one of the major challenges facing business, industry, and not-for-profit organizations. Data sets such as customer transactions for a mega-retailer, weather patterns monitored by meteorologists, or social network activity can quickly outpace the capacity of traditional data management tools. If you need to develop or manage big data solutions, you’ll appreciate how these four experts define, explain, and guide you through this new and often confusing concept. You’ll learn what it is, why it matters, and how to choose and implement solutions that work.", "Big Data For Dummies", 98.0, "Big data management is one of the major challenges facing business, industry, and not-for-profit organizations" },
                    { 2, 1, "https://images-na.ssl-images-amazon.com/images/I/41JjodHnKHL._SX331_BO1,204,203,200_.jpg", true, "Bernard Marr’s Data Strategy is a must-have guide to creating a robust data strategy. Explaining how to identify your strategic data needs, what methods to use to collect the data and, most importantly, how to translate your data into organizational insights for improved business decision-making and performance, this is essential reading for anyone aiming to leverage the value of their business data and gain competitive advantage. Packed with case studies and real-world examples, advice on how to build data competencies in an organization and crucial coverage of how to ensure your data doesn’t become a liability, Data Strategy will equip any organization with the tools and strategies it needs to profit from big data, analytics and the Internet of Things.", "Big Data", 120.90000000000001, "Bernard Marr’s Data Strategy is a must-have guide to creating a robust data strategy" },
                    { 3, 2, "https://images-na.ssl-images-amazon.com/images/I/51UvR3a63OL._SX379_BO1,204,203,200_.jpg", true, "his book has been an evolving dream of ours for about five years. Laine came to the DBA role without any formal technical training. She was neither a software engineer nor a sysadmin; rather, she chose to develop a technical career after leaving music and theater. With this kind of background, the ideas of structure, harmony, counterpoint, and orchestration found in databases called to her.", "Database Engineering", 66.0, "This book has been an evolving dream of ours for about five years. Laine came to the DBA role without any formal technical training." },
                    { 4, 2, "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg", true, "Data is at the center of many challenges in system design today. Difficult issues need to be figured out, such as scalability, consistency, reliability, efficiency, and maintainability. In addition, we have an overwhelming variety of tools, including relational databases, NoSQL datastores, stream or batch processors, and message brokers. What are the right choices for your application? How do you make sense of all these buzzwords?.", "Data-Intensive", 66.0, "The Big Ideas Behind Reliable, Scalable, and Maintainable Systems " },
                    { 5, 3, "https://images-na.ssl-images-amazon.com/images/I/51gP9mXEqWL._SX379_BO1,204,203,200_.jpg", true, "This book is for anyone who is looking to get started with Angular (2.0 and onward), whether as a side project, as an additional tool, or for their main work. It is expected that readers are comfortable with JavaScript and HTML before starting this book, but a basic knowledge of JavaScript should be sufficient to learn Angular. Knowledge of AngularJS 1.0 is not needed or expected.We will also use TypeScript, which is the recommended way of developing in Angular, but a preliminary knowledge is sufficient to read this book.We will take it step by step, so relax and have fun learning with me..", "Angular", 66.0, "The Big Ideas Behind Reliable, Scalable, and Maintainable Systems " },
                    { 6, 3, "https://images-eu.ssl-images-amazon.com/images/I/51Q43WRXJzL.jpg", true, "f you want to learn how to build efficient user interfaces with React, this is your book. Authors Alex Banks and Eve Porcello show you how to create UIs with this small JavaScript library that can deftly display data changes on large-scale, data-driven websites without page reloads. Along the way, you’ll learn how to work with functional programming and the latest ECMAScript features.", "Learning React", 89.0, "Developed by Facebook, and used by companies including Netflix, Walmart, and The New York Times for large parts of their web interfaces " },
                    { 7, 4, "https://images-na.ssl-images-amazon.com/images/I/413Z89zzezL._SX348_BO1,204,203,200_.jpg", true, "This essential classic title provides a comprehensive foundation in the C# programming language and the frameworks it lives in. Now in its 8th edition, you’ll find all the very latest C# 7.1 and .NET 4.7 features here, along with four brand new chapters on Microsoft’s lightweight, cross-platform framework, .NET Core, up to and including .NET Core 2.0. Coverage of ASP.NET Core, Entity Framework (EF) Core, and more, sits alongside the latest updates to .NET, including Windows Presentation Foundation (WPF), Windows Communication Foundation (WCF), and ASP.NET MVC..", "Pro C# 7", 55.600000000000001, "Dive in and discover why Pro C# has been a favorite of C# developers worldwide for over 15 years" },
                    { 8, 4, "https://images-na.ssl-images-amazon.com/images/I/41NGBmeH1uL._SX403_BO1,204,203,200_.jpg", true, "Learning Node.js Development is a practical, project-based book that provides you with all you need to get started as a Node.js developer. Node is a ubiquitous technology on the modern web, and an essential part of any web developers' toolkit. If you are looking to create real-world Node applications, or you want to switch careers or launch a side project to generate some extra income, then you're in the right place. This book has been written around a single goal—turning you into a professional Node developer capable of developing, testing, and deploying real-world production applications.", "Learning Node.js", 98.0, "Learning Node.js Development: Learn the fundamentals of Node.js, and deploy and test Node.js applications on the web" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
