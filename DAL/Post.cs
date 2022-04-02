//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
            this.PostImages = new HashSet<PostImage>();
            this.PostTags = new HashSet<PostTag>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string PostContent { get; set; }
        public int CategoryID { get; set; }
        public int ViewCount { get; set; }
        public string SeoLink { get; set; }
        public bool Slider { get; set; }
        public bool Area1 { get; set; }
        public bool Area2 { get; set; }
        public bool Area3 { get; set; }
        public bool Notification { get; set; }
        public string LanguageName { get; set; }
        public System.DateTime AddDate { get; set; }
        public int AddUserID { get; set; }
        public bool isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public int LastUpdateUserID { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual T_User T_User { get; set; }
        public virtual ICollection<PostImage> PostImages { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
