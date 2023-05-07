using ProductManagment.Models;
using System;

namespace ProductManagment.Pages.Compents
{
    public partial class Product : System.Web.UI.UserControl
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Comment { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //ProductItem = new ProductModel
            //{
            //    Id = 1,
            //    Name = "Nike Air Max ",
            //    Image = "https://cdn11.bigcommerce.com/s-ktikayh2p6/images/stencil/original/products/475/20955/baskets-de-jogging-a-coussin-dair__55328.1665613384.jpg?c=1",
            //    Comment = @"Confort rembourré
            //            La semelle intermédiaire en mousse et l'unité Max Air au talon amortissent votre pied pour
            //            un confort durable. Le col en mousse protège votre cheville à chacun de vos mouvements.",
            //    Price = 109.99M,
            //    Discount = 50,
            //};
        }
    }
}