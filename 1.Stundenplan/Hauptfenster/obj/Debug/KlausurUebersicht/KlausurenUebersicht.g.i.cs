﻿#pragma checksum "..\..\..\KlausurUebersicht\KlausurenUebersicht.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "217071A08593E94A0432C2E062FD670BDFD65D9C6A6B23FCFC5B5A72240B6F24"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Hauptfenster;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Hauptfenster {
    
    
    /// <summary>
    /// KlausurenUebersicht
    /// </summary>
    public partial class KlausurenUebersicht : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\KlausurUebersicht\KlausurenUebersicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\KlausurUebersicht\KlausurenUebersicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\KlausurUebersicht\KlausurenUebersicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Hauptfenster;component/klausuruebersicht/klausurenuebersicht.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\KlausurUebersicht\KlausurenUebersicht.xaml"
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
            
            #line 2 "..\..\..\KlausurUebersicht\KlausurenUebersicht.xaml"
            ((Hauptfenster.KlausurenUebersicht)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.AbspeichernBeimSchliessen);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\KlausurUebersicht\KlausurenUebersicht.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.KalsurHinzufuegen);
            
            #line default
            #line hidden
            return;
            case 3:
            this.delButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\KlausurUebersicht\KlausurenUebersicht.xaml"
            this.delButton.Click += new System.Windows.RoutedEventHandler(this.KlausurLoeschen);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

