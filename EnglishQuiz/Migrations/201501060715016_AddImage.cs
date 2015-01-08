namespace EnglishQuiz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("Questions", "Image", c => c.String());
            DropColumn("Questions", "FirstIsCorrect");
        }
        
        public override void Down()
        {
        }
    }
}
