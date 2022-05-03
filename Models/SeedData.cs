using CryptoDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace CryptoDemo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CryptoDemoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CryptoDemoContext>>()))
            {
                if (context == null || context.Coin == null)
                {
                    throw new ArgumentNullException("Null CryptoDemoContext");
                }


                if (context.Coin.Any())
                {
                    return;
                }

                context.Coin.AddRange(
                    new Coin
                    {
                        Name = "Bitcoin",
                        Price = 42920
                    },

                    new Coin
                    {
                        Name = "Litecoin",
                        Price = 570
                    },

                    new Coin
                    {
                        Name = "Dogecoin",
                        Price = 23
                    },

                    new Coin
                    {
                        Name = "BNB",
                        Price = 450
                    }
                );
                context.SaveChanges();
            }
        }


    }
}
