using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Each list element refers to different instance");

            var moviereviews = new List<Movie>();

            var moviereview1 = new Movie()
            {
                Title = "The Avengers",
                Rating = 8.8m,
                GatheringOfTickets = 643.01M,
                NamesOfActors = "Robert Downey Jr., Chris Hemsworth, Mark Ruffalo, Chris Evans",
                Reviews = "incredibly thrilling and satisfyingly unconventional",
            };

            moviereviews.Add(moviereview1);


            PrintListElements(moviereviews);






            var moviereview2 = new Movie()
            {
                Title = "Ghost Stories",
                Rating = 6.8m,
                GatheringOfTickets = 0.14M,
                NamesOfActors = "Andy Nyman, Martin Freeman, Paul Whitehouse, Alex Lawther",
                Reviews = "Confidently carves a unique path to the top of a tried and tested genre.",
            };

            moviereviews.Add(moviereview2);


            PrintListElements(moviereviews);







            var moviereview3 = new Movie()
            {
                Title = "Unsane",
                Rating = 6.6m,
                GatheringOfTickets = 7.73m,
                NamesOfActors = "Claire Foy, Joshua Leonard, Jay Pharoah, Juno Temple",
                Reviews = "A gripping thriller that expertly puts you in the shoes of its protagonist.",
            };

            moviereviews.Add(moviereview3);


            PrintListElements(moviereviews);





            var moviereview4 = new Movie()
            {
                Title = "Three BillBoards Outside Ebbing, Missouri",
                Rating = 8.2m,
                GatheringOfTickets = 54.51M,
                NamesOfActors = "Frances McDormand, Woody Harrelson, Sam Rockwell, Caleb Landry Jones",
                Reviews = "truly phenomenal",
            };

            moviereviews.Add(moviereview4);


            PrintListElements(moviereviews);





            var moviereview5 = new Movie()
            {
                Title = "Lady Bird",
                Rating = 7.5m,
                GatheringOfTickets = 48.96M,
                NamesOfActors = "Saoirse Ronan, Laurie Metcalf, Tracy Letts, Lucas Hedges",
                Reviews = "One of the best in its genre; a wonderful, uplifting experience.",
            };

            moviereviews.Add(moviereview5);


            PrintListElements(moviereviews);







            var moviereview6 = new Movie()
            {
                Title = "You Were Never Really Here",
                Rating = 6.9m,
                GatheringOfTickets = 2.51M,
                NamesOfActors = "Joaquin Phoenix, Judith Roberts, Ekaterina Samsonov, John Doman",
                Reviews = "Dark, intense and immensely gripping; as discreet as it is devastating.",
            };

            moviereviews.Add(moviereview6);


            PrintListElements(moviereviews);




            var moviereview7 = new Movie()
            {
                Title = "A Quiet Place",
                Rating = 7.9m,
                GatheringOfTickets = 183.52M,
                NamesOfActors = "Emily Blunt, John Krasinski, Millicent Simmonds, Noah Jupe",
                Reviews = "Its mission statement is suspense and it achieves that in spades.",
            };

            moviereviews.Add(moviereview7);


            PrintListElements(moviereviews);





            var moviereview8 = new Movie()
            {
                Title = "Love, Simon",
                Rating = 8.0m,
                GatheringOfTickets = 40.82M,
                NamesOfActors = " Nick Robinson, Jennifer Garner, Josh Duhamel, Katherine Langford",
                Reviews = "Has something to say and says it well; entertaining for all.",
            };

            moviereviews.Add(moviereview8);


            PrintListElements(moviereviews);





            var moviereview9 = new Movie()
            {
                Title = "Thoroughbreds",
                Rating = 7.0m,
                GatheringOfTickets = 2.83M,
                NamesOfActors = "Olivia Cooke, Anya Taylor-Joy, Anton Yelchin, Kaili Vernoff",
                Reviews = "A thematically rich and unflinchingly honest character study.",
            };

            moviereviews.Add(moviereview9);


            PrintListElements(moviereviews);




            var moviereview10 = new Movie()
            {
                Title = "Early Man",
                Rating = 6.2m,
                GatheringOfTickets = 8.27M,
                NamesOfActors = "Eddie Redmayne, Tom Hiddleston, Maisie Williams, Timothy Spall",
                Reviews = "Its a consistently clever and chuckle-worthy affair.",
            };

            moviereviews.Add(moviereview10);


            PrintListElements(moviereviews);



        }





        static void PrintListElements(List<Movie> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Rating);
                Console.WriteLine(item.GatheringOfTickets);
                Console.WriteLine(item.NamesOfActors);
                Console.WriteLine(item.Reviews);

                Console.WriteLine();
            }
        }

        public class Movie
        {
            public string Title { get; set; }

            public decimal Rating { get; set; }

            public decimal GatheringOfTickets { get; set; }

            public string NamesOfActors { get; set; }

            public string Reviews { get; set; }
        }

    }
}
