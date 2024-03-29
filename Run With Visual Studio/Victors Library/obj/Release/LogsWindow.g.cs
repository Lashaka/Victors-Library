﻿#pragma checksum "..\..\LogsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AE891985C0F00E169523F85B2E94BE19E5D21CFDC17294300E6A5182CA1A38CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Victors_Library;


namespace Victors_Library {
    
    
    /// <summary>
    /// LogsWindow
    /// </summary>
    public partial class LogsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\LogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas CANVAS;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\LogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Librarian_Image;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\LogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BookDataGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\LogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BookSearch_Button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\LogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BoughtBooks_Button;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\LogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemovedtBooks_Button;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\LogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddedBooks_Button;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\LogsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exceptions_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Victors Library;component/logswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LogsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CANVAS = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.Librarian_Image = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.BookDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.BookSearch_Button = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\LogsWindow.xaml"
            this.BookSearch_Button.Click += new System.Windows.RoutedEventHandler(this.BookSearch_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BoughtBooks_Button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\LogsWindow.xaml"
            this.BoughtBooks_Button.Click += new System.Windows.RoutedEventHandler(this.Bought_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RemovedtBooks_Button = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\LogsWindow.xaml"
            this.RemovedtBooks_Button.Click += new System.Windows.RoutedEventHandler(this.Removed_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddedBooks_Button = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\LogsWindow.xaml"
            this.AddedBooks_Button.Click += new System.Windows.RoutedEventHandler(this.Added_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Exceptions_Button = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\LogsWindow.xaml"
            this.Exceptions_Button.Click += new System.Windows.RoutedEventHandler(this.Exceptions_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

