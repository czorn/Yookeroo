﻿#pragma checksum "C:\Users\Amy Tsai\Developer\Yookeroo\Yookeroo\YookerooApp\Yookeroo\GroupPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94ECB077AEE755D208458320B6BF88A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Yookeroo {
    
    
    public partial class GroupPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama Title;
        
        internal Microsoft.Phone.Controls.PanoramaItem feed;
        
        internal Microsoft.Phone.Controls.PanoramaItem people;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Yookeroo;component/GroupPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Title = ((Microsoft.Phone.Controls.Panorama)(this.FindName("Title")));
            this.feed = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("feed")));
            this.people = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("people")));
        }
    }
}

