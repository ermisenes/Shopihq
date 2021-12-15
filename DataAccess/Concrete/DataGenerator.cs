using System;
using System.Linq;
using DataAccess.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Concrete
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OrderContext())

            {
                if (context.Orders.Any())
                {
                    return;   // Data was already seeded
                }

                context.Orders.AddRange(
                    new Order
                    {
                        Id = 1,
                        BrandId = 200,
                        Price = 76,
                        StoreName = "Aliquam Industries",
                        CustomerName = "Berk Stevenson",
                        CreatedOn = new DateTime(2021, 05, 22),
                        Status = Entities.OrderStatus.Created
                    },
                    new Order
                    {
                        Id = 2,
                        BrandId = 201,
                        Price = 16,
                        StoreName = "Orci Incorporated",
                        CustomerName = "Kellie Chen",
                        CreatedOn = new DateTime(2021, 12, 12),
                        Status = Entities.OrderStatus.Created
                    },
                    new Order
                    {
                        Id = 3,
                        BrandId = 202,
                        Price = 223,
                        StoreName = "Suspendisse Commodo Associates",
                        CustomerName = "Ishmael Booth",
                        CreatedOn = new DateTime(2021, 05, 13),
                        Status = Entities.OrderStatus.Created
                    },
                    new Order
                    {
                        Id = 4,
                        BrandId = 203,
                        Price = 490,
                        StoreName = "Adipiscing Lacus Ut Consulting",
                        CustomerName = "Vivien Alford",
                        CreatedOn = new DateTime(2021, 02, 15),
                        Status = Entities.OrderStatus.Created
                    },
                    new Order
                    {
                        Id = 5,
                        BrandId = 204,
                        Price = 267,
                        StoreName = "Ut Eros Foundation",
                        CustomerName = "Gary Kinney",
                        CreatedOn = new DateTime(2021, 02, 26),
                        Status = Entities.OrderStatus.Created
                    },
                    new Order
                    {
                        Id = 6,
                        BrandId = 205,
                        Price = 362,
                        StoreName = "Et Ipsum Incorporated",
                        CustomerName = "Velma Terry",
                        CreatedOn = new DateTime(2021, 03, 14),
                        Status = Entities.OrderStatus.Failed
                    },
                    new Order
                    {
                        Id = 7,
                        BrandId = 206,
                        Price = 324,
                        StoreName = "Sagittis Felis LLP",
                        CustomerName = "Yvette Sandoval",
                        CreatedOn = new DateTime(2021, 03, 18),
                        Status = Entities.OrderStatus.Failed
                    },
                    new Order
                    {
                        Id = 8,
                        BrandId = 207,
                        Price = 19,
                        StoreName = "Nullam Nisl Maecenas Incorporated",
                        CustomerName = "Connor Grant",
                        CreatedOn = new DateTime(2021, 11, 11),
                        Status = Entities.OrderStatus.Returned
                    },
                    new Order
                    {
                        Id = 9,
                        BrandId = 208,
                        Price = 178,
                        StoreName = "Non Bibendum Booth",
                        CustomerName = "Ronan Williamson",
                        CreatedOn = new DateTime(2021, 12, 12),
                        Status = Entities.OrderStatus.Completed
                    },
                    new Order
                    {
                        Id = 10,
                        BrandId = 209,
                        Price = 303,
                        StoreName = "Sed Diam Corp.",
                        CustomerName = "Lana Johnson",
                        CreatedOn = new DateTime(2021, 12, 19),
                        Status = Entities.OrderStatus.Completed
                    },
                    new Order
                    {
                        Id = 11,
                        BrandId = 210,
                        Price = 188,
                        StoreName = "Felis Purus LLP",
                        CustomerName = "Alice Patrick",
                        CreatedOn = new DateTime(2021, 09, 15),
                        Status = Entities.OrderStatus.Completed
                    },
                    new Order
                    {
                        Id = 12,
                        BrandId = 211,
                        Price = 332,
                        StoreName = "Lobortis Mauris Ltd",
                        CustomerName = "Brendan Gallegos",
                        CreatedOn = new DateTime(2021, 08, 18),
                        Status = Entities.OrderStatus.Completed
                    },
                    new Order
                    {
                        Id = 13,
                        BrandId = 212,
                        Price = 413,
                        StoreName = "Euismod Inc.",
                        CustomerName = "Sharon Vaughn",
                        CreatedOn = new DateTime(2021, 08, 13),
                        Status = Entities.OrderStatus.Completed
                    },
                    new Order
                    {
                        Id = 14,
                        BrandId = 213,
                        Price = 484,
                        StoreName = "Dolor Inc.",
                        CustomerName = "Omar Browning",
                        CreatedOn = new DateTime(2021, 01, 11),
                        Status = Entities.OrderStatus.InProgress
                    },
                    new Order
                    {
                        Id = 15,
                        BrandId = 214,
                        Price = 51,
                        StoreName = "Elementum Purus Accumsan Incorporated",
                        CustomerName = "Gay Bruce",
                        CreatedOn = new DateTime(2021, 02, 13),
                        Status = Entities.OrderStatus.InProgress
                    },
                    new Order
                    {
                        Id = 25,
                        BrandId = 215,
                        Price = 216,
                        StoreName = "Duis A Incorporated",
                        CustomerName = "Jameson Merritt",
                        CreatedOn = new DateTime(2021, 02, 12),
                        Status = Entities.OrderStatus.InProgress
                    },
                    new Order
                    {
                        Id = 16,
                        BrandId = 216,
                        Price = 114,
                        StoreName = "Malesuada Vel Corp.",
                        CustomerName = "Norman Ortiz",
                        CreatedOn = new DateTime(2021, 02, 11),
                        Status = Entities.OrderStatus.InProgress
                    },
                    new Order
                    {
                        Id = 17,
                        BrandId = 217,
                        Price = 341,
                        StoreName = "Ipsum LLP",
                        CustomerName = "Ali Stokes",
                        CreatedOn = new DateTime(2021, 01, 20),
                        Status = Entities.OrderStatus.InProgress
                    },
                    new Order
                    {
                        Id = 18,
                        BrandId = 218,
                        Price = 166,
                        StoreName = "Et Rutrum Non Associates",
                        CustomerName = "Noelle Rodriquez",
                        CreatedOn = new DateTime(2021, 01, 19),
                        Status = Entities.OrderStatus.InProgress
                    },
                    new Order
                    {
                        Id = 19,
                        BrandId = 219,
                        Price = 201,
                        StoreName = "Amet Massa Ipsum",
                        CustomerName = "Ciara Mcguire",
                        CreatedOn = new DateTime(2021, 01, 17),
                        Status = Entities.OrderStatus.Created
                    },
                    new Order
                    {
                        Id = 20,
                        BrandId = 220,
                        Price = 425,
                        StoreName = "Sed Associates",
                        CustomerName = "Hammett Benjamin",
                        CreatedOn = new DateTime(2021, 01, 16),
                        Status = Entities.OrderStatus.InProgress
                    },
                    new Order
                    {
                        Id = 21,
                        BrandId = 221,
                        Price = 67,
                        StoreName = "Lectus Rutrum Limited",
                        CustomerName = "Rhonda Lott",
                        CreatedOn = new DateTime(2021, 01, 15),
                        Status = Entities.OrderStatus.Returned
                    },
                    new Order
                    {
                        Id = 22,
                        BrandId = 222,
                        Price = 124,
                        StoreName = "Nisi LLP",
                        CustomerName = "Katelyn Chavez",
                        CreatedOn = new DateTime(2021, 01, 14),
                        Status = Entities.OrderStatus.Failed
                    },
                    new Order
                    {
                        Id = 23,
                        BrandId = 223,
                        Price = 47,
                        StoreName = "Donec Luctus Aliquet Corp.",
                        CustomerName = "Colleen Buckner",
                        CreatedOn = new DateTime(2021, 01, 13),
                        Status = Entities.OrderStatus.Failed
                    },
                    new Order
                    {
                        Id = 24,
                        BrandId = 224,
                        Price = 178,
                        StoreName = "Aenean Eget PC",
                        CustomerName = "Cameron Livingston",
                        CreatedOn = new DateTime(2021, 01, 12),
                        Status = Entities.OrderStatus.Failed
                    }
                    );

                context.SaveChanges();

            }
        }
    }
}
