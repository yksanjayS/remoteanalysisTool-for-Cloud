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
    
    public partial class tblTrain
    {
        public int TrainID { get; set; }
        public string TrainName { get; set; }
        public string TrainDetail { get; set; }
        public Nullable<int> NoOfMachine { get; set; }
        public int FileID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string NodeType { get; set; }
    }
}