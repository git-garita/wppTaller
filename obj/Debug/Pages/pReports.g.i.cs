﻿#pragma checksum "..\..\..\Pages\pReports.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0EB8275FEDEF474AEA20A00C6D01EE69F414479AA34DAE7AB5E8CCC18A879B8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using wpp_Taller.Pages;


namespace wpp_Taller.Pages {
    
    
    /// <summary>
    /// pReports
    /// </summary>
    public partial class pReports : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\pReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCarsRepared;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\pReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInventorySold;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\pReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPorforms;
        
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
            System.Uri resourceLocater = new System.Uri("/wpp_Taller;component/pages/preports.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\pReports.xaml"
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
            this.btnCarsRepared = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\pReports.xaml"
            this.btnCarsRepared.Click += new System.Windows.RoutedEventHandler(this.btnCarsRepared_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnInventorySold = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\pReports.xaml"
            this.btnInventorySold.Click += new System.Windows.RoutedEventHandler(this.btnInventorySold_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnPorforms = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\pReports.xaml"
            this.btnPorforms.Click += new System.Windows.RoutedEventHandler(this.btnPorforms_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

