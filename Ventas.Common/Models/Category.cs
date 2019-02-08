namespace Ventas.Common.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        [JsonIgnore] //Excluye del Json para la serializacion
        public virtual ICollection<Product> Products { get; set; } //Esta es la propiedad que relaciona con Product

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath))
                {
                    return "noProduct";
                }

                return $"http://www.prowebcol.com/sites/backendventas{this.ImagePath.Substring(1)}";
            }
        }
    }

}
