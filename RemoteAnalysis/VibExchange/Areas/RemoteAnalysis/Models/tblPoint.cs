//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VibExchange.Areas.RemoteAnalysis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPoint
    {
        public int PointID { get; set; }
        public string PointName { get; set; }
        public string PointDetail { get; set; }
        public Nullable<int> PointBearingID { get; set; }
        public int FileID { get; set; }
        public int ParentID { get; set; }
        public string NodeType { get; set; }
    }
}
