﻿#pragma checksum "..\..\MenuFenster.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2F684A60C3F104E0D2CB8A783EA15952F9DA1231EF031EA6375E85AE94597C15"
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
    /// MenuFenster
    /// </summary>
    public partial class MenuFenster : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\MenuFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStundenplan;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MenuFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnToDo;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MenuFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNotizen;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MenuFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKlausuren;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MenuFenster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Hauptfenster;component/menufenster.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuFenster.xaml"
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
            this.btnStundenplan = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\MenuFenster.xaml"
            this.btnStundenplan.Click += new System.Windows.RoutedEventHandler(this.BtnStundenplan_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnToDo = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\MenuFenster.xaml"
            this.btnToDo.Click += new System.Windows.RoutedEventHandler(this.BtnToDo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnNotizen = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MenuFenster.xaml"
            this.btnNotizen.Click += new System.Windows.RoutedEventHandler(this.BtnNotizen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnKlausuren = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\MenuFenster.xaml"
            this.btnKlausuren.Click += new System.Windows.RoutedEventHandler(this.BtnKlausuren_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

