﻿#pragma checksum "..\..\..\TextEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9B628CAE1E68F6ABFCBCE6401990654D343E1DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Day_01;
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


namespace Day_01 {
    
    
    /// <summary>
    /// TextEditor
    /// </summary>
    public partial class TextEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\TextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Day 01;component/texteditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TextEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textbox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 40 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Set_text);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 42 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Select_All_Text);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 44 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Clear_Text);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 46 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Prepend_Text);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 48 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Insert_Text);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 50 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Append_Text);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 52 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cut_Text);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 54 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Past_Text);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 56 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Undo_Text);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 64 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Change_Accecability);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 65 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Change_Accecability);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 71 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Change_Alignment);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 72 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Change_Alignment);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 73 "..\..\..\TextEditor.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.Change_Alignment);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

