namespace faskion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Admin_number = c.Int(nullable: false),
                        Admin_name = c.String(),
                        Admin_surName = c.String(),
                        Admin_age = c.Int(nullable: false),
                        Admin_phone = c.Int(nullable: false),
                        Admin_email = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Capsules",
                c => new
                    {
                        CapsuleId = c.Int(nullable: false, identity: true),
                        capsuleCategory = c.String(),
                        capsuleStill = c.String(),
                    })
                .PrimaryKey(t => t.CapsuleId);
            
            CreateTable(
                "dbo.Gifts",
                c => new
                    {
                        GiftId = c.Int(nullable: false, identity: true),
                        giftPrice = c.Single(nullable: false),
                        giftName = c.String(),
                        giftTitle = c.String(),
                    })
                .PrimaryKey(t => t.GiftId);
            
            CreateTable(
                "dbo.NewIns",
                c => new
                    {
                        NewInId = c.Int(nullable: false, identity: true),
                        fabric_type = c.String(),
                        color = c.String(),
                        NewIn_title = c.String(),
                    })
                .PrimaryKey(t => t.NewInId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewIns");
            DropTable("dbo.Gifts");
            DropTable("dbo.Capsules");
            DropTable("dbo.Admins");
        }
    }
}
