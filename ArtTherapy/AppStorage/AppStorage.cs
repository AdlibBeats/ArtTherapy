using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ArtTherapy.AppStorage
{
    public class AppStorage
    {
        private static void Remove(string key)
        {
            var local = ApplicationData.Current.LocalSettings;
            local.Values.Remove(key);
        }

        private static void SetValue(string key, object value)
        {
            var local = ApplicationData.Current.LocalSettings;
            local.Values[key] = value;
        }

        private static string GetValue(string key, string @default = null)
        {
            var local = ApplicationData.Current.LocalSettings;
            return local.Values[key] as string ?? @default;
        }

        private const string TokenKey = "AccessToken";

        public static string AccessToken
        {
            get => GetValue(TokenKey);
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Remove(TokenKey);
                    return;
                }

                SetValue(TokenKey, value);
            }
        }
    }
}
