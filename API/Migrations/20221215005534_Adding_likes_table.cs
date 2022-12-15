﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Adding_likes_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 196, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 12, 15, 1, 55, 34, 198, DateTimeKind.Local).AddTicks(4228), new byte[] { 244, 208, 201, 31, 138, 42, 211, 201, 241, 204, 141, 230, 14, 218, 36, 71, 1, 152, 139, 206, 90, 250, 77, 162, 185, 184, 219, 105, 53, 188, 14, 148, 88, 124, 12, 245, 21, 73, 233, 133, 12, 18, 86, 92, 189, 227, 165, 170, 197, 227, 199, 166, 114, 55, 89, 18, 193, 154, 51, 210, 232, 210, 234, 117 }, new byte[] { 217, 99, 21, 89, 16, 73, 255, 150, 12, 86, 243, 59, 219, 45, 231, 215, 214, 217, 84, 162, 116, 15, 0, 37, 75, 233, 197, 113, 217, 55, 95, 93, 143, 130, 178, 151, 7, 233, 116, 247, 250, 120, 215, 140, 191, 179, 243, 28, 235, 239, 111, 246, 146, 237, 95, 9, 104, 115, 229, 254, 193, 62, 68, 107, 26, 145, 19, 165, 254, 231, 237, 171, 2, 118, 170, 69, 160, 160, 89, 149, 117, 107, 66, 30, 0, 106, 221, 76, 25, 105, 154, 70, 72, 161, 1, 89, 1, 12, 90, 105, 125, 34, 201, 113, 7, 127, 241, 113, 202, 175, 3, 164, 59, 105, 49, 7, 84, 61, 19, 115, 216, 243, 164, 215, 2, 77, 131, 72 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(1928), new byte[] { 186, 49, 32, 14, 105, 18, 180, 121, 36, 187, 18, 116, 199, 28, 159, 26, 244, 234, 112, 43, 180, 244, 113, 174, 67, 187, 137, 172, 110, 35, 142, 87, 25, 86, 72, 75, 120, 213, 23, 243, 134, 232, 162, 148, 187, 232, 212, 158, 39, 6, 101, 191, 71, 134, 42, 215, 38, 99, 136, 32, 90, 150, 127, 77 }, new byte[] { 211, 124, 19, 183, 146, 153, 63, 82, 247, 210, 49, 111, 80, 67, 21, 61, 113, 63, 146, 205, 98, 116, 210, 31, 148, 27, 195, 117, 116, 164, 75, 211, 238, 138, 105, 56, 52, 102, 157, 127, 152, 54, 133, 40, 4, 4, 94, 78, 42, 167, 155, 137, 210, 184, 42, 229, 219, 113, 62, 189, 174, 63, 72, 197, 84, 187, 178, 44, 79, 228, 199, 124, 248, 219, 49, 247, 44, 62, 72, 82, 162, 34, 29, 181, 121, 131, 156, 129, 240, 236, 14, 171, 64, 167, 87, 68, 217, 207, 144, 165, 237, 152, 85, 120, 2, 46, 14, 132, 31, 137, 162, 170, 218, 5, 173, 19, 109, 22, 30, 155, 23, 229, 135, 16, 255, 207, 208, 241 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2026), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2029), new byte[] { 137, 245, 53, 140, 166, 29, 222, 140, 136, 70, 202, 112, 4, 150, 119, 217, 120, 32, 40, 106, 158, 165, 6, 114, 194, 217, 239, 148, 132, 17, 150, 61, 40, 36, 170, 37, 102, 136, 19, 21, 91, 80, 82, 246, 125, 69, 211, 132, 91, 253, 167, 236, 160, 16, 19, 149, 188, 207, 82, 105, 187, 233, 38, 153 }, new byte[] { 154, 150, 91, 62, 145, 19, 75, 202, 219, 69, 80, 143, 92, 126, 129, 150, 166, 211, 69, 59, 78, 102, 231, 189, 36, 88, 153, 103, 172, 62, 208, 242, 254, 189, 71, 33, 149, 89, 79, 26, 117, 40, 108, 182, 114, 19, 224, 1, 18, 150, 227, 63, 136, 234, 122, 220, 89, 40, 212, 161, 7, 238, 203, 160, 160, 243, 214, 19, 91, 185, 220, 218, 97, 11, 18, 197, 59, 41, 3, 217, 23, 65, 108, 143, 126, 19, 159, 5, 137, 108, 102, 197, 238, 48, 99, 104, 70, 234, 6, 82, 26, 93, 85, 93, 246, 113, 49, 136, 35, 47, 141, 170, 250, 206, 233, 1, 3, 114, 189, 137, 121, 117, 204, 3, 106, 92, 65, 187 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2157), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2160), new byte[] { 75, 188, 30, 28, 81, 95, 249, 173, 159, 0, 133, 54, 68, 28, 124, 26, 71, 186, 169, 240, 215, 42, 212, 246, 135, 201, 198, 123, 181, 86, 247, 156, 203, 139, 128, 127, 254, 51, 252, 155, 161, 170, 249, 198, 209, 35, 182, 160, 209, 223, 102, 86, 46, 171, 216, 248, 93, 221, 92, 211, 209, 249, 69, 20 }, new byte[] { 34, 18, 107, 136, 253, 228, 17, 49, 97, 121, 54, 75, 247, 222, 201, 133, 2, 156, 174, 239, 59, 92, 187, 216, 182, 177, 248, 118, 95, 240, 11, 94, 188, 37, 77, 207, 226, 186, 99, 181, 177, 18, 75, 166, 174, 171, 74, 243, 49, 221, 138, 154, 112, 191, 99, 121, 251, 126, 220, 133, 187, 206, 62, 100, 226, 70, 52, 47, 91, 133, 198, 233, 118, 124, 233, 138, 84, 11, 6, 203, 196, 139, 124, 234, 124, 158, 128, 63, 41, 146, 36, 149, 220, 164, 44, 11, 100, 183, 196, 116, 236, 26, 197, 149, 239, 94, 228, 164, 96, 80, 206, 251, 106, 145, 197, 150, 199, 86, 243, 163, 232, 199, 160, 107, 9, 70, 253, 198 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2287), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2289), new byte[] { 142, 2, 133, 248, 225, 173, 132, 13, 160, 10, 18, 111, 11, 168, 30, 121, 197, 74, 64, 31, 119, 114, 5, 46, 170, 110, 214, 176, 131, 24, 111, 173, 8, 91, 99, 93, 148, 189, 174, 156, 230, 181, 129, 87, 125, 240, 164, 36, 27, 213, 47, 73, 187, 255, 91, 187, 105, 100, 115, 131, 179, 238, 164, 247 }, new byte[] { 93, 134, 60, 4, 228, 39, 166, 183, 114, 146, 169, 134, 252, 47, 85, 190, 97, 24, 153, 158, 118, 65, 95, 235, 206, 222, 8, 133, 149, 113, 162, 43, 121, 201, 104, 201, 248, 49, 236, 223, 53, 61, 27, 196, 152, 229, 79, 253, 30, 37, 216, 78, 223, 76, 119, 17, 59, 217, 132, 121, 178, 53, 72, 152, 233, 7, 175, 41, 0, 200, 116, 133, 151, 216, 184, 52, 197, 233, 17, 129, 126, 105, 72, 47, 210, 59, 94, 175, 90, 72, 141, 205, 250, 215, 112, 163, 180, 79, 217, 86, 65, 96, 215, 212, 249, 207, 147, 125, 249, 96, 111, 211, 127, 250, 134, 5, 197, 216, 221, 118, 121, 206, 126, 212, 82, 12, 172, 87 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2326), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2329), new byte[] { 179, 221, 25, 137, 252, 198, 44, 44, 103, 24, 255, 122, 130, 145, 224, 102, 83, 199, 208, 94, 140, 22, 240, 41, 67, 86, 14, 54, 35, 118, 215, 184, 56, 210, 131, 95, 59, 226, 103, 202, 30, 203, 48, 191, 122, 137, 87, 24, 74, 154, 208, 12, 165, 182, 229, 149, 221, 169, 155, 120, 70, 114, 111, 204 }, new byte[] { 44, 150, 240, 216, 239, 199, 7, 151, 23, 158, 218, 33, 145, 92, 235, 2, 222, 106, 215, 123, 215, 163, 32, 198, 138, 76, 114, 168, 152, 104, 179, 215, 131, 62, 244, 208, 157, 172, 14, 5, 212, 224, 140, 111, 114, 35, 160, 159, 174, 179, 170, 45, 90, 25, 78, 222, 218, 64, 189, 81, 35, 39, 123, 29, 77, 118, 170, 245, 36, 181, 180, 232, 41, 128, 12, 161, 218, 247, 206, 34, 18, 224, 245, 198, 186, 8, 155, 128, 162, 20, 117, 22, 136, 235, 177, 209, 139, 210, 196, 232, 32, 72, 125, 139, 254, 110, 167, 185, 203, 53, 130, 107, 13, 222, 29, 129, 41, 181, 35, 236, 83, 107, 254, 78, 137, 213, 94, 89 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2365), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2368), new byte[] { 221, 50, 101, 83, 83, 45, 220, 243, 162, 26, 164, 132, 51, 122, 131, 154, 234, 177, 35, 78, 16, 223, 199, 133, 111, 186, 177, 244, 101, 167, 69, 149, 20, 15, 122, 22, 46, 237, 147, 183, 153, 31, 179, 93, 155, 216, 180, 130, 94, 69, 63, 44, 140, 189, 84, 239, 132, 99, 248, 9, 203, 0, 135, 101 }, new byte[] { 235, 212, 223, 126, 105, 136, 165, 49, 215, 146, 61, 137, 29, 79, 106, 92, 190, 253, 66, 243, 53, 195, 141, 176, 223, 147, 71, 15, 252, 110, 231, 46, 167, 88, 98, 6, 64, 37, 177, 229, 13, 136, 2, 96, 68, 154, 193, 154, 27, 223, 2, 134, 76, 160, 54, 48, 141, 244, 141, 178, 133, 172, 198, 51, 25, 147, 46, 246, 158, 61, 232, 10, 191, 17, 185, 87, 211, 233, 111, 126, 0, 140, 223, 75, 73, 254, 161, 92, 185, 11, 123, 46, 65, 220, 232, 255, 74, 163, 245, 217, 39, 187, 149, 182, 145, 149, 77, 30, 197, 93, 134, 210, 208, 79, 50, 44, 139, 159, 225, 60, 91, 151, 95, 126, 115, 57, 30, 109 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2423), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2426), new byte[] { 116, 154, 229, 175, 186, 194, 35, 79, 13, 249, 222, 101, 254, 203, 117, 252, 227, 200, 19, 84, 165, 101, 240, 200, 157, 108, 108, 90, 129, 104, 0, 42, 211, 224, 216, 109, 148, 157, 7, 72, 236, 155, 242, 149, 73, 59, 186, 136, 174, 132, 102, 68, 241, 51, 4, 19, 171, 67, 199, 203, 157, 191, 134, 241 }, new byte[] { 114, 138, 68, 50, 39, 144, 86, 93, 71, 136, 52, 159, 48, 96, 34, 248, 191, 85, 205, 89, 233, 10, 82, 14, 229, 1, 130, 195, 64, 24, 9, 68, 182, 188, 51, 196, 193, 71, 117, 121, 106, 151, 39, 17, 93, 16, 92, 139, 93, 119, 86, 227, 44, 220, 168, 245, 101, 69, 82, 54, 149, 82, 13, 2, 181, 53, 227, 162, 87, 97, 235, 11, 70, 132, 165, 253, 215, 19, 169, 149, 130, 249, 70, 203, 26, 106, 7, 110, 9, 15, 49, 157, 17, 113, 244, 145, 30, 13, 214, 34, 175, 41, 76, 218, 172, 162, 157, 21, 91, 191, 117, 199, 136, 84, 244, 95, 237, 158, 150, 160, 54, 87, 174, 208, 152, 31, 242, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2462), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2464), new byte[] { 6, 77, 166, 111, 188, 77, 148, 13, 178, 228, 92, 95, 192, 198, 168, 12, 163, 126, 34, 129, 11, 206, 110, 179, 245, 211, 254, 240, 143, 21, 127, 70, 99, 251, 95, 181, 159, 156, 172, 218, 76, 211, 23, 197, 95, 42, 36, 238, 115, 247, 82, 44, 25, 159, 196, 25, 46, 18, 35, 92, 130, 37, 217, 219 }, new byte[] { 186, 128, 160, 190, 214, 30, 137, 115, 225, 81, 1, 201, 203, 0, 69, 207, 44, 139, 168, 222, 12, 178, 46, 159, 196, 26, 253, 179, 9, 160, 60, 140, 239, 30, 223, 72, 209, 149, 243, 218, 197, 238, 17, 89, 107, 91, 231, 126, 197, 37, 104, 191, 67, 67, 72, 164, 213, 161, 203, 28, 75, 236, 253, 201, 40, 37, 5, 16, 82, 142, 192, 215, 43, 178, 160, 49, 225, 39, 153, 1, 38, 207, 110, 236, 52, 111, 210, 159, 30, 216, 132, 245, 237, 228, 8, 64, 140, 228, 251, 125, 229, 222, 196, 232, 236, 101, 88, 117, 63, 244, 15, 176, 95, 186, 158, 192, 20, 67, 221, 219, 35, 80, 127, 106, 3, 56, 202, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2499), new DateTime(2022, 12, 15, 1, 55, 34, 200, DateTimeKind.Local).AddTicks(2502), new byte[] { 246, 54, 101, 254, 187, 79, 211, 229, 250, 253, 79, 67, 226, 119, 239, 30, 233, 215, 212, 236, 235, 13, 225, 248, 53, 36, 219, 79, 227, 82, 221, 211, 105, 174, 6, 91, 125, 203, 24, 145, 22, 138, 45, 90, 72, 134, 109, 34, 30, 90, 244, 54, 152, 250, 103, 150, 210, 110, 159, 240, 154, 157, 78, 155 }, new byte[] { 196, 134, 154, 150, 42, 82, 193, 116, 202, 63, 177, 76, 139, 29, 172, 73, 211, 11, 115, 17, 43, 48, 145, 21, 148, 231, 235, 28, 115, 100, 190, 193, 82, 72, 61, 189, 38, 178, 161, 168, 199, 90, 85, 220, 208, 200, 28, 215, 144, 97, 3, 111, 38, 158, 100, 219, 233, 10, 43, 10, 186, 158, 136, 7, 250, 146, 130, 154, 234, 208, 79, 45, 110, 140, 100, 80, 170, 204, 229, 31, 205, 243, 122, 217, 135, 18, 59, 185, 164, 91, 103, 77, 46, 102, 78, 215, 252, 67, 151, 108, 186, 211, 188, 28, 80, 225, 113, 146, 7, 236, 156, 148, 54, 140, 212, 188, 97, 195, 73, 171, 181, 213, 157, 254, 44, 77, 198, 234 } });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_TargetUserId",
                table: "Likes",
                column: "TargetUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 581, DateTimeKind.Local).AddTicks(1875), new DateTime(2022, 12, 4, 20, 30, 7, 583, DateTimeKind.Local).AddTicks(1655), new byte[] { 61, 70, 155, 222, 239, 13, 54, 244, 63, 222, 8, 85, 94, 32, 53, 12, 145, 246, 199, 196, 145, 145, 222, 217, 188, 251, 170, 74, 91, 222, 203, 28, 230, 28, 82, 234, 86, 139, 77, 27, 110, 131, 157, 133, 111, 88, 173, 31, 47, 174, 138, 17, 209, 187, 78, 126, 1, 161, 51, 80, 116, 22, 111, 141 }, new byte[] { 222, 212, 200, 212, 166, 150, 84, 104, 193, 224, 143, 130, 27, 173, 254, 223, 80, 81, 57, 59, 64, 131, 107, 100, 186, 79, 170, 67, 223, 31, 35, 124, 147, 59, 202, 103, 161, 35, 203, 3, 19, 95, 185, 73, 234, 45, 149, 49, 144, 69, 204, 94, 224, 160, 148, 121, 34, 8, 201, 84, 211, 15, 180, 62, 182, 6, 145, 235, 84, 8, 245, 214, 223, 121, 194, 232, 150, 48, 99, 173, 71, 134, 74, 202, 167, 46, 80, 225, 29, 199, 33, 192, 61, 238, 18, 111, 70, 128, 252, 92, 37, 134, 155, 76, 61, 19, 12, 224, 79, 49, 218, 21, 131, 8, 71, 47, 100, 230, 225, 44, 108, 86, 163, 10, 83, 63, 171, 154 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(504), new byte[] { 106, 87, 249, 157, 205, 67, 34, 223, 114, 33, 5, 100, 244, 34, 117, 210, 75, 107, 71, 34, 7, 121, 74, 1, 208, 151, 0, 36, 245, 201, 79, 173, 160, 79, 139, 192, 199, 61, 30, 198, 66, 184, 150, 23, 73, 196, 185, 32, 22, 132, 19, 86, 63, 182, 88, 234, 180, 195, 153, 54, 247, 77, 59, 248 }, new byte[] { 23, 122, 43, 188, 25, 218, 240, 152, 69, 112, 224, 46, 249, 81, 119, 67, 215, 162, 240, 252, 6, 45, 111, 62, 81, 159, 181, 19, 207, 45, 87, 35, 132, 206, 193, 13, 113, 134, 71, 181, 142, 82, 29, 107, 200, 100, 181, 79, 209, 142, 94, 116, 96, 26, 250, 209, 49, 141, 123, 177, 82, 119, 51, 22, 226, 107, 171, 132, 254, 249, 201, 155, 186, 138, 254, 99, 215, 248, 254, 168, 130, 48, 0, 131, 20, 143, 97, 148, 114, 7, 84, 244, 209, 139, 163, 93, 54, 76, 142, 199, 236, 10, 93, 211, 206, 6, 142, 165, 206, 211, 59, 180, 120, 124, 98, 167, 162, 14, 23, 253, 229, 174, 95, 79, 13, 157, 237, 44 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(629), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(632), new byte[] { 79, 190, 202, 161, 32, 34, 154, 27, 156, 56, 75, 101, 216, 142, 36, 51, 124, 148, 118, 220, 250, 6, 27, 51, 252, 180, 91, 174, 208, 121, 222, 233, 154, 124, 177, 150, 133, 227, 112, 45, 215, 182, 231, 169, 238, 55, 4, 86, 150, 220, 154, 63, 32, 63, 225, 100, 86, 20, 27, 163, 50, 4, 239, 94 }, new byte[] { 176, 179, 151, 109, 255, 106, 247, 93, 152, 114, 158, 138, 218, 32, 216, 29, 97, 165, 30, 118, 106, 36, 218, 57, 139, 69, 3, 195, 150, 235, 232, 70, 132, 186, 174, 2, 158, 28, 232, 171, 11, 125, 182, 253, 40, 125, 4, 202, 129, 107, 58, 11, 32, 120, 97, 71, 173, 45, 159, 87, 62, 217, 212, 114, 252, 89, 180, 32, 138, 53, 219, 36, 211, 9, 71, 213, 196, 83, 158, 111, 242, 156, 36, 175, 242, 169, 117, 139, 235, 240, 243, 132, 124, 75, 90, 162, 215, 95, 212, 98, 90, 229, 223, 109, 192, 216, 63, 123, 119, 82, 38, 168, 108, 22, 61, 25, 94, 150, 109, 202, 182, 236, 149, 89, 179, 10, 212, 35 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(670), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(673), new byte[] { 69, 9, 155, 71, 97, 48, 156, 21, 106, 191, 33, 61, 160, 204, 113, 71, 133, 120, 125, 41, 177, 195, 157, 29, 140, 171, 68, 141, 237, 162, 209, 177, 160, 26, 237, 125, 248, 13, 251, 54, 81, 38, 41, 239, 55, 53, 255, 120, 112, 16, 175, 54, 156, 60, 178, 114, 228, 209, 15, 160, 202, 202, 52, 121 }, new byte[] { 86, 110, 250, 29, 103, 187, 3, 250, 226, 234, 35, 115, 62, 116, 71, 242, 87, 89, 60, 147, 58, 103, 117, 16, 111, 58, 121, 84, 60, 47, 174, 106, 123, 126, 121, 61, 89, 204, 83, 92, 209, 14, 174, 195, 149, 205, 140, 134, 90, 126, 9, 137, 150, 136, 203, 215, 22, 223, 241, 53, 62, 117, 87, 68, 125, 124, 115, 25, 136, 98, 119, 13, 234, 70, 198, 49, 0, 103, 158, 73, 95, 107, 85, 134, 74, 77, 119, 51, 85, 160, 187, 7, 84, 5, 79, 232, 194, 153, 233, 222, 198, 177, 117, 193, 83, 60, 237, 252, 199, 178, 142, 142, 10, 141, 175, 3, 153, 60, 155, 91, 55, 153, 184, 147, 252, 183, 105, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(710), new byte[] { 33, 124, 255, 75, 142, 10, 42, 13, 207, 72, 112, 211, 251, 178, 129, 171, 52, 185, 196, 244, 118, 45, 104, 60, 186, 159, 147, 77, 67, 138, 96, 162, 64, 165, 243, 85, 186, 173, 235, 117, 143, 42, 218, 122, 82, 81, 107, 146, 25, 47, 182, 250, 111, 38, 0, 36, 167, 100, 144, 99, 83, 68, 81, 8 }, new byte[] { 208, 207, 81, 140, 183, 84, 228, 41, 64, 120, 139, 132, 219, 44, 9, 86, 91, 179, 55, 138, 23, 102, 197, 103, 167, 108, 74, 40, 237, 178, 18, 60, 126, 114, 37, 234, 6, 64, 97, 251, 24, 162, 228, 97, 64, 61, 172, 132, 116, 62, 195, 212, 99, 38, 155, 10, 33, 162, 51, 214, 251, 234, 4, 1, 45, 183, 193, 31, 90, 176, 153, 162, 194, 18, 252, 98, 179, 113, 73, 204, 172, 225, 251, 112, 14, 97, 105, 226, 0, 54, 8, 29, 37, 118, 49, 33, 77, 38, 190, 62, 94, 197, 165, 105, 156, 49, 16, 242, 70, 11, 132, 108, 145, 129, 9, 24, 120, 63, 37, 157, 70, 33, 181, 18, 23, 105, 142, 86 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(745), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(748), new byte[] { 121, 98, 39, 122, 225, 104, 44, 192, 45, 15, 144, 18, 158, 56, 244, 190, 89, 232, 114, 250, 119, 56, 215, 156, 152, 2, 174, 231, 206, 116, 131, 216, 79, 90, 217, 139, 3, 194, 38, 77, 195, 192, 5, 128, 28, 0, 37, 194, 181, 48, 232, 74, 210, 1, 9, 25, 24, 45, 147, 102, 98, 221, 192, 246 }, new byte[] { 18, 99, 18, 37, 19, 198, 76, 83, 136, 251, 43, 77, 76, 45, 201, 237, 31, 239, 106, 76, 94, 67, 203, 201, 75, 196, 10, 63, 67, 209, 86, 39, 97, 45, 90, 169, 246, 133, 99, 154, 105, 83, 234, 224, 143, 246, 239, 71, 107, 239, 197, 195, 105, 254, 233, 112, 39, 221, 61, 154, 20, 165, 82, 159, 191, 81, 49, 157, 72, 91, 139, 69, 202, 241, 204, 72, 66, 195, 94, 211, 14, 77, 70, 28, 52, 143, 231, 254, 42, 246, 95, 75, 8, 119, 158, 201, 219, 69, 210, 88, 223, 140, 201, 151, 56, 142, 13, 78, 245, 16, 241, 192, 156, 93, 95, 118, 109, 67, 8, 168, 104, 116, 14, 78, 155, 207, 93, 120 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(873), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(875), new byte[] { 33, 168, 216, 230, 210, 39, 252, 246, 172, 164, 199, 89, 105, 12, 240, 132, 245, 243, 211, 250, 229, 13, 26, 73, 253, 111, 208, 228, 160, 201, 76, 233, 208, 230, 154, 114, 78, 50, 26, 67, 125, 35, 132, 14, 41, 190, 24, 39, 17, 146, 138, 110, 7, 247, 164, 200, 17, 82, 52, 2, 204, 155, 109, 242 }, new byte[] { 178, 88, 102, 235, 209, 79, 190, 86, 166, 240, 128, 251, 141, 131, 229, 13, 87, 210, 14, 19, 120, 19, 181, 226, 9, 231, 188, 38, 126, 71, 215, 69, 230, 93, 133, 27, 140, 239, 151, 22, 220, 214, 78, 246, 7, 220, 54, 104, 254, 117, 122, 190, 52, 15, 167, 206, 129, 169, 161, 68, 86, 119, 21, 27, 226, 67, 3, 99, 222, 196, 19, 114, 236, 233, 40, 254, 60, 80, 76, 69, 253, 150, 63, 140, 113, 250, 19, 52, 147, 39, 18, 82, 249, 85, 27, 254, 19, 173, 238, 186, 172, 151, 255, 103, 195, 157, 154, 60, 60, 239, 115, 102, 236, 43, 138, 116, 173, 63, 187, 161, 187, 173, 47, 80, 17, 213, 150, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(912), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(914), new byte[] { 185, 86, 174, 155, 239, 28, 166, 93, 37, 190, 3, 224, 78, 247, 249, 35, 120, 26, 97, 3, 23, 93, 10, 117, 87, 187, 234, 201, 47, 26, 187, 64, 204, 230, 181, 177, 58, 132, 210, 60, 37, 201, 195, 174, 40, 92, 177, 91, 26, 176, 69, 179, 22, 78, 185, 111, 124, 200, 189, 202, 5, 121, 64, 206 }, new byte[] { 86, 232, 156, 198, 161, 192, 44, 238, 75, 48, 63, 206, 239, 147, 157, 198, 112, 126, 156, 236, 160, 230, 15, 2, 167, 222, 154, 238, 126, 64, 255, 177, 5, 115, 79, 105, 79, 168, 22, 18, 214, 198, 201, 1, 129, 35, 150, 125, 242, 145, 210, 135, 45, 107, 211, 180, 50, 240, 130, 200, 171, 117, 32, 47, 230, 130, 7, 35, 251, 106, 99, 137, 172, 190, 91, 153, 233, 160, 198, 189, 228, 8, 214, 151, 85, 118, 65, 34, 42, 49, 152, 234, 43, 116, 47, 161, 22, 216, 23, 186, 224, 81, 182, 158, 116, 231, 31, 248, 219, 211, 146, 252, 155, 223, 237, 134, 222, 219, 75, 153, 22, 200, 245, 94, 172, 194, 186, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(950), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(952), new byte[] { 203, 163, 196, 30, 243, 201, 175, 144, 231, 98, 113, 100, 90, 248, 242, 47, 192, 8, 62, 79, 146, 250, 3, 99, 89, 100, 99, 98, 151, 180, 170, 76, 47, 137, 131, 4, 55, 217, 149, 216, 95, 58, 99, 38, 87, 19, 80, 37, 249, 99, 217, 99, 68, 139, 151, 243, 172, 74, 34, 122, 120, 163, 107, 72 }, new byte[] { 119, 45, 154, 99, 155, 233, 185, 60, 61, 162, 229, 41, 181, 200, 187, 136, 51, 188, 88, 4, 110, 212, 71, 52, 135, 9, 28, 13, 248, 201, 12, 85, 110, 4, 181, 117, 54, 169, 116, 232, 218, 116, 11, 97, 151, 249, 34, 128, 177, 209, 1, 178, 128, 88, 149, 198, 80, 111, 176, 178, 138, 92, 111, 94, 108, 230, 60, 160, 211, 250, 75, 110, 12, 84, 221, 151, 127, 44, 127, 125, 221, 47, 150, 125, 136, 31, 11, 91, 67, 219, 158, 231, 88, 24, 36, 38, 111, 221, 76, 96, 218, 206, 247, 152, 137, 205, 142, 219, 236, 129, 228, 116, 48, 33, 248, 58, 54, 127, 23, 5, 102, 92, 178, 62, 184, 103, 181, 54 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(988), new DateTime(2022, 12, 4, 20, 30, 7, 585, DateTimeKind.Local).AddTicks(991), new byte[] { 197, 227, 150, 82, 24, 95, 46, 241, 203, 224, 133, 166, 150, 170, 5, 34, 102, 133, 40, 178, 129, 89, 3, 220, 240, 53, 176, 183, 80, 155, 191, 152, 31, 106, 126, 225, 143, 15, 204, 151, 40, 46, 245, 146, 196, 13, 179, 105, 98, 64, 162, 113, 0, 221, 168, 157, 53, 80, 111, 145, 123, 48, 90, 222 }, new byte[] { 41, 178, 246, 19, 94, 92, 232, 107, 119, 103, 217, 192, 130, 59, 34, 142, 142, 23, 44, 117, 14, 146, 233, 92, 214, 206, 2, 51, 179, 34, 73, 167, 99, 188, 216, 121, 107, 119, 244, 39, 21, 194, 133, 76, 42, 248, 0, 222, 125, 7, 185, 181, 60, 76, 147, 67, 84, 227, 21, 20, 121, 104, 142, 106, 102, 193, 97, 183, 25, 23, 150, 60, 49, 20, 0, 195, 32, 160, 38, 2, 54, 229, 175, 107, 58, 194, 229, 31, 50, 224, 136, 221, 25, 161, 221, 199, 130, 76, 127, 20, 77, 22, 201, 92, 200, 154, 181, 92, 43, 100, 188, 69, 42, 177, 79, 142, 84, 243, 97, 29, 218, 206, 16, 54, 52, 92, 123, 157 } });
        }
    }
}