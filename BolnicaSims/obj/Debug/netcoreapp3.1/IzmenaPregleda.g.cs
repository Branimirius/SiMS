﻿#pragma checksum "..\..\..\IzmenaPregleda.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A0614467796BBE5B94FDC748EC60CE1F674571A3"
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
    /// IzmenaPregleda
    /// </summary>
    public partial class IzmenaPregleda : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\IzmenaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlock1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\IzmenaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlock2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\IzmenaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\IzmenaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox2;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\IzmenaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izmenaBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\IzmenaPregleda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox3;
        
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
            System.Uri resourceLocater = new System.Uri("/BolnicaSims;component/izmenapregleda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\IzmenaPregleda.xaml"
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
            this.txtBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtBlock2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtBox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.izmenaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\IzmenaPregleda.xaml"
            this.izmenaBtn.Click += new System.Windows.RoutedEventHandler(this.ButtonIzmeni_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtBox3 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

