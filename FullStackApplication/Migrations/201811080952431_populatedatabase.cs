namespace FullStackApplication.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populatedatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'JAZZ')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'BLUES')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'ROCK')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,'COUNTRY')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Genres where ID IN(1,2,3,4)");
        }
    }
}
