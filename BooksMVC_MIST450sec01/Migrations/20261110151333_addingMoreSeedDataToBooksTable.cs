using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMVC_MIST450sec01.Migrations
{
    /// <inheritdoc />
    public partial class addingMoreSeedDataToBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Author", "DatePublished", "Description", "Genre" },
                values: new object[] { "Graham Peace", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "This has no description", "Coding" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DatePublished", "Description", "Genre", "Price" },
                values: new object[] { new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "This has no description", "Coding", 19.99m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DatePublished", "Description", "Genre", "Price" },
                values: new object[] { new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "This has no description", "Coding", 19.99m });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "DatePublished", "Description", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 4, "J.R.R. Tolkien", new DateTime(1937, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fantasy adventure about Bilbo Baggins and his journey.", "Fantasy", 14.99m, "The Hobbit" },
                    { 5, "Agatha Christie", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A detective investigates a murder aboard a luxury train.", "Mystery", 12.99m, "Murder on the Orient Express" },
                    { 6, "Jane Austen", new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "A classic story of love, relationships and social expectations.", "Romance", 11.99m, "Pride and Prejudice" },
                    { 7, "Andy Weir", new DateTime(2011, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "An astronaut struggles to survive alone on Mars.", "Science Fiction", 16.99m, "The Martian" },
                    { 8, "Stephen King", new DateTime(1977, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "A writer encounters terrifying events at an isolated hotel.", "Horror", 15.99m, "The Shining" },
                    { 9, "Jon Krakauer", new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The true story of a young man's journey into the Alaskan wilderness.", "Adventure", 13.99m, "Into the Wild" },
                    { 10, "Dan Brown", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "A symbologist investigates a mysterious murder and a series of hidden clues.", "Thriller", 14.99m, "The Da Vinci Code" },
                    { 11, "Stieg Larsson", new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A journalist and a hacker investigate a decades-old disappearance.", "Thriller", 15.99m, "The Girl with the Dragon Tattoo" },
                    { 12, "Harper Lee", new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young girl experiences issues of justice and morality in the American South.", "Fiction", 13.99m, "To Kill a Mockingbird" },
                    { 13, "F. Scott Fitzgerald", new DateTime(1925, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A story of wealth, ambition, love, and the American Dream.", "Fiction", 12.99m, "The Great Gatsby" },
                    { 14, "Markus Zusak", new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young girl discovers the power of books during World War II Germany.", "Historical Fiction", 14.99m, "The Book Thief" },
                    { 15, "Anthony Doerr", new DateTime(2014, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two lives become intertwined during World War II.", "Historical Fiction", 16.99m, "All the Light We Cannot See" },
                    { 16, "Bill Bryson", new DateTime(1998, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A humorous account of hiking the Appalachian Trail.", "Travel", 13.99m, "A Walk in the Woods" },
                    { 17, "Paul Theroux", new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A travel writer explores the world through a series of railway journeys.", "Travel", 15.99m, "The Great Railway Bazaar" },
                    { 18, "Walter Isaacson", new DateTime(2011, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "A detailed account of the life and career of Apple co-founder Steve Jobs.", "Biography", 18.99m, "Steve Jobs" },
                    { 19, "Ron Chernow", new DateTime(2004, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The life story of Alexander Hamilton and his role in American history.", "Biography", 17.99m, "Alexander Hamilton" },
                    { 20, "Lorraine Hansberry", new DateTime(1959, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A family struggles with dreams, identity, and opportunity in Chicago.", "Drama", 11.99m, "A Raisin in the Sun" },
                    { 21, "Arthur Miller", new DateTime(1949, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A traveling salesman confronts his dreams and disappointments.", "Drama", 12.99m, "Death of a Salesman" },
                    { 22, "Douglas Adams", new DateTime(1979, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "An ordinary man travels through space in a hilarious intergalactic adventure.", "Comedy", 13.99m, "The Hitchhiker's Guide to the Galaxy" },
                    { 23, "Jerome K. Jerome", new DateTime(1889, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Three friends embark on a comic boating holiday along the River Thames.", "Comedy", 10.99m, "Three Men in a Boat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Author", "DatePublished", "Description", "Genre" },
                values: new object[] { "Salman Nazir", new DateTime(2025, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book has no description", "Programming" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DatePublished", "Description", "Genre", "Price" },
                values: new object[] { new DateTime(2026, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book has no description", "Programming", 29.99m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DatePublished", "Description", "Genre", "Price" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book has no description", "Programming", 15.99m });
        }
    }
}
