﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KnownAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LookingFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    SourceUserId = table.Column<int>(type: "int", nullable: false),
                    TargetUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.SourceUserId, x.TargetUserId });
                    table.ForeignKey(
                        name: "FK_Likes_Users_SourceUserId",
                        column: x => x.SourceUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_TargetUserId",
                        column: x => x.TargetUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    SenderUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipientId = table.Column<int>(type: "int", nullable: false),
                    RecipientUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRead = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MessageSent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RecipientDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Interests", "Introduction", "KnownAs", "LastActive", "LookingFor", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 43, DateTimeKind.Local).AddTicks(9741), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 45, DateTimeKind.Local).AddTicks(9740), null, new byte[] { 210, 89, 197, 97, 167, 163, 250, 208, 80, 132, 194, 35, 211, 241, 56, 192, 246, 26, 39, 54, 242, 26, 171, 131, 72, 243, 224, 43, 132, 110, 169, 166, 54, 171, 244, 81, 215, 26, 47, 203, 40, 254, 43, 216, 222, 245, 171, 10, 12, 232, 84, 46, 220, 100, 220, 187, 192, 252, 227, 234, 77, 6, 68, 53 }, new byte[] { 92, 46, 35, 126, 181, 232, 151, 69, 99, 240, 104, 68, 122, 232, 113, 149, 143, 209, 40, 126, 224, 223, 87, 186, 231, 18, 119, 154, 4, 245, 180, 255, 170, 93, 202, 226, 144, 213, 70, 51, 26, 135, 211, 70, 45, 180, 231, 72, 154, 85, 223, 142, 156, 148, 133, 162, 190, 126, 141, 3, 113, 161, 230, 13, 111, 20, 158, 234, 181, 5, 12, 93, 205, 58, 153, 74, 66, 188, 151, 217, 253, 115, 40, 139, 127, 181, 157, 115, 124, 203, 186, 132, 128, 144, 76, 32, 164, 239, 117, 63, 97, 124, 236, 87, 146, 234, 218, 5, 182, 245, 158, 99, 102, 208, 250, 180, 199, 183, 45, 186, 44, 92, 84, 38, 143, 227, 191, 204 }, "lisa" },
                    { 2, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7181), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7194), null, new byte[] { 129, 15, 208, 208, 238, 140, 176, 192, 244, 221, 158, 47, 143, 75, 70, 254, 252, 94, 40, 93, 108, 206, 34, 7, 136, 141, 234, 184, 129, 27, 104, 36, 109, 16, 135, 115, 241, 238, 92, 222, 95, 87, 70, 134, 42, 95, 39, 77, 18, 9, 255, 94, 18, 127, 193, 246, 231, 244, 173, 78, 146, 101, 15, 47 }, new byte[] { 232, 151, 78, 27, 21, 168, 176, 231, 97, 249, 225, 114, 101, 187, 121, 22, 111, 14, 155, 65, 87, 158, 203, 130, 156, 92, 182, 10, 136, 70, 172, 97, 30, 167, 99, 230, 134, 116, 134, 13, 51, 155, 184, 149, 182, 127, 205, 8, 66, 240, 141, 57, 14, 175, 246, 219, 31, 230, 254, 131, 45, 2, 32, 126, 193, 1, 91, 37, 49, 147, 250, 51, 134, 127, 109, 176, 255, 88, 218, 49, 21, 173, 54, 118, 128, 29, 139, 77, 148, 66, 83, 221, 40, 88, 191, 149, 255, 55, 177, 242, 5, 120, 220, 190, 89, 29, 115, 67, 248, 52, 21, 133, 28, 40, 29, 193, 113, 94, 142, 237, 150, 152, 141, 134, 65, 146, 79, 252 }, "karen" },
                    { 3, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7295), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7298), null, new byte[] { 231, 117, 158, 51, 77, 220, 3, 254, 38, 254, 61, 179, 138, 100, 197, 169, 33, 81, 178, 134, 95, 183, 92, 201, 211, 55, 248, 140, 192, 250, 201, 35, 93, 216, 246, 9, 177, 112, 9, 36, 44, 199, 225, 214, 238, 117, 107, 171, 86, 1, 128, 135, 53, 229, 44, 77, 33, 39, 174, 212, 108, 176, 114, 201 }, new byte[] { 198, 253, 122, 130, 154, 163, 236, 220, 69, 232, 178, 34, 178, 5, 134, 91, 52, 188, 178, 126, 190, 82, 173, 232, 210, 251, 199, 137, 253, 241, 189, 92, 109, 122, 170, 42, 30, 210, 116, 99, 12, 80, 4, 8, 253, 15, 183, 10, 14, 201, 90, 77, 138, 237, 92, 210, 52, 157, 21, 33, 198, 8, 37, 83, 250, 148, 170, 217, 124, 77, 68, 167, 31, 25, 201, 117, 151, 40, 75, 243, 33, 84, 44, 53, 89, 41, 37, 51, 77, 67, 38, 58, 248, 175, 186, 52, 82, 177, 54, 223, 174, 170, 29, 95, 103, 0, 26, 43, 64, 174, 187, 15, 238, 29, 51, 17, 183, 154, 165, 111, 51, 90, 167, 108, 196, 139, 34, 168 }, "margo" },
                    { 4, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7372), null, new byte[] { 35, 107, 78, 123, 111, 34, 155, 81, 140, 255, 226, 236, 43, 61, 249, 68, 226, 135, 92, 51, 188, 37, 214, 132, 96, 195, 176, 192, 171, 150, 219, 123, 49, 3, 190, 6, 191, 45, 222, 78, 146, 80, 186, 46, 101, 64, 128, 120, 154, 185, 183, 103, 209, 72, 146, 4, 56, 243, 231, 64, 123, 86, 50, 161 }, new byte[] { 43, 205, 82, 22, 15, 107, 227, 51, 100, 181, 166, 162, 95, 28, 36, 228, 240, 116, 103, 100, 200, 217, 223, 221, 35, 45, 5, 159, 146, 134, 25, 18, 86, 178, 32, 159, 13, 172, 37, 115, 63, 37, 190, 2, 17, 218, 110, 84, 51, 182, 41, 166, 228, 221, 30, 34, 200, 8, 202, 114, 134, 68, 217, 113, 5, 43, 208, 90, 42, 118, 51, 254, 78, 29, 106, 211, 67, 156, 54, 7, 112, 246, 192, 122, 214, 33, 203, 176, 246, 34, 51, 181, 43, 161, 230, 8, 249, 11, 4, 161, 138, 162, 49, 169, 4, 153, 127, 69, 42, 163, 173, 36, 101, 77, 69, 77, 17, 94, 237, 165, 153, 45, 91, 25, 135, 208, 93, 99 }, "lois" },
                    { 5, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7408), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7410), null, new byte[] { 175, 224, 231, 224, 163, 207, 167, 125, 25, 135, 78, 44, 47, 100, 44, 74, 220, 30, 104, 187, 202, 43, 118, 74, 42, 251, 67, 95, 15, 46, 134, 130, 117, 195, 74, 166, 190, 223, 45, 142, 160, 192, 155, 18, 22, 113, 121, 161, 120, 102, 12, 185, 108, 44, 1, 11, 194, 60, 23, 129, 95, 124, 119, 165 }, new byte[] { 201, 179, 48, 30, 162, 173, 192, 159, 245, 157, 244, 149, 177, 97, 219, 221, 249, 254, 166, 224, 9, 236, 200, 30, 15, 143, 119, 32, 50, 47, 207, 127, 118, 219, 136, 237, 158, 168, 254, 199, 74, 111, 82, 125, 90, 19, 152, 155, 27, 190, 23, 18, 163, 182, 114, 70, 226, 15, 164, 249, 9, 218, 30, 131, 3, 10, 147, 116, 20, 194, 146, 159, 238, 40, 82, 67, 233, 57, 135, 2, 186, 252, 25, 254, 137, 125, 41, 23, 46, 47, 89, 202, 211, 195, 132, 250, 211, 127, 158, 127, 130, 207, 43, 86, 101, 42, 2, 55, 172, 86, 96, 4, 165, 159, 219, 183, 181, 135, 91, 236, 192, 179, 107, 240, 171, 248, 145, 75 }, "ruthie" },
                    { 6, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7445), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7448), null, new byte[] { 24, 148, 63, 134, 32, 1, 194, 91, 213, 129, 56, 55, 12, 51, 7, 84, 217, 42, 46, 138, 78, 18, 146, 115, 158, 93, 83, 156, 115, 254, 233, 195, 128, 80, 14, 170, 14, 239, 56, 210, 137, 139, 206, 80, 74, 142, 44, 190, 222, 13, 248, 102, 64, 16, 170, 178, 186, 77, 9, 189, 237, 101, 137, 113 }, new byte[] { 90, 112, 91, 84, 253, 207, 47, 103, 231, 79, 40, 155, 25, 10, 143, 140, 193, 248, 196, 23, 184, 85, 15, 111, 5, 202, 1, 103, 126, 241, 32, 131, 53, 162, 128, 93, 229, 80, 247, 97, 152, 234, 242, 160, 30, 57, 196, 221, 73, 231, 63, 20, 18, 163, 84, 139, 166, 6, 151, 42, 177, 237, 71, 121, 54, 209, 32, 86, 241, 34, 224, 210, 100, 133, 112, 12, 47, 39, 231, 154, 249, 41, 9, 237, 179, 143, 36, 36, 203, 158, 133, 236, 73, 216, 240, 47, 167, 6, 82, 114, 21, 215, 225, 39, 1, 55, 46, 253, 210, 61, 84, 44, 211, 98, 62, 169, 35, 219, 218, 232, 64, 55, 179, 157, 246, 191, 201, 129 }, "todd" },
                    { 7, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7483), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7486), null, new byte[] { 69, 169, 246, 90, 67, 97, 120, 7, 121, 59, 224, 63, 241, 112, 61, 108, 194, 14, 149, 40, 191, 96, 58, 233, 81, 127, 74, 81, 70, 245, 73, 141, 130, 120, 134, 101, 174, 183, 17, 94, 231, 37, 26, 43, 1, 104, 127, 129, 93, 227, 246, 76, 214, 32, 9, 39, 154, 170, 93, 19, 58, 128, 199, 43 }, new byte[] { 214, 96, 38, 58, 236, 187, 120, 173, 81, 17, 138, 241, 117, 251, 158, 33, 61, 107, 62, 80, 169, 245, 84, 6, 102, 56, 8, 10, 30, 117, 94, 79, 145, 233, 149, 96, 219, 217, 74, 153, 7, 113, 88, 160, 167, 11, 17, 133, 192, 216, 24, 237, 181, 24, 122, 66, 17, 152, 116, 224, 13, 171, 133, 185, 159, 246, 125, 202, 205, 78, 2, 23, 83, 242, 103, 88, 141, 109, 148, 90, 92, 223, 43, 146, 61, 82, 160, 53, 191, 88, 150, 80, 32, 87, 86, 197, 5, 169, 111, 242, 1, 190, 214, 47, 94, 98, 191, 6, 55, 48, 204, 97, 43, 23, 3, 236, 108, 249, 242, 182, 196, 122, 162, 80, 180, 70, 195, 151 }, "porter" },
                    { 8, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7658), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7660), null, new byte[] { 29, 230, 98, 94, 110, 25, 143, 68, 98, 214, 250, 184, 39, 84, 41, 146, 128, 61, 72, 161, 180, 66, 140, 39, 45, 25, 144, 146, 117, 47, 208, 120, 53, 58, 172, 153, 178, 58, 22, 74, 101, 169, 191, 31, 91, 254, 158, 217, 87, 70, 42, 133, 1, 127, 111, 206, 55, 42, 3, 75, 25, 95, 231, 1 }, new byte[] { 102, 28, 148, 252, 174, 225, 154, 122, 0, 1, 161, 32, 13, 162, 112, 85, 83, 244, 113, 97, 156, 29, 184, 143, 114, 28, 247, 98, 53, 208, 52, 60, 117, 254, 204, 114, 37, 140, 177, 64, 9, 50, 30, 16, 139, 192, 212, 119, 55, 255, 141, 9, 232, 162, 71, 200, 42, 166, 195, 175, 86, 194, 186, 10, 114, 88, 163, 108, 15, 232, 220, 66, 5, 193, 4, 128, 192, 192, 238, 192, 53, 218, 87, 22, 89, 8, 106, 210, 202, 64, 170, 255, 195, 100, 254, 7, 90, 25, 180, 203, 156, 48, 114, 223, 204, 58, 25, 157, 23, 0, 112, 179, 118, 155, 130, 168, 45, 244, 224, 240, 252, 75, 110, 123, 79, 122, 95, 32 }, "mayo" },
                    { 9, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7698), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7701), null, new byte[] { 221, 191, 125, 10, 128, 170, 27, 79, 221, 153, 16, 140, 185, 63, 192, 147, 125, 148, 176, 138, 40, 216, 29, 166, 242, 89, 238, 29, 77, 127, 252, 146, 248, 132, 114, 142, 56, 176, 27, 197, 57, 60, 130, 72, 233, 3, 123, 73, 170, 49, 56, 28, 113, 236, 71, 213, 70, 151, 15, 2, 113, 30, 149, 107 }, new byte[] { 234, 89, 181, 222, 68, 226, 239, 108, 10, 206, 254, 84, 62, 115, 252, 153, 89, 217, 20, 234, 168, 75, 108, 202, 94, 108, 181, 174, 217, 40, 6, 97, 208, 206, 112, 115, 224, 179, 102, 14, 123, 179, 157, 37, 139, 60, 57, 114, 224, 184, 65, 21, 173, 23, 26, 90, 198, 125, 160, 36, 215, 210, 148, 232, 29, 149, 167, 75, 178, 243, 60, 10, 196, 117, 201, 171, 63, 230, 232, 117, 27, 77, 92, 48, 62, 124, 195, 195, 140, 183, 127, 105, 35, 197, 194, 89, 141, 251, 197, 97, 97, 104, 71, 232, 66, 147, 212, 63, 12, 112, 23, 209, 119, 71, 24, 177, 151, 131, 72, 163, 118, 53, 96, 187, 150, 11, 128, 211 }, "skinner" },
                    { 10, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7737), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2022, 12, 18, 22, 49, 33, 47, DateTimeKind.Local).AddTicks(7740), null, new byte[] { 1, 200, 207, 180, 12, 142, 124, 154, 105, 57, 250, 184, 1, 164, 48, 198, 211, 185, 102, 27, 47, 166, 60, 167, 206, 221, 27, 140, 135, 208, 108, 134, 71, 138, 48, 28, 247, 150, 36, 118, 29, 196, 100, 141, 23, 121, 10, 89, 159, 65, 9, 195, 156, 244, 79, 190, 35, 196, 109, 107, 13, 42, 107, 190 }, new byte[] { 73, 32, 152, 222, 235, 180, 59, 185, 3, 38, 238, 76, 250, 133, 121, 14, 153, 120, 242, 4, 63, 166, 136, 201, 39, 114, 122, 217, 18, 103, 177, 70, 161, 161, 26, 219, 132, 186, 81, 138, 229, 246, 68, 227, 23, 92, 23, 18, 23, 206, 68, 182, 245, 249, 208, 47, 84, 236, 159, 205, 164, 82, 139, 94, 136, 250, 74, 227, 182, 54, 3, 231, 51, 31, 191, 94, 88, 156, 129, 140, 209, 53, 62, 122, 62, 155, 2, 114, 219, 145, 241, 109, 52, 143, 254, 211, 172, 163, 241, 129, 204, 131, 7, 93, 189, 21, 8, 29, 47, 46, 236, 136, 98, 163, 249, 91, 125, 247, 147, 27, 201, 70, 144, 93, 250, 198, 85, 66 }, "david" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_TargetUserId",
                table: "Likes",
                column: "TargetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_RecipientId",
                table: "Messages",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AppUserId",
                table: "Photos",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
