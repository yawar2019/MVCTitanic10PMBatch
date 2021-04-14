namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;


    //Enable-Migrations
    //add-migration UpdatedDesignation
    //update-database
    public partial class UpdatedDesignation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "Designation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeModels", "Designation");
        }
    }
}
