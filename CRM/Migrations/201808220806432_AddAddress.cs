namespace CRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Town = c.String(nullable: false, maxLength: 255),
                        PostCode = c.String(nullable: false, maxLength: 15),
                        StreetName = c.String(nullable: false, maxLength: 255),
                        StreetNumber = c.String(nullable: false, maxLength: 255),
                        Description = c.String(maxLength: 255),
                        CorrespondenceTown = c.String(),
                        CorrespondencePostCode = c.String(),
                        CorrespondenceStreetName = c.String(),
                        CorrespondenceStreetNumber = c.String(),
                        CorrespondenceDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Customers", "AddressId");
            AddForeignKey("dbo.Customers", "AddressId", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "AddressId" });
            DropTable("dbo.Addresses");
        }
    }
}
