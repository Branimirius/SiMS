﻿#pragma checksum "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CEFA800959A99B50E2C39441C9CA0EE933CCC417"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BolnicaSims;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace BolnicaSims {
    
    
    /// <summary>
    /// ListaSopstvenihTermina
    /// </summary>
    public partial class ListaSopstvenihTermina : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridSopstveniTermini;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_karton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BolnicaSims;component/view/mainview/listasopstvenihtermina.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dataGridSopstveniTermini = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
            this.button_Copy.Click += new System.Windows.RoutedEventHandler(this.button_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
            this.button_Copy1.Click += new System.Windows.RoutedEventHandler(this.button_Copy1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_karton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\View\MainView\ListaSopstvenihTermina.xaml"
            this.button_karton.Click += new System.Windows.RoutedEventHandler(this.button_karton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

