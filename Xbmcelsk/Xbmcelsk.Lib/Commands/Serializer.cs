using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Xbmcelsk.Lib.Commands {
    public static class Serializer {
        private static JsonSerializerSettings settings;

        public static JsonSerializerSettings Settings {
            get {
                if (settings == null) {
                    settings = BuildSettings();
                }

                return settings;
            }
        }

        private static JsonSerializerSettings BuildSettings() {
            var settings = new JsonSerializerSettings();

            settings.Converters.Add(new LowerCaseStringEnumConverter { CamelCaseText = true });

            return settings;
        }

        private class LowerCaseStringEnumConverter : StringEnumConverter {
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
                if (value is Enum) {
                    writer.WriteValue(value.ToString().ToLowerInvariant());
                }
                else {
                    base.WriteJson(writer, value, serializer);
                }
            }
        }
    }
}
