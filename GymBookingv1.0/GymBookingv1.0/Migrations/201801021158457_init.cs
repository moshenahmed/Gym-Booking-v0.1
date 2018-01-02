namespace GymBookingv1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ApplicationUserGymClasses", name: "GymClass_Id", newName: "GymClasses_Id");
            RenameIndex(table: "dbo.ApplicationUserGymClasses", name: "IX_GymClass_Id", newName: "IX_GymClasses_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ApplicationUserGymClasses", name: "IX_GymClasses_Id", newName: "IX_GymClass_Id");
            RenameColumn(table: "dbo.ApplicationUserGymClasses", name: "GymClasses_Id", newName: "GymClass_Id");
        }
    }
}
