﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class program_phstudiosEntities : DbContext
    {
        public program_phstudiosEntities()
            : base("name=program_phstudiosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<FlowplayerResource> FlowplayerResources { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameFeature> GameFeatures { get; set; }
        public virtual DbSet<GameResource> GameResources { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectFeature> ProjectFeatures { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<SeriesResource> SeriesResources { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<VideoResource> VideoResources { get; set; }
        public virtual DbSet<LatestProject> LatestProjects { get; set; }
        public virtual DbSet<LatestVideo> LatestVideos { get; set; }
    }
}
