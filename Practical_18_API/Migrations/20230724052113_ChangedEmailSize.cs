using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practical_18_API.Migrations
{
	/// <inheritdoc />
	public partial class ChangedEmailSize : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
				name: "Email",
				table: "students",
				type: "nvarchar(256)",
				maxLength: 256,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
				name: "Email",
				table: "students",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(256)",
				oldMaxLength: 256);
		}
	}
}
