namespace mvc_game.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<mvc_game.Models.Data.PlayerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(mvc_game.Models.Data.PlayerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Players.AddOrUpdate(p => p.Name,
                new Models.Player
                {
                    Name = "Andrew Peters",
                    TotalGamePlayed = 432,
                    TotalScores = 2346,
                    Country = "Argentina",
                    GameType = "Hockey"
                },

                new Models.Player
                {
                    Name = "Brice Lambson",
                    TotalGamePlayed = 432,
                    TotalScores = 2346,
                    Country = "Canada",
                    GameType = "Rogby"
                },

                new Models.Player
                {
                    Name = "Rowan Miller",
                    TotalGamePlayed = 409,
                    TotalScores = 2435,
                    Country = "Swedin",
                    GameType = "Tennis"
                },

                new Models.Player
                {
                    Name = "Jack Bahour",
                    TotalGamePlayed = 456,
                    TotalScores = 2857,
                    Country = "Texas",
                    GameType = "Hockey"
                },

                new Models.Player
                {
                    Name = "Roja Miller",
                    TotalGamePlayed = 560,
                    TotalScores = 3578,
                    Country = "Argentina",
                    GameType = "Football"
                },

                new Models.Player
                {
                    Name = "Lineol Messi",
                    TotalGamePlayed = 690,
                    TotalScores = 4467,
                    Country = "Argentina",
                    GameType = "Football"
                },

                new Models.Player
                {
                    Name = "Muhammad Salah",
                    TotalGamePlayed = 600,
                    TotalScores = 3897,
                    Country = "Turkey",
                    GameType = "Football"
                },

                new Models.Player
                {
                    Name = "Vandezer",
                    TotalGamePlayed = 489,
                    TotalScores = 3,
                    Country = "Holland",
                    GameType = "Football"
                }

                );
        }
    }
}
