﻿#pragma checksum "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82298D2B367CDA7129665078D697A4880469EC76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BolnicaSims.MVVM.Views;
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


namespace BolnicaSims.MVVM.Views {
    
    
    /// <summary>
    /// IzvestajPacijentView
    /// </summary>
    public partial class IzvestajPacijentView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel print;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datumOd;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datumDo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Termini;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stampajBtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nazadBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BolnicaSims;component/mvvm/views/izvestajpacijentview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.print = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.datumOd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.datumDo = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.Termini = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.stampajBtn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
            this.stampajBtn.Click += new System.Windows.RoutedEventHandler(this.stampajBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.nazadBtn = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\MVVM\Views\IzvestajPacijentView.xaml"
            this.nazadBtn.Click += new System.Windows.RoutedEventHandler(this.nazadBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
