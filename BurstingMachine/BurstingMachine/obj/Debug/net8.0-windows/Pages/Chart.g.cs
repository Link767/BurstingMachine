﻿#pragma checksum "..\..\..\..\Pages\Chart.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B2471E4C607F3947302E17654D665064ED7751A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BurstingMachine.Pages;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ScottPlot.WPF;
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


namespace BurstingMachine.Pages {
    
    
    /// <summary>
    /// Chart
    /// </summary>
    public partial class Chart : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Pages\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ScottPlot.WPF.WpfPlot WpfPlot1;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTest;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNewtons;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Pages\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSpeed;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Pages\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIncrease;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Pages\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReduce;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Pages\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNormalize;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BurstingMachine;component/pages/chart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Chart.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.WpfPlot1 = ((ScottPlot.WPF.WpfPlot)(target));
            return;
            case 2:
            this.btnTest = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Pages\Chart.xaml"
            this.btnTest.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TBNewtons = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBSpeed = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnIncrease = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\Pages\Chart.xaml"
            this.btnIncrease.Click += new System.Windows.RoutedEventHandler(this.btnIncrease_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnReduce = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\Pages\Chart.xaml"
            this.btnReduce.Click += new System.Windows.RoutedEventHandler(this.btnReduce_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnNormalize = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\Pages\Chart.xaml"
            this.btnNormalize.Click += new System.Windows.RoutedEventHandler(this.btnNormalize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

