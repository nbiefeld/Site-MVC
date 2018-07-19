//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PHStudios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Resource
    {
        public Resource()
        {
            this.GameResources = new HashSet<GameResource>();
            this.SeriesResources = new HashSet<SeriesResource>();
            this.VideoResources = new HashSet<VideoResource>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual ICollection<GameResource> GameResources { get; set; }
        public virtual ICollection<SeriesResource> SeriesResources { get; set; }
        public virtual ICollection<VideoResource> VideoResources { get; set; }
    }
}
