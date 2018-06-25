using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EnterpriseManagement.API.Shared
{
    public class Constants
    {
        private static bool? _useLocalSettings { get; set; }
        public static bool UseLocalSettings {
            get {
                if(_useLocalSettings != null)
                {
                    var useLocalSettings = ConfigurationManager.AppSettings["UseLocalSettings"];
                    bool result;
                    if (bool.TryParse(useLocalSettings, out result))
                    {
                        _useLocalSettings = result;
                    }
                }                
                return _useLocalSettings.HasValue && _useLocalSettings.Value;
            }
        }

        private static string _databaseConnectionString { get; set; }        
        public static string DatabaseConnectionString
        {
            get {
                if (string.IsNullOrWhiteSpace(_databaseConnectionString))
                {
                    _databaseConnectionString = ConfigurationManager.ConnectionStrings["EnterpriseManagement"].ConnectionString;

                    if (string.IsNullOrWhiteSpace(_databaseConnectionString))
                    {
                        throw new ConfigurationErrorsException(nameof(_databaseConnectionString));
                    }
                }
                return _databaseConnectionString;
            }
        }

    }
}
