//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpEgitimKampi301.EFProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblLocation
    {
        public int LocationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Nullable<byte> Capacity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string DayNight { get; set; }
        public Nullable<int> GuideId { get; set; }
    
        public virtual TblGuide TblGuide { get; set; }
    }
}
