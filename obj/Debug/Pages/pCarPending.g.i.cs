﻿#pragma checksum "..\..\..\Pages\pCarPending.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32649F9CEF9009662775A8C76555F1A5BF5C8AC659FF0BE34CCEFD5A66076D1E"
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
    /// pCarPending
    /// </summary>
    public partial class pCarPending : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgCarsPending;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBrand;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtModel;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDetails;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRepair;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveCar;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCliente;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbClients;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Pages\pCarPending.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCheck;
        
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
            System.Uri resourceLocater = new System.Uri("/wpp_Taller;component/pages/pcarpending.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\pCarPending.xaml"
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
            this.dtgCarsPending = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\..\Pages\pCarPending.xaml"
            this.dtgCarsPending.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dtgCarsPending_LoadingRow);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\Pages\pCarPending.xaml"
            this.dtgCarsPending.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dtgCarsPending_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtBrand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtDetails = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtRepair = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnSaveCar = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\Pages\pCarPending.xaml"
            this.btnSaveCar.Click += new System.Windows.RoutedEventHandler(this.btnSaveCar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Pages\pCarPending.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtCliente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.cmbClients = ((System.Windows.Controls.ComboBox)(target));
            
            #line 113 "..\..\..\Pages\pCarPending.xaml"
            this.cmbClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbClient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnCheck = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\Pages\pCarPending.xaml"
            this.btnCheck.Click += new System.Windows.RoutedEventHandler(this.btnCheck_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 32 "..\..\..\Pages\pCarPending.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeleteCar_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

