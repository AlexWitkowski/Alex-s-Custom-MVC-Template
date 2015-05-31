namespace MVCTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Template",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Temp = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Template");
        }
    }
}
