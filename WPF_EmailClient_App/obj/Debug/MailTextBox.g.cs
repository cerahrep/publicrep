﻿#pragma checksum "..\..\MailTextBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1D46246AEC98D630F3FC368B8F90554B"
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
using Xceed.Wpf.Toolkit;


namespace HCI_WPF_Email_App {
    
    
    /// <summary>
    /// MailTextBox
    /// </summary>
    public partial class MailTextBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HCI_WPF_Email_App.MailTextBox MailRichTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox MailRichText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander TextFontExpander;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontCombobox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontSizeCombobox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker TextColorPicker;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton BoldTglBtn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ItalicTglBtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton UnderLineTglBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MailTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearAllTglBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI_WPF_Email_App;component/mailtextbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MailTextBox.xaml"
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
            this.MailRichTextBox = ((HCI_WPF_Email_App.MailTextBox)(target));
            return;
            case 2:
            this.MailRichText = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 31 "..\..\MailTextBox.xaml"
            this.MailRichText.SelectionChanged += new System.Windows.RoutedEventHandler(this.MailRichText_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextFontExpander = ((System.Windows.Controls.Expander)(target));
            
            #line 33 "..\..\MailTextBox.xaml"
            this.TextFontExpander.Expanded += new System.Windows.RoutedEventHandler(this.Expander_Expanded);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MailTextBox.xaml"
            this.TextFontExpander.Collapsed += new System.Windows.RoutedEventHandler(this.Expander_Collapsed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FontCombobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.FontSizeCombobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TextColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 39 "..\..\MailTextBox.xaml"
            this.TextColorPicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.TextColorPicker_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BoldTglBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 42 "..\..\MailTextBox.xaml"
            this.BoldTglBtn.Unchecked += new System.Windows.RoutedEventHandler(this.BoldTglBtn_Unchecked);
            
            #line default
            #line hidden
            
            #line 42 "..\..\MailTextBox.xaml"
            this.BoldTglBtn.Checked += new System.Windows.RoutedEventHandler(this.BoldTglBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ItalicTglBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 43 "..\..\MailTextBox.xaml"
            this.ItalicTglBtn.Unchecked += new System.Windows.RoutedEventHandler(this.ItalicTglBtn_Unchecked);
            
            #line default
            #line hidden
            
            #line 43 "..\..\MailTextBox.xaml"
            this.ItalicTglBtn.Checked += new System.Windows.RoutedEventHandler(this.ItalicTglBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.UnderLineTglBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 44 "..\..\MailTextBox.xaml"
            this.UnderLineTglBtn.Unchecked += new System.Windows.RoutedEventHandler(this.UnderLineTglBtn_Unchecked);
            
            #line default
            #line hidden
            
            #line 44 "..\..\MailTextBox.xaml"
            this.UnderLineTglBtn.Checked += new System.Windows.RoutedEventHandler(this.UnderLineTglBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ClearAllTglBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MailTextBox.xaml"
            this.ClearAllTglBtn.Click += new System.Windows.RoutedEventHandler(this.ClearAllTglBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

