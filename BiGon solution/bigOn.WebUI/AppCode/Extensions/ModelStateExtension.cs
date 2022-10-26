using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;


namespace bigOn.WebUI.AppCode.Extensions
{
    public static partial class Extension
    {
        public static List<VaildationError> GetErrors(this ModelStateDictionary modelState)
        {
            var errors = (from key in modelState.Keys
                         where modelState[key] != null && modelState[key].Errors.Count>0
                          select new VaildationError(key, modelState[key].Errors[0].ErrorMessage)
                         ).ToList();
            return errors;
        }
    }

    public class VaildationError
    {
        public string FieldName { get; set; }
        public string Message { get; set; }
        public VaildationError(string fieldName, string message)
        {
           this.FieldName = fieldName;
            this.Message = message;  
        }
    }
}
