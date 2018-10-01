namespace GameShopNew.Migrations
{
    using GameShopNew.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameShopNew.Models.GameShopNewContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(GameShopNew.Models.GameShopNewContext context)
        {
            var items = new List<Item>
            {
                new Item()
                {
                    Name = "Small Health",
                    Cost = 50,
                    Category = ItemCategory.Health,
                    IconURL = "~/Content/Images/health_icon.png"
                },
                new Item()
                {
                    Name = "Small Stamina",
                    Cost = 50,
                    Category = ItemCategory.Stamina,
                    IconURL = "~/Content/Images/stamina_icon.png"
                },
                new Item()
                {
                    Name = "Small Magic",
                    Cost = 50,
                    Category = ItemCategory.Magic,
                    IconURL = "~/Content/Images/magic_icon.png"
                }
            };

            foreach (var item in items)
            {
                context.Items.AddOrUpdate(x => x.Id, item);
            }
        }
    }
}
