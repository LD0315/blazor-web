using blazor_web.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blazor_web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
        new Product
        {
            Id = 1,
            Title = "Winnie-the-Pooh",
            Description = "Winnie-the-Pooh, also called Pooh Bear and Pooh, is a fictional anthropomorphic teddy bear created by English author A. A. Milne and English illustrator E. H. Shepard.The first collection of stories about the character was the book Winnie-the-Pooh (1926), and this was followed by The House at Pooh Corner (1928). Milne also included a poem about the bear in the children's verse book When We Were Very Young (1924) and many more in Now We Are Six (1927). All four volumes were illustrated by E. H. Shepard.",
            ImageUrl = "https://static.tvtropes.org/pmwiki/pub/images/pooh_bridge.png",
            Price = 9.99m
        },
         new Product
        {
            Id = 2,
            Title = "Moomins",
            Description = "The Moomins (Swedish: Mumintroll) are the central characters in a series of novels, short stories, and a comic strip by Finnish writer and illustrator Tove Jansson, originally published in Swedish by Schildts[2] in Finland. They are a family of white, round fairy-tale characters with large snouts that make them resemble the hippopotamus. However, despite this resemblance, the Moomin family are trolls. The family live in their house in Moominvalley and have had many adventures with their various friends.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYmZhYWI0OTItMjkzNS00ODM2LWEwZTktNTc0ODMzMTYwMTBlXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg",
            Price = 7.99m
        },
          new Product
        {
            Id = 3,
            Title = "Heidi",
            Description = "Heidi (/ˈhaɪdi/; German: [ˈhaɪdi]) is a work of children's fiction published in 1881 by Swiss author Johanna Spyri, originally published in two parts as Heidi: Her Years of Wandering and Learning[1] (German: Heidis Lehr- und Wanderjahre) and Heidi: How She Used What She Learned[2] (German: Heidi kann brauchen, was es gelernt hat).[3] It is a novel about the events in the life of a 5-year-old girl in her paternal grandfather's care in the Swiss Alps. It was written as a book for children and those who love children (as quoted from its subtitle).",
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBIQTRvceBokJ_GeZb7Dgkojzg1q27S17F0aHYeJImK3Gw2FeggPU51IEGSWOz0ZQc-hY&usqp=CAU",
            Price = 6.99m
        },
     };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
