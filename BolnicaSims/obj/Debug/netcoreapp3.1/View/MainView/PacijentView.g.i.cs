﻿#pragma checksum "..\..\..\..\..\View\MainView\PacijentView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3B36542C4F74FE21C01F34EC7F4866431CC0D7C4"
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
    /// PacijentView
    /// </summary>
    public partial class PacijentView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\View\MainView\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem TerminiTab;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\View\MainView\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridTermini;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\View\MainView\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zakazi;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\View\MainView\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izmeni;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\View\MainView\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem ReceptiTab;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\MainView\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridRecepti;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\View\MainView\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnketaBolnica;
        
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
            System.Uri resourceLocater = new System.Uri("/BolnicaSims;component/view/mainview/pacijentview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\MainView\PacijentView.xaml"
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
            this.TerminiTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.dataGridTermini = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.zakazi = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\View\MainView\PacijentView.xaml"
            this.zakazi.Click += new System.Windows.RoutedEventHandler(this.ButtonZakazi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.izmeni = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\View\MainView\PacijentView.xaml"
            this.izmeni.Click += new System.Windows.RoutedEventHandler(this.ButtonIzmeniTermin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 27 "..\..\..\..\..\View\MainView\PacijentView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonOtkazi_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ReceptiTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.dataGridRecepti = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            
            #line 55 "..\..\..\..\..\View\MainView\PacijentView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonObavestenja_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 56 "..\..\..\..\..\View\MainView\PacijentView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_AnketaDoktor);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAnketaBolnica = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\..\View\MainView\PacijentView.xaml"
            this.btnAnketaBolnica.Click += new System.Windows.RoutedEventHandler(this.Button_Click_AnketaBolnica);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

