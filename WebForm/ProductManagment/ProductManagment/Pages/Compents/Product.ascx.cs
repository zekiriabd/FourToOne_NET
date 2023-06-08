using DevExpress.Utils.About;
using ProductManagment.Models;
using System;

namespace ProductManagment.Pages.Compents
{
    public partial class Product : System.Web.UI.UserControl
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Comment { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int Like { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LikeCount"] == null)
            {
                Session["LikeCount"] = Like;
            }
        }
        protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            Like = (int)Session["LikeCount"] + 1;
            lbLike.Text = Like.ToString();
            Session["LikeCount"] = Like;
        }
    }
}