﻿#pragma checksum "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A80A0A8D0197182CE5564823BEB6C70EE453BDC0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BolnicaSims.View.MainView;
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


namespace BolnicaSims.View.MainView {
    
    
    /// <summary>
    /// ListaTerminaDoktor
    /// </summary>
    public partial class ListaTerminaDoktor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridSopstveniTermini;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
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
            System.Uri resourceLocater = new System.Uri("/BolnicaSims;component/view/tableview/listaterminadoktor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
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
            this.dataGridSopstveniTermini = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
            this.button_Copy.Click += new System.Windows.RoutedEventHandler(this.button_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
            this.button_Copy1.Click += new System.Windows.RoutedEventHandler(this.button_Copy1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 31 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_karton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 35 "..\..\..\..\..\View\TableView\ListaTerminaDoktor.xaml"
            this.datePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.datePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

