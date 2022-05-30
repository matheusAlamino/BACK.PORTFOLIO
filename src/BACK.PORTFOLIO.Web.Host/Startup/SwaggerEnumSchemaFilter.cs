using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BACK.PORTFOLIO.Web.Host.Startup
{
    public class SwaggerEnumSchemaFilter : ISchemaFilter
    {
        public void Apply(Schema schema, SchemaFilterContext context)
        {
            if (schema.Enum == null)
                return;

            schema.Description = SwaggerEnumDocumentFilter.DescribeEnum(schema.Enum);
        }
    }
}
