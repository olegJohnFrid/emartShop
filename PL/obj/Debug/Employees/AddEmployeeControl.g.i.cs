﻿#pragma checksum "..\..\..\Employees\AddEmployeeControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AED9694BEA248919F6BD766259A49CD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace PL.Employees {
    
    
    /// <summary>
    /// AddEmployeeControl
    /// </summary>
    public partial class AddEmployeeControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Employees\AddEmployeeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNametxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Employees\AddEmployeeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastNametxt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Employees\AddEmployeeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDnumbertxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Employees\AddEmployeeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox gendertxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Employees\AddEmployeeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox salarytxt;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Employees\AddEmployeeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox supervisorIDtxt;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Employees\AddEmployeeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox departmentIDtxt;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Employees\AddEmployeeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typetxt;
        
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
            System.Uri resourceLocater = new System.Uri("/PL;component/employees/addemployeecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Employees\AddEmployeeControl.xaml"
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
            this.firstNametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lastNametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.IDnumbertxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.gendertxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.salarytxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.supervisorIDtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.departmentIDtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.typetxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            
            #line 47 "..\..\..\Employees\AddEmployeeControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Register_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

