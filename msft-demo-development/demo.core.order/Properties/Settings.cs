using Core;
using System;
using System.Configuration;
using System.Linq;

namespace Core.Order.Properties {
    public partial class Settings : IValidatable {
        public bool IsValid() {
            return IsValid(false);
        }

        public void Validate() {
            IsValid(true);
        }

        private bool IsValid(bool throwException) {
            bool retVal = true;

            if (String.IsNullOrEmpty(this.ServiceUrl)) {
                retVal = false;

                string message = "Configuration of the service url isn't valid.";
                Log.Error(message);
            }
            
            return retVal;
        }
    }
}
