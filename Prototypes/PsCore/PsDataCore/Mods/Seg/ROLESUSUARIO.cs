//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PsDataCore.Mods.Seg
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROLESUSUARIO
    {
        public int ROLID { get; set; }
        public int USERID { get; set; }
        public string DEFAULTPAGE { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> DESDE { get; set; }
        public Nullable<System.DateTime> HASTA { get; set; }
        public bool ESTATUS { get; set; }
        public Nullable<bool> INDEFINIDO { get; set; }
    
        public virtual ROLES ROLES { get; set; }
        public virtual USUARIOSSEG USUARIOSSEG { get; set; }
    }
}