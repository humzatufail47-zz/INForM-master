
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace IN4MDatabase
{

using System;
    using System.Collections.Generic;
    
public partial class Room
{

    public System.Guid RMID { get; set; }

    public string Room1 { get; set; }

    public string Room_Type { get; set; }

    public string Room_Description { get; set; }

    public Nullable<double> Room_RV { get; set; }

    public string Floor { get; set; }

    public string Building { get; set; }

    public string Campus { get; set; }

    public Nullable<System.Guid> FLID { get; set; }



    public virtual Floor Floor1 { get; set; }

}

}
