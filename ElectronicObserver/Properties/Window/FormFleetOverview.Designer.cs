﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectronicObserver.Properties.Window {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class FormFleetOverview {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FormFleetOverview() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ElectronicObserver.Properties.Window.FormFleetOverview", typeof(FormFleetOverview).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 泊地修理タイマ
        ///開始: .
        /// </summary>
        public static string AnchorageRepairToolTip {
            get {
                return ResourceManager.GetString("AnchorageRepairToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ドラム缶搭載: {0}個
        ///大発動艇搭載: {1}個
        ///輸送量(TP): S {2} / A {3}
        ///
        ///制空戦力合計: {4}
        ///索敵能力合計: {5:f2}
        ///新判定式(33):
        ///　分岐点係数1: {6:f2}
        ///　分岐点係数2: {7:f2}
        ///　分岐点係数3: {8:f2}
        ///　分岐点係数4: {9:f2}.
        /// </summary>
        public static string CombinedFleetToolTip {
            get {
                return ResourceManager.GetString("CombinedFleetToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 艦隊.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
    }
}