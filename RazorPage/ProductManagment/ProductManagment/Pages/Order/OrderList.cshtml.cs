using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagment.Models;

namespace ProductManagment.Pages.Order
{
    public class OrderListModel : PageModel
    {
        public List<ProductModel> SelectedProducts { get; set; }
        public void OnGet()
        {
            string[] selectionIds = HttpContext.Session.GetString("ids").Split(',');
            SelectedProducts = AllProducts().Where(x => selectionIds.Contains(x.Id.ToString())).ToList();
        }

        private List<ProductModel> AllProducts()
        {
            return new List<ProductModel>() {
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
