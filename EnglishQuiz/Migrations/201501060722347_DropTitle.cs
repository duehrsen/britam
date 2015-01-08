namespace EnglishQuiz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropTitle : DbMigration
    {
        public override void Up()
        {
            DropColumn("Questions", "Title");

        }
        
        public override void Down()
        {
        }
    }
}
