using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Castle.DynamicProxy.Internal;
using Microsoft.AspNetCore.Mvc;
using NUglify.Helpers;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BACK.PORTFOLIO.Web.Host.Startup
{
    public class SwaggerEnumDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            if (swaggerDoc.Paths.Count <= 0)
                return;

            swaggerDoc
                .Paths
                .Values
                .ForEach(pathItem =>
                {
                    DescribeEnumParameters(pathItem.Parameters);

                    new List<Operation> { pathItem.Get, pathItem.Post, pathItem.Put }
                        .FindAll(c => c != null)
                        .ForEach(c => DescribeEnumParameters(c.Parameters));
                });
        }

        private static void DescribeEnumParameters(IEnumerable<IParameter> parameters)
        {
            parameters?
                .ForEach(p =>
                {
                    if (p is NonBodyParameter eNbParam && eNbParam.Enum?.Any() == true)
                        p.Description += DescribeEnum(eNbParam.Enum);
                    else if (p.Extensions.ContainsKey("enum") && p.Extensions["enum"] is IList<object> eParam && eParam.Count > 0)
                        p.Description += DescribeEnum(eParam);
                });
        }

        public static string DescribeEnum(IList<object> enums)
        {
            if (enums == null || !enums.Any())
                return string.Empty;

            var enumType = enums.First().GetType();
            if (enumType.IsNullableType())
                enumType = Nullable.GetUnderlyingType(enumType);

            var enumUnderlyingType = Enum.GetUnderlyingType(enumType);

            var values = enumType
                .GetFields(BindingFlags.Static | BindingFlags.Public)
                .Select(c =>
                {
                    var value = c.GetValue(enumType);

                    return $"{Convert.ChangeType(value, enumUnderlyingType)} - {value}";
                });

            return string.Join(Environment.NewLine, values);
        }
    }
}
