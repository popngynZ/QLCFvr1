﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace QLCF.Module.BusinessObjects.database
{
    [DefaultClassOptions]
    [NavigationItem]
    public partial class Trangthai : XPObject
    {
        string fMatrangthai;
        public string Matrangthai
        {
            get { return fMatrangthai; }
            set { SetPropertyValue<string>(nameof(Matrangthai), ref fMatrangthai, value); }
        }
        string fTentrangthai;
        public string Tentrangthai
        {
            get { return fTentrangthai; }
            set { SetPropertyValue<string>(nameof(Tentrangthai), ref fTentrangthai, value); }
        }
        [Association(@"DonhangReferencesTrangthai")]
        public XPCollection<Donhang> Donhangs { get { return GetCollection<Donhang>(nameof(Donhangs)); } }
    }

}
