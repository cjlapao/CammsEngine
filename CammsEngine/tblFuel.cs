//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CammsEngine
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblFuel
    {
        public int ID { get; set; }
        public int SuplierID { get; set; }
        public int UnitID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float CostPerUnit { get; set; }
        public bool StockControlled { get; set; }
        public int ActualStock { get; set; }
        public int OrderedStock { get; set; }
    
        public virtual tblFuelUnit tblFuelUnit { get; set; }
    }
}