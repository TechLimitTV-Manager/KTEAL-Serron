﻿#pragma checksum "D:\KTEAL-Serron\Project\KTEAL Serron\KTEAL Serron\Lines\Line20.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0BD1B02E5E513D0ACCFD2DADBC3C9D8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KTEAL_Serron.Lines
{
    partial class Line20 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Line20_Page = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 8 "..\..\..\Lines\Line20.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)this.Line20_Page).Loading += this.Line20_Page_Loading;
                    #line default
                }
                break;
            case 2:
                {
                    this.Line20_Grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.Line20_Logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4:
                {
                    this.Line20_List = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5:
                {
                    this.Line20_Daily_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\Lines\Line20.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Line20_Daily_Button).Click += this.Line20_Daily_Button_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.Line20_Saturday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\Lines\Line20.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Line20_Saturday_Button).Click += this.Line20_Saturday_Button_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.Line20_Sunday_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\Lines\Line20.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Line20_Sunday_Button).Click += this.Line20_Sunday_Button_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.Line20_Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
