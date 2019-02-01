namespace Ventas.Backend.Models
{
    using System.Web;
    using Ventas.Common.Models;

    public class ProductView : Product
    {
        public HttpPostedFileBase ImageFile { get; set; }


    }
}