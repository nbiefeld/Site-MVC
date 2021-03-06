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
    
    public partial class Game
    {
        public Game()
        {
            this.GameFeatures = new HashSet<GameFeature>();
            this.GameResources = new HashSet<GameResource>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public Nullable<int> FlowplayerResource_ID { get; set; }
        public bool InDevelopment { get; set; }
    
        public virtual FlowplayerResource FlowplayerResource { get; set; }
        public virtual ICollection<GameFeature> GameFeatures { get; set; }
        public virtual ICollection<GameResource> GameResources { get; set; }
    }
}
