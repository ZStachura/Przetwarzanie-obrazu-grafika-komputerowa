﻿#pragma checksum "..\..\..\..\ColorChange\ColorChange.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D6FEAA3DAE5F301FEB6F3E4B08ECF297EBF37244"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Laboratorium_4_5.ColorChange;
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


namespace Laboratorium_4_5.ColorChange {
    
    
    /// <summary>
    /// ColorChange
    /// </summary>
    public partial class ColorChange : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\ColorChange\ColorChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RedValue;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\ColorChange\ColorChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HueValue;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\ColorChange\ColorChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GreenValue;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\ColorChange\ColorChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SaturationValue;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\ColorChange\ColorChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BlueValue;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\ColorChange\ColorChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ValueValue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Laboratorium 4_5;V1.0.0.0;component/colorchange/colorchange.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorChange\ColorChange.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RedValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.RedValue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ValueChange);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.RedValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HueValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.HueValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GreenValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.GreenValue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ValueChange);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.GreenValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SaturationValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.SaturationValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BlueValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.BlueValue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ValueChange);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.BlueValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ValueValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\..\ColorChange\ColorChange.xaml"
            this.ValueValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 51 "..\..\..\..\ColorChange\ColorChange.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseDialog);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
