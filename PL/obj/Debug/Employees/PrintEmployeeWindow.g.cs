﻿#pragma checksum "..\..\..\Employees\PrintEmployeeWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FBF92278C2AD95AE94A0061CACF980F1"
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
using System.Windows.Forms.Integration;
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
    /// PrintEmployeeWindow
    /// </summary>
    public partial class PrintEmployeeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Employees\PrintEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dock;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Employees\PrintEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeB;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\Employees\PrintEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button maximaizeB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Employees\PrintEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimaizeB;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Employees\PrintEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Employees\PrintEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PL;component/employees/printemployeewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Employees\PrintEmployeeWindow.xaml"
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
            this.dock = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.closeB = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\Employees\PrintEmployeeWindow.xaml"
            this.closeB.Click += new System.Windows.RoutedEventHandler(this.closeClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.maximaizeB = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\Employees\PrintEmployeeWindow.xaml"
            this.maximaizeB.Click += new System.Windows.RoutedEventHandler(this.maximaizeB_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.minimaizeB = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Employees\PrintEmployeeWindow.xaml"
            this.minimaizeB.Click += new System.Windows.RoutedEventHandler(this.minimaizeClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.refreshButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Employees\PrintEmployeeWindow.xaml"
            this.refreshButton.Click += new System.Windows.RoutedEventHandler(this.refreshButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

