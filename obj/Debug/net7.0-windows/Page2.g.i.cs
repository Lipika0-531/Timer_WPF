﻿#pragma checksum "..\..\..\Page2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7446A2F1A01D3D2CB1CE3969178D984467A3607"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using TimerApplication;


namespace TIMER_APPLICATION {
    
    
    /// <summary>
    /// Page2
    /// </summary>
    public partial class Page2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProjectNameMenu;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BillStatusMenu;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TaskNameMenu;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TaskListMenu;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update_Btn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel_Btn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TIMER_APPLICATION;component/page2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProjectNameMenu = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\Page2.xaml"
            this.ProjectNameMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProjectName_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BillStatusMenu = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\Page2.xaml"
            this.BillStatusMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BillStatus_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TaskNameMenu = ((System.Windows.Controls.ComboBox)(target));
            
            #line 46 "..\..\..\Page2.xaml"
            this.TaskNameMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TaskName_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TaskListMenu = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\..\Page2.xaml"
            this.TaskListMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TaskList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Update_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Page2.xaml"
            this.Update_Btn.Click += new System.Windows.RoutedEventHandler(this.Update_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cancel_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Page2.xaml"
            this.Cancel_Btn.Click += new System.Windows.RoutedEventHandler(this.Cancel_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

