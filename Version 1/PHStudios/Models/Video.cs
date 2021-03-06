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
    
    public partial class Video
    {
        public Video()
        {
            this.VideoResources = new HashSet<VideoResource>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Series_ID { get; set; }
        public short Length { get; set; }
        public Nullable<long> Size { get; set; }
        public long Order { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public string YouTube_ID { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual Series Series { get; set; }
        public virtual ICollection<VideoResource> VideoResources { get; set; }
    }
}
