
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
    
public partial class Asset
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Asset()
    {

        this.AssetAttibutes = new HashSet<AssetAttibute>();

        this.Components = new HashSet<Component>();

    }


    public System.Guid AssetID { get; set; }

    public string AssetName { get; set; }

    public string AssetDescription { get; set; }

    public Nullable<System.Guid> AssetGroupID { get; set; }

    public Nullable<System.Guid> LocationID { get; set; }

    public Nullable<System.DateTime> InstallationDate { get; set; }

    public Nullable<System.DateTime> DisposalDate { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AssetAttibute> AssetAttibutes { get; set; }

    public virtual AssetGroup AssetGroup { get; set; }

    public virtual Location Location { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Component> Components { get; set; }

}

}
