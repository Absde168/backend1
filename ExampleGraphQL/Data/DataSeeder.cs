using ExampleGraphQL.Models;
using Faker;

namespace ExampleGraphQL.Data
{
    public static class DataSeeder
    {
        public static void SeedData(BlogDbContext db)
        {
            //if (db.Clients.Count()==0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    var client = new Client
                    {
                        Name = Name.FullName(),
                        ContactInformation = Internet.Email(),
                        Address = Address.StreetAddress(),
                        PhoneNumber = Phone.Number()
                    };

                    db.Clients.Add(client);

                    for (int j = 0; j < 5; j++)
                    {
                        var order = new Order
                        {
                            Client = client,
                            StartDate = DateTime.Now.AddDays(-Faker.RandomNumber.Next(1, 30)),
                            EndDate = DateTime.Now.AddDays(Faker.RandomNumber.Next(30, 60)),
                            TotalCost = Faker.RandomNumber.Next(5000, 100000),
                            IsPaid = Faker.RandomNumber.Next(0, 2) == 1,
                            Description = Lorem.Sentence(),  
                            DatePerformed = DateTime.Now.AddDays(Faker.RandomNumber.Next(1, 60)),
                            WorkCompleted = Faker.RandomNumber.Next(0, 2) == 1 
                        };

                        db.Orders.Add(order);

                        for (int k = 0; k < 3; k++)
                        {
                            var work = new Work
                            {
                                Order = order,
                                Description = Lorem.Sentence(),
                                Cost = Faker.RandomNumber.Next(1000, 10000),
                                DatePerformed = DateTime.Now.AddDays(Faker.RandomNumber.Next(1, 60)),
                                WorkCompleted = Faker.RandomNumber.Next(0, 2) == 1
                            };

                            db.Works.Add(work);
                        }
                    }
                }
                //db.SaveChanges();
            }

            //if (!db.Teams.Any())
            {
                for (int i = 1; i <= 5; i++)
                {
                    var team = new Team
                    {
                        Name = $"Team {i}",
                        Description = Lorem.Sentence(),
                        FullName = Name.FullName(),
                        PhoneNumber = Phone.Number()
                    };

                    db.Teams.Add(team);

                    for (int j = 0; j < 4; j++)
                    {
                        var member = new Member
                        {
                            Team = team,
                            FullName = Name.FullName(),
                            PhoneNumber = Phone.Number(),

                            DatePerformed = DateTime.Now.AddDays(Faker.RandomNumber.Next(1, 60)),
                            WorkCompleted = Faker.RandomNumber.Next(0, 2) == 1
                        };

                        db.Members.Add(member);
                    }

                    for (int k = 0; k < 3; k++)
                    {
                        var completedWork = new Work
                        {
                            Team = team,
                            Description = Lorem.Sentence(),
                            Cost = Faker.RandomNumber.Next(1000, 10000),
                            DatePerformed = DateTime.Now.AddDays(Faker.RandomNumber.Next(1, 60)),
                            WorkCompleted = true 
                        };

                        db.Works.Add(completedWork);
                    }
                }
                //db.SaveChanges();
            }
        }
    }
}
