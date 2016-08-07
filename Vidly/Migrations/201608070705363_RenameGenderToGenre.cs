namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameGenderToGenre : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Genders", newName: "Genres");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Genres", newName: "Genders");
        }
    }
}
