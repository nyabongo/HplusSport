using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace HPlusSport.API.Models
{
    public class Category : Identifiable
    {
        public override int Id { get; set; }
        [Attr]
        public string Name { get; set; }
        [HasMany]
        public virtual List<Product> Products { get; set; }
    }
}
