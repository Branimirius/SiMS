﻿#pragma checksum "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6AF93715C0F29840C1F3BD198108297A4D01B279"
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
        
        
        #line 91 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNaziv;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button helpBtn;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProizvodjac;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDoza;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAlergen;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKolicina;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listSviDoktori;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listIzabraniDoktori;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPotvrdi;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
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
            this.helpBtn = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
            this.helpBtn.Click += new System.Windows.RoutedEventHandler(this.helpBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtProizvodjac = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDoza = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtAlergen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtKolicina = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.listSviDoktori = ((System.Windows.Controls.ListView)(target));
            
            #line 122 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
            this.listSviDoktori.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listSviDoktori_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.listIzabraniDoktori = ((System.Windows.Controls.ListView)(target));
            
            #line 139 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
            this.listIzabraniDoktori.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listIzabraniDoktori_Selected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnPotvrdi = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
            this.btnPotvrdi.Click += new System.Windows.RoutedEventHandler(this.btnPotvrdi_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnOdustani = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\..\..\View\AddView\DodavanjeLekova.xaml"
            this.btnOdustani.Click += new System.Windows.RoutedEventHandler(this.btnOdustani_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

