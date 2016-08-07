namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGender : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Gender_Id", c => c.Byte());
            CreateIndex("dbo.Movies", "Gender_Id");
            AddForeignKey("dbo.Movies", "Gender_Id", "dbo.Genders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Movies", new[] { "Gender_Id" });
            DropColumn("dbo.Movies", "Gender_Id");
            DropTable("dbo.Genders");
        }
    }
}
