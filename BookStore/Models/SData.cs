//using BookStore.Data;
//using Microsoft.EntityFrameworkCore;


//namespace BookStore.Models
//{
//    public class SData
//    {
//        public static void Initialize(IServiceProvider serviceProvider)
//        {
//            using (var context = new BookStoreContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreContext>>()))
//            {
//                if (context.Books.Any())
//                {
//                    return;
//                }
//                    context.Books.AddRange(
//                        new Book
//                        {
//                            Title = "Harrypotter",
//                            Language = "en",
//                            ISBN = "15456445354",
//                            DatePublished = DateTime.Parse("2023-9-14"),
//                            Price = 100,
//                            Author = "Asric",
//                            ImageUrl = ""
//                        },

//                         new Book
//                         {
//                             Title = "Harrypotter2",
//                             Language = "en",
//                             ISBN = "15456445455",
//                             DatePublished = DateTime.Parse("2023-10-14"),
//                             Price = 100,
//                             Author = "Asric",
//                             ImageUrl = ""
//                         },

//                          new Book
//                          {
//                              Title = "Harrypotter4",
//                              Language = "en",
//                              ISBN = "15456445456",
//                              DatePublished = DateTime.Parse("2023-11-14"),
//                              Price = 100,
//                              Author = "Asric",
//                              ImageUrl = ""
//                          },

//                           new Book
//                           {
//                               Title = "Harrypotter3",
//                               Language = "en",
//                               ISBN = "15456445457",
//                               DatePublished = DateTime.Parse("2023-12-14"),
//                               Price = 100,
//                               Author = "Asric",
//                               ImageUrl = ""
//                           }
//                        );
//                    context.SaveChanges();
//                }
//            }
//        }
//    }

