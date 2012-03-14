using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTemplatedViewHelpers
{
    public class CustomModelMetadataProvider : DataAnnotationsModelMetadataProvider //1. AssociatedMetadataProvider
    {
        protected override ModelMetadata CreateMetadata(
            IEnumerable<Attribute> attributes, 
            Type containerType, 
            Func<object> modelAccessor, 
            Type modelType, 
            string propertyName)
        {
            //1. ModelMetadata metadata = new ModelMetadata(this, containerType, modelAccessor, modelType, propertyName);

            ModelMetadata metadata = base.CreateMetadata(attributes, containerType, modelAccessor, modelType, propertyName);
            
            if (propertyName != null && propertyName.EndsWith("Name"))
            {
                metadata.DisplayName = propertyName.Substring(0, propertyName.Length - 4);
            }
            return metadata;
        }
    }
}