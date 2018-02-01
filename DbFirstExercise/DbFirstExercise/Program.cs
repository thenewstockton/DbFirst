using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstExercise
{
    public enum Classification : byte
    {
        Silver = 1,
        Gold = 2,
        Platinum
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var dbContext = new VidzyEntities();
            dbContext.AddVideo("TestTest2", new DateTime(2001, 11, 12), "Action1", Classification.Gold);
            foreach (var video in dbContext.Videos)
            {
                Console.WriteLine(video.Name);
            }
            Console.ReadKey();
        }
    }
}
