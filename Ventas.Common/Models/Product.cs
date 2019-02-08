namespace Ventas.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public int? CategoryId { get; set; } //Luego de crear las categorias y asignarselas a los productos se debe actualizar esta propieda porque no puede permitir nulls

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public Decimal Price { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Publish On")]
        [DataType(DataType.Date)]
        public DateTime PublishOn { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; } //Es un Guid, esta definido en la tabla de users, es alfanumerico de 128

        [JsonIgnore] //Excluye del Json para la serializacion
        public virtual Category Category { get; set; } //Con virtual  no se mapea en la BD, esta es la llave foranea

        [NotMapped]
        public byte[] ImageArray { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImagePath))
                {
                    return "noProduct";
                }

                return $"http://www.prowebcol.com/sites/apiventas/{this.ImagePath.Substring(1)}";
            }
        }

        public override string ToString()
        {
            return this.Description;
        }

    }
}
