﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StamprApiClient.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StamprApiClient.Resources.StringResource", typeof(StringResource).Assembly);
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
        ///   Looks up a localized string similar to No search criteria is selected.
        /// </summary>
        internal static string NO_VALUES_TO_SEARCH {
            get {
                return ResourceManager.GetString("NO_VALUES_TO_SEARCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Url {0} is not valid for http request.
        /// </summary>
        internal static string NOT_VALID_URI {
            get {
                return ResourceManager.GetString("NOT_VALID_URI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start and End  properties should have value in case Paging property is not null.
        /// </summary>
        internal static string START_END_VALUES_SHOULD_BE_SPECIFIED {
            get {
                return ResourceManager.GetString("START_END_VALUES_SHOULD_BE_SPECIFIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start property should have value in case End property is not null.
        /// </summary>
        internal static string START_VALUE_SHOULD_BE_SPECIFIED {
            get {
                return ResourceManager.GetString("START_VALUE_SHOULD_BE_SPECIFIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status {0} is not allowed for batch creation.
        /// </summary>
        internal static string STATUS_NOT_ALLOWED {
            get {
                return ResourceManager.GetString("STATUS_NOT_ALLOWED", resourceCulture);
            }
        }
    }
}
