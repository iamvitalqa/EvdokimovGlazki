﻿#pragma checksum "..\..\prioritycng.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BAF959061C5D2C9C20B06CE4F69FA9E14B0CB14C903460F86DF2DFA3A83B703A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EvdokimovGlazki;
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


namespace EvdokimovGlazki {
    
    
    /// <summary>
    /// prioritycng
    /// </summary>
    public partial class prioritycng : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\prioritycng.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PRTBOX;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\prioritycng.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textpriority;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\prioritycng.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBTN;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\prioritycng.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseBTN;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\prioritycng.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/EvdokimovGlazki;component/prioritycng.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\prioritycng.xaml"
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
            this.PRTBOX = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.textpriority = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SaveBTN = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\prioritycng.xaml"
            this.SaveBTN.Click += new System.Windows.RoutedEventHandler(this.SaveBTN_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseBTN = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\prioritycng.xaml"
            this.CloseBTN.Click += new System.Windows.RoutedEventHandler(this.CloseBTN_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
