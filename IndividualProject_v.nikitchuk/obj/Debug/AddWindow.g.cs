﻿#pragma checksum "..\..\AddWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D949E0BF1972316258FD7686A3BA5D72A70E0755B797EA2DE5A057D17B62A7C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IndividualProject_v.nikitchuk;
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


namespace IndividualProject_v.nikitchuk {
    
    
    /// <summary>
    /// AddWindow
    /// </summary>
    public partial class AddWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrderTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductComboBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountProductTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OneCostTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddToOrderButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameClientTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearButton;
        
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
            System.Uri resourceLocater = new System.Uri("/IndividualProject_v.nikitchuk;component/addwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddWindow.xaml"
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
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\AddWindow.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OrderTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ProductComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\AddWindow.xaml"
            this.ProductComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CountProductTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\AddWindow.xaml"
            this.CountProductTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CountProductTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OneCostTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AddToOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AddWindow.xaml"
            this.AddToOrderButton.Click += new System.Windows.RoutedEventHandler(this.AddToOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NameClientTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\AddWindow.xaml"
            this.NameClientTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NameClientTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PhoneNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\AddWindow.xaml"
            this.PhoneNumberTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PhoneNumberTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ClearButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AddWindow.xaml"
            this.ClearButton.Click += new System.Windows.RoutedEventHandler(this.ClearButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

