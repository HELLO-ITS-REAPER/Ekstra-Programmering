﻿#pragma checksum "..\..\..\MetricPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E489F2547A847476E3A0380AB7C446A289DBDE40"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BMI_Calculator_WPF;
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


namespace BMI_Calculator_WPF {
    
    
    /// <summary>
    /// MetricPage
    /// </summary>
    public partial class MetricPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\MetricPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HeightCM;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MetricPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WeightKG;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MetricPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Calculate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MetricPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider CentimeterMetricPage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MetricPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider KgMetricPage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BMI Calculator WPF;component/metricpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MetricPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HeightCM = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.WeightKG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Calculate = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\MetricPage.xaml"
            this.Calculate.Click += new System.Windows.RoutedEventHandler(this.Calculate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CentimeterMetricPage = ((System.Windows.Controls.Slider)(target));
            
            #line 40 "..\..\..\MetricPage.xaml"
            this.CentimeterMetricPage.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.CentimeterMetricPage_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.KgMetricPage = ((System.Windows.Controls.Slider)(target));
            
            #line 43 "..\..\..\MetricPage.xaml"
            this.KgMetricPage.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.KgMetricPage_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

