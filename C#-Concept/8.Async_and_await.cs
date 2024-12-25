using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Booking
    {
        public int bookingid { get; set; }
        
    }
    public class User
    {
        public int id { get; set; }
    }

    public class Program
    {
        private static readonly HttpClient client = new HttpClient();

        private static async Task GetBookIds()
        {
            try
            {
                
                List<Booking> bookings = await client.GetFromJsonAsync<List<Booking>>("https://restful-booker.herokuapp.com/booking");

                foreach (Booking booking in bookings)
                {
                    Console.WriteLine($"Book ID: {booking.bookingid}");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static async Task GetUserIds()
        {
            try
            {
                List<User> user = await client.GetFromJsonAsync<List<User>>("https://gorest.co.in/public/v2/users");
                foreach (User userid in user)
                {
                    Console.WriteLine($"User ID {userid.id}");                        
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static async Task Main(string[] args)
        {
            Task task1= GetBookIds();
            Task task2 =GetUserIds();

            await Task.
                WhenAll(task1, task2);

             //when all is user to perform both task at a time. but if we want to call bookid first and
             //userid then for this we use await GetBookId() and same for userid
        }
    }
}
