using Microsoft.EntityFrameworkCore;
using SpartaToDo.Models;

namespace SpartaToDo.Data
{
    public class SeedData
    {

        public static void Initialise(IServiceProvider serviceProvider)
        {
            using (var db = new SpartaToDoContext(serviceProvider.GetRequiredService<DbContextOptions<SpartaToDoContext>>()))
            {
                if(db.ToDos.Any())
                {
                    return; //Db already has data
                }

                db.ToDos.AddRange
                    (
                    new ToDo

                    {
                        Title = " Sleep",
                        Description = " Go to Bed early",
                        Complete = true,
                        Date= new DateTime(2022,10,20)

                    },
                    new ToDo
                    {
                        Title = "Teach C#",
                        Description = "Teach the class",
                        Complete = true

                    }
                );
                db.SaveChanges();    

            }
        }
    }
}
