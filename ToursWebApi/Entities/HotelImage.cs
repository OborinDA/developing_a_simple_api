//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToursWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelImage
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public byte[] ImageSource { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
