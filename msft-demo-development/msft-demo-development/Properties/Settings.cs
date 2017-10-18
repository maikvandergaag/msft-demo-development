using Core;
using System.Configuration;
using System.Linq;

namespace Development.Properties {
    public partial class Settings : IValidatable {
        public bool IsValid() {
            return IsValid(false);
        }

        public void Validate() {
            IsValid(true);
        }

        private bool IsValid(bool throwException) {
            bool retVal = true;

            //Plugin configuration
            if (this.Plugins == null || this.Plugins.Count == 0) {
                string message = "Configuration - The 'Plugins' setting is not configured correctly, minimum plugin count is 1";
                retVal = false;
                Log.Error(message);

                if (throwException)
                    new ConfigurationErrorsException(message);
            }

            return retVal;
        }
    }
}
