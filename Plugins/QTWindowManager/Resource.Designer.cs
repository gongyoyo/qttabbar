﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizoPlugins {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuizoPlugins.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap QTWindowManager_large {
            get {
                object obj = ResourceManager.GetObject("QTWindowManager_large", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap QTWindowManager_small {
            get {
                object obj = ResourceManager.GetObject("QTWindowManager_small", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 Window manager option;Enlarge window;Shrink window;Widen window;Narrow widnow;Heighten window;Lower window;Restore initial size;Move window left;Move window right;Move window up;Move window down;Maximize window;Minimize window;Restore window;Window manager 的本地化字符串。
        /// </summary>
        internal static string ResStrs {
            get {
                return ResourceManager.GetString("ResStrs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ウィンドウマネージャ オプション;ウィンドウ拡大;ウィンドウ縮小;幅拡大;幅縮小;高さ拡大;高さ縮小;元のサイズに戻す;ウィンドウを左へ;ウィンドウを右へ;ウィンドウを上へ;ウィンドウを下へ;最大化;最小化;元に戻す;ウィンドウマネージャ 的本地化字符串。
        /// </summary>
        internal static string ResStrs_ja {
            get {
                return ResourceManager.GetString("ResStrs_ja", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        internal static string ResStrs_Options {
            get {
                return ResourceManager.GetString("ResStrs_Options", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 起動時のサイズ;起動時の位置;サイズを復元;位置を復元;リサイズするとき位置も自動で調整;リサイズ/移動時のピクセル;プリセット;設定;削除;OK;キャンセル;現在の位置取得;現在のサイズ取得;起動時プリセット;取得 的本地化字符串。
        /// </summary>
        internal static string ResStrs_Options_ja {
            get {
                return ResourceManager.GetString("ResStrs_Options_ja", resourceCulture);
            }
        }
    }
}
