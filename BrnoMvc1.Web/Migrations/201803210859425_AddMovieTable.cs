namespace BrnoMvc1.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movie");
        }
    }
}
