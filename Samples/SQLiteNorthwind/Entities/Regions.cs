//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5456
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNETCF.ORM
{
    using System;
    using OpenNETCF.ORM;
    
    
    [Entity(KeyScheme.None)]
    public class Regions
    {
        
        private static Regions ORM_CreateProxy(OpenNETCF.ORM.FieldAttributeCollection fields, System.Data.IDataReader results)
        {
            var item = new Regions();
foreach(var field in fields){
            var value = results[field.Ordinal];
switch(field.FieldName){
case "RegionID":
            // If this is a TimeSpan, use the commented line below
            // item.RegionID = (value == DBNull.Value) ? TimeSpan.MinValue; : new TimeSpan((long)value);
            item.RegionID = (value == DBNull.Value) ? 0 : (long)value;
            break;
case "RegionDescription":
            item.RegionDescription = (value == DBNull.Value) ? null : (string)value;
            break;
}
}
            return item;
        }
        
        private long m_regionid;
        
        private string m_regiondescription;
        
        [Field(IsPrimaryKey=true)]
        public long RegionID
        {
            get
            {
                return this.m_regionid;
            }
            set
            {
                this.m_regionid = value;
            }
        }
        
        [Field()]
        public string RegionDescription
        {
            get
            {
                return this.m_regiondescription;
            }
            set
            {
                this.m_regiondescription = value;
            }
        }
    }
}
