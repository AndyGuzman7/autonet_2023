﻿#pragma checksum "..\..\..\..\PersonasAdmin\EmployeeT\uscViewEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2AE0815197E6D5D2294912E904A5912C22EB992BEFA8DA3084713CFFC3F89CDA"
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
using Univalle.AutoNetWPF.PersonasAdmin;


namespace Univalle.AutoNetWPF.PersonasAdmin {
    
    
    /// <summary>
    /// uscEmployee
    /// </summary>
    public partial class uscEmployee : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 89 "..\..\..\..\PersonasAdmin\EmployeeT\uscViewEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAñadirEmpleado;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\PersonasAdmin\EmployeeT\uscViewEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridMainParts;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\PersonasAdmin\EmployeeT\uscViewEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridEmployees;
        
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
            System.Uri resourceLocater = new System.Uri("/Univalle.AutoNetWPF;component/personasadmin/employeet/uscviewemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PersonasAdmin\EmployeeT\uscViewEmployee.xaml"
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
            
            #line 16 "..\..\..\..\PersonasAdmin\EmployeeT\uscViewEmployee.xaml"
            ((Univalle.AutoNetWPF.PersonasAdmin.uscEmployee)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAñadirEmpleado = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\PersonasAdmin\EmployeeT\uscViewEmployee.xaml"
            this.btnAñadirEmpleado.Click += new System.Windows.RoutedEventHandler(this.btnAñadirEmpleado_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gridMainParts = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.gridEmployees = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

