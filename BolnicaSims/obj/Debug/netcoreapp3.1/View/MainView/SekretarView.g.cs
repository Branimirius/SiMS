﻿#pragma checksum "..\..\..\..\..\View\MainView\SekretarView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5BBA9B7EA61AC529B00F74FB1D1A4E52128931B0"
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
    /// SekretarView
    /// </summary>
    public partial class SekretarView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\View\MainView\SekretarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem pacijentiTab;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\View\MainView\SekretarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridPacijenti;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\View\MainView\SekretarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem lekariTab;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\MainView\SekretarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem TerminiTab;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\View\MainView\SekretarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridTermini;
        
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
            System.Uri resourceLocater = new System.Uri("/BolnicaSims;component/view/mainview/sekretarview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\MainView\SekretarView.xaml"
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
            this.pacijentiTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.dataGridPacijenti = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 25 "..\..\..\..\..\View\MainView\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonUkloni_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\..\..\..\View\MainView\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonDodaj_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\..\..\..\View\MainView\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonIzmeni_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lekariTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.TerminiTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 8:
            this.dataGridTermini = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            
            #line 48 "..\..\..\..\..\View\MainView\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonZakazi_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 49 "..\..\..\..\..\View\MainView\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonIzmeniTermin_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 50 "..\..\..\..\..\View\MainView\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonOtkazi_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 57 "..\..\..\..\..\View\MainView\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonObavestenja_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

