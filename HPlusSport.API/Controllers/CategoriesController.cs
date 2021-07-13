using HPlusSport.API.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace HPlusSport.API.Controllers
{
    public class CategoriesController : JsonApiController<Category>
    {
        private readonly IResourceService<Category> ResourceService;

        public CategoriesController(IJsonApiOptions options, ILoggerFactory loggerFactory,
        IResourceService<Category> resourceService)
        : base(options, loggerFactory, resourceService)
        {
            this.ResourceService = resourceService;
        }
    }
}