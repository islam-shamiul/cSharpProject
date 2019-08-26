﻿#pragma checksum "..\..\ManagerPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "008466C811DB06EEB5A5C7893A0C24A26D1B9741"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BankManagementGui;
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


namespace BankManagementGui {
    
    
    /// <summary>
    /// ManagerPanel
    /// </summary>
    public partial class ManagerPanel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem client_lst;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid client_list_tbl;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem transaction_tbl;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid transaction_log_tbl;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem employee_lst;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid employee_lst_tbl;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox serch_txt;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search_btn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reloadButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\ManagerPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout_button;
        
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
            System.Uri resourceLocater = new System.Uri("/BankManagementGui;component/managerpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManagerPanel.xaml"
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
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.client_lst = ((System.Windows.Controls.TabItem)(target));
            
            #line 22 "..\..\ManagerPanel.xaml"
            this.client_lst.Loaded += new System.Windows.RoutedEventHandler(this.client_lst_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.client_list_tbl = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.transaction_tbl = ((System.Windows.Controls.TabItem)(target));
            
            #line 33 "..\..\ManagerPanel.xaml"
            this.transaction_tbl.Loaded += new System.Windows.RoutedEventHandler(this.transaction_tbl_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.transaction_log_tbl = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.employee_lst = ((System.Windows.Controls.TabItem)(target));
            
            #line 43 "..\..\ManagerPanel.xaml"
            this.employee_lst.Loaded += new System.Windows.RoutedEventHandler(this.employee_lst_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.employee_lst_tbl = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.serch_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\ManagerPanel.xaml"
            this.serch_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSearchText_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.search_btn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\ManagerPanel.xaml"
            this.search_btn.Click += new System.Windows.RoutedEventHandler(this.search_btn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.reloadButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\ManagerPanel.xaml"
            this.reloadButton.Click += new System.Windows.RoutedEventHandler(this.reloadButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.logout_button = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\ManagerPanel.xaml"
            this.logout_button.Click += new System.Windows.RoutedEventHandler(this.logout_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
