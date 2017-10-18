using Core;
using Development.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Reflection;

namespace Development {
    public class MefConfiguration {

        [Import(typeof(IOrderRepository))]
        public IOrderRepository OrderRepository;

        [ImportMany(typeof(IValidatable))]
        public IEnumerable<IValidatable> SettingsObjects;


        public void Initialize() {
            Log.Verbose("Initializing the MEF Configuration");

            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            foreach (string plugin in Settings.Default.Plugins) {
                catalog.Catalogs.Add(new AssemblyCatalog(Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + plugin)));
            }
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            Log.Verbose("Initialization of the MEF Configuration is ready");
        }


        public void ValidateSettings() {
            foreach (var setting in SettingsObjects) {
                bool valid = setting.IsValid();
                if (!valid) {
                    string message = "Configuration of the application isn't valid.";
                    Log.Error(message);
                    throw new ConfigurationErrorsException(message);
                }
            }
        }
    }
}
