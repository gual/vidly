namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameGenderToGenre1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Gender_Id", newName: "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_Gender_Id", newName: "IX_Genre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_Gender_Id");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "Gender_Id");
        }
    }
}
