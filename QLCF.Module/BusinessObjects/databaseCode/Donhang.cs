using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QLCF.Module.BusinessObjects.database
{

    public partial class Donhang
    {
        public Donhang(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
