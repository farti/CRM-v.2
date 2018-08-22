namespace CRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenderType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (Id, GenderType) VALUES (1, 'Mr.')");
            Sql("INSERT INTO Genders (Id, GenderType) VALUES (2, 'Mrs.')");
            Sql("INSERT INTO Genders (Id, GenderType) VALUES (3, 'Miss')");
            Sql("INSERT INTO Genders (Id, GenderType) VALUES (4, 'Ms.')");
        }
        
        public override void Down()
        {
        }
    }
}
