namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name = 'Pay as you go' Where Id = 1");
            Sql("UPDATE MembershipTypes set Name = 'Monthly' Where Id = 2");
            Sql("UPDATE MembershipTypes set Name = '3 months' Where Id = 3");
            Sql("UPDATE MembershipTypes set Name = 'Yearly' Where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
