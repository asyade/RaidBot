﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaidBot.Data {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class DataSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static DataSetting defaultInstance = ((DataSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DataSetting())));
        
        public static DataSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Zakaria\\AppData\\Local\\Ankama\\Dofus2\\app\\data\\i18n\\i18n_fr.D2I")]
        public string D2IFilePath {
            get {
                return ((string)(this["D2IFilePath"]));
            }
            set {
                this["D2IFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data\\Maps")]
        public string D2PFolderPath {
            get {
                return ((string)(this["D2PFolderPath"]));
            }
            set {
                this["D2PFolderPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data\\Game")]
        public string D2OFolderPath {
            get {
                return ((string)(this["D2OFolderPath"]));
            }
            set {
                this["D2OFolderPath"] = value;
            }
        }
    }
}