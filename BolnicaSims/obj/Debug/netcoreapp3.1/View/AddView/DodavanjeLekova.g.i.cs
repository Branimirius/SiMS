﻿#pragma checksum "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C44BA406792BB1917C844513A39B7B3374941F9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BolnicaSims.View.AddView;
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


namespace BolnicaSims.View.AddView {
    
    
    /// <summary>
    /// DodavanjeLekova
    /// </summary>
    public partial class DodavanjeLekova : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNaziv;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProizvodjac;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDoza;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAlergen;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKolicina;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPotvrdi;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOdustani;
        
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
            System.Uri resourceLocater = new System.Uri("/BolnicaSims;component/view/addview/dodavanjelekova.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
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
            this.txtNaziv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtProizvodjac = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDoza = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtAlergen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtKolicina = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnPotvrdi = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
            this.btnPotvrdi.Click += new System.Windows.RoutedEventHandler(this.btnPotvrdi_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOdustani = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
            this.btnOdustani.Click += new System.Windows.RoutedEventHandler(this.btnOdustani_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
