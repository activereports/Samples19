//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActiveReports.Samples.CustomTileProviders.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ActiveReports.Samples.CustomTileProviders.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Google Maps ©{0} Google, Please see http://www.google.com/intl/en_us/help/legalnotices_maps.html for more details..
        /// </summary>
        internal static string GoogleMapsTileProvider_TileProviderCopyright {
            get {
                return ResourceManager.GetString("GoogleMapsTileProvider_TileProviderCopyright", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified MapQuest Maps key is invalid..
        /// </summary>
        internal static string MapQuestMapsKeyIsInvalid {
            get {
                return ResourceManager.GetString("MapQuestMapsKeyIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright © {0} MapQuest, Inc. (“MapQuest”). Please see http://info.mapquest.com/terms-of-use/ for more details..
        /// </summary>
        internal static string MapQuestTileProvider_TileProviderCopyright {
            get {
                return ResourceManager.GetString("MapQuestTileProvider_TileProviderCopyright", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to © {0} OpenStreetMap contributors. Please see http://www.openstreetmap.org/copyright for more details..
        /// </summary>
        internal static string OpenStreetMapTileProvider_TileProviderCopyright {
            get {
                return ResourceManager.GetString("OpenStreetMapTileProvider_TileProviderCopyright", resourceCulture);
            }
        }
    }
}
