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
namespace QLCF.Module.BusinessObjects.database
{

    public partial class Hoadon : XPObject
    {
        short fMahoadon;
        public short Mahoadon
        {
            get { return fMahoadon; }
            set { SetPropertyValue<short>(nameof(Mahoadon), ref fMahoadon, value); }
        }
        DateTime fNgaytao;
        public DateTime Ngaytao
        {
            get { return fNgaytao; }
            set { SetPropertyValue<DateTime>(nameof(Ngaytao), ref fNgaytao, value); }
        }
        Menu fMasanpham;
        public Menu Masanpham
        {
            get { return fMasanpham; }
            set { SetPropertyValue<Menu>(nameof(Masanpham), ref fMasanpham, value); }
        }
        Donhang fMadonhang;
        [Association(@"HoadonReferencesDonhang")]
        public Donhang Madonhang
        {
            get { return fMadonhang; }
            set { SetPropertyValue<Donhang>(nameof(Madonhang), ref fMadonhang, value); }
        }
        Taikhoan fMataikhoan;
        [Association(@"HoadonReferencesTaikhoan")]
        public Taikhoan Mataikhoan
        {
            get { return fMataikhoan; }
            set { SetPropertyValue<Taikhoan>(nameof(Mataikhoan), ref fMataikhoan, value); }
        }
        [Association(@"HoadonCTReferencesHoadon")]
        public XPCollection<HoadonCT> HoadonCTs { get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); } }
        [Association(@"ThanhtoanReferencesHoadon")]
        public XPCollection<Thanhtoan> Thanhtoans { get { return GetCollection<Thanhtoan>(nameof(Thanhtoans)); } }
    }

}
