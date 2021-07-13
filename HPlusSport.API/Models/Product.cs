using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace HPlusSport.API.Models
{
    public class Product: Identifiable
    {
        public override int Id { get; set; }
        [Attr]
        public string Sku { get; set; }
        [Attr]
        public string Name { get; set; }
        [Attr]
        public string Description { get; set; }
        [Attr]
        public decimal Price { get; set; }
        [Attr]
        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore,HasOne]
        public virtual Category Category { get; set; }
    }
}
