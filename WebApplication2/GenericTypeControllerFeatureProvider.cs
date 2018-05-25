using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Reflection;
using System;
using Common;

namespace WebApplication2
{
    public class GenericTypeControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
    {
        public object AppDomain { get; private set; }

        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            var asse = Assembly.GetExecutingAssembly().GetReferencedAssemblies().Where(x => x.Name.Contains("Common")).First();

            var currentAssembly = Assembly.Load(asse);
            var candidates = currentAssembly.GetExportedTypes().Where(x => x.GetCustomAttributes<GeneratedControllerAttribute>().Any());

            foreach (var candidate in candidates)
            {
                feature.Controllers.Add(
                    typeof(BaseController<>).MakeGenericType(candidate).GetTypeInfo()
                );
            }
        }
    }
}

  
