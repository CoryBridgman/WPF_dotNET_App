﻿#pragma checksum "..\..\..\HomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A4060FFBA08BFAD550A8825B80D34B76241F53A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Midterm___Cory_Bridgman_991199354;
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


namespace Midterm___Cory_Bridgman_991199354 {
    
    
    /// <summary>
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Midterm___Cory_Bridgman_991199354.HomePage homeWindow;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mQuit;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button customersBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button airlinesBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button flightsBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button passengersBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Midterm - Cory_Bridgman_991199354;component/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HomePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.homeWindow = ((Midterm___Cory_Bridgman_991199354.HomePage)(target));
            
            #line 8 "..\..\..\HomePage.xaml"
            this.homeWindow.Closing += new System.ComponentModel.CancelEventHandler(this.homeWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mQuit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\HomePage.xaml"
            this.mQuit.Click += new System.Windows.RoutedEventHandler(this.mQuit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 24 "..\..\..\HomePage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CustBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 25 "..\..\..\HomePage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.FlBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 26 "..\..\..\HomePage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AirlnBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 27 "..\..\..\HomePage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.PassBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 30 "..\..\..\HomePage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuAbout_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.customersBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\HomePage.xaml"
            this.customersBtn.Click += new System.Windows.RoutedEventHandler(this.customersBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.airlinesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\HomePage.xaml"
            this.airlinesBtn.Click += new System.Windows.RoutedEventHandler(this.airlinesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.flightsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\HomePage.xaml"
            this.flightsBtn.Click += new System.Windows.RoutedEventHandler(this.flightsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.passengersBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\HomePage.xaml"
            this.passengersBtn.Click += new System.Windows.RoutedEventHandler(this.passengersBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

