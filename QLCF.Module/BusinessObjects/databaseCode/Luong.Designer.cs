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
    public partial class Luong : XPObject
    {
        Taikhoan fMataikhoan;
        [Association(@"LuongReferencesTaikhoan")]
        public Taikhoan Mataikhoan
        {
            get { return fMataikhoan; }
            set { SetPropertyValue<Taikhoan>(nameof(Mataikhoan), ref fMataikhoan, value); }
        }
        long fSogiolam;
        public long Sogiolam
        {
            get { return fSogiolam; }
            set { SetPropertyValue<long>(nameof(Sogiolam), ref fSogiolam, value); }
        }
        decimal fTienluong;
        public decimal Tienluong
        {
            get { return fTienluong = (decimal)Sogiolam * 20000; }
            
        }
    }

}
