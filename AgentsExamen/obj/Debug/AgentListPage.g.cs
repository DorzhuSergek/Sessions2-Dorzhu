﻿#pragma checksum "..\..\AgentListPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CAAF90CC5EB5C0AF57D8424BF0A0CB90364FDF05"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AgentsExamen;
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


namespace AgentsExamen {
    
    
    /// <summary>
    /// AgentListPage
    /// </summary>
    public partial class AgentListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\AgentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changePrioritet;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AgentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AgentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbType;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AgentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFiltr;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AgentListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvAgent;
        
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
            System.Uri resourceLocater = new System.Uri("/AgentsExamen;component/agentlistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AgentListPage.xaml"
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
            
            #line 18 "..\..\AgentListPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.changePrioritet = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\AgentListPage.xaml"
            this.changePrioritet.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\AgentListPage.xaml"
            this.searchTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\AgentListPage.xaml"
            this.cmbType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbFiltr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbFiltr = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\AgentListPage.xaml"
            this.cmbFiltr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbFiltr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvAgent = ((System.Windows.Controls.ListView)(target));
            
            #line 32 "..\..\AgentListPage.xaml"
            this.lvAgent.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LvAgent_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 32 "..\..\AgentListPage.xaml"
            this.lvAgent.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LvAgent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
