using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagment.Models;
using System.Xml.Linq;

namespace ProductManagment.Pages.Product
{
    public class ProductListModel : PageModel
    {
        public ProductModel ProductItem { get; set; }
        public List<ProductModel> Products { get; set; }

        public void OnPostSubmit(int id)
        {
            var like = int.Parse(HttpContext.Session.GetString("like")) + 1 ;
            HttpContext.Session.SetString("like",like.ToString());
            OnGet();
            Products.First(x => x.Id == id).LikeCount = like;
        }
       
        [HttpPost]
        public void OnPostAdd(int id)
        {
           HttpContext.Session.SetString("ids", HttpContext.Session.GetString("ids") + "," +  id.ToString());
            OnGet();
        }

        public void OnGet()
        {
            if(HttpContext.Session.GetString("like")== null)
            HttpContext.Session.SetString("like", "0");
            Products = new List<ProductModel>() {
                new ProductModel
                {
                Id = 1,
                Name = "Nike Air Max ",
                Image = "https://cdn11.bigcommerce.com/s-ktikayh2p6/images/stencil/original/products/475/20955/baskets-de-jogging-a-coussin-dair__55328.1665613384.jpg?c=1",
                Comment = @"Confort rembourré
                        La semelle intermédiaire en mousse et l'unité Max Air au talon amortissent votre pied pour
                        un confort durable. Le col en mousse protège votre cheville à chacun de vos mouvements.",
                Price = 109.99M,
                Discount = 50,
                },
                 new ProductModel
                {
                Id = 2,
                Name = "Nike Air Max 2",
                Image = "https://cdn11.bigcommerce.com/s-ktikayh2p6/images/stencil/original/products/475/20955/baskets-de-jogging-a-coussin-dair__55328.1665613384.jpg?c=1",
                Comment = @"Confort rembourré
                        La semelle intermédiaire en mousse et l'unité Max Air au talon amortissent votre pied pour
                        un confort durable. Le col en mousse protège votre cheville à chacun de vos mouvements.",
                Price = 109.99M,
                Discount = 50,
                },
                  new ProductModel
                {
                Id = 3,
                Name = "Nike Air Max 3",
                Image = "https://cdn11.bigcommerce.com/s-ktikayh2p6/images/stencil/original/products/475/20955/baskets-de-jogging-a-coussin-dair__55328.1665613384.jpg?c=1",
                Comment = @"Confort rembourré
                        La semelle intermédiaire en mousse et l'unité Max Air au talon amortissent votre pied pour
                        un confort durable. Le col en mousse protège votre cheville à chacun de vos mouvements.",
                Price = 109.99M,
                Discount = 50,
                },
            };
        }
    }
}
