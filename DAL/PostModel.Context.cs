﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class POSTDATAEntities : DbContext
    {
        public POSTDATAEntities()
            : base("name=POSTDATAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FavLogoTitle> FavLogoTitles { get; set; }
        public DbSet<Log_Table> Log_Table { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<ProcessType> ProcessTypes { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<T_User> T_User { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}