﻿#pragma checksum "..\..\..\PartsAdmin\EditPart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "31E8D921721CB4FEF6967BFDE8A2D85131B0B70D0EFD645217B286F7B0E5274F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Univalle.AutoNetWPF.PartsAdmin;


namespace Univalle.AutoNetWPF.PartsAdmin {
    
    
    /// <summary>
    /// EditPart
    /// </summary>
    public partial class EditPart : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreProducto;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSaldoActual;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioBase;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPeso;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCodigoProducto;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFabrica;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTipoRepuesto;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuadar;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\PartsAdmin\EditPart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
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
            System.Uri resourceLocater = new System.Uri("/Univalle.AutoNetWPF;component/partsadmin/editpart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PartsAdmin\EditPart.xaml"
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
            
            #line 16 "..\..\..\PartsAdmin\EditPart.xaml"
            ((Univalle.AutoNetWPF.PartsAdmin.EditPart)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNombreProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtSaldoActual = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPrecioBase = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPeso = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtCodigoProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtFabrica = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtTipoRepuesto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnGuadar = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\PartsAdmin\EditPart.xaml"
            this.btnGuadar.Click += new System.Windows.RoutedEventHandler(this.btnGuadar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\..\PartsAdmin\EditPart.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

