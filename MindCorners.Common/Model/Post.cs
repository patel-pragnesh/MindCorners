//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MindCorners.Common.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.Posts1 = new HashSet<Post>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> ParentId { get; set; }
        public string Title { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<System.Guid> CircleId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.Guid CreatorId { get; set; }
        public System.Guid ModifierId { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public Nullable<System.Guid> LastUpdatedUserId { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<int> LastAttachmentType { get; set; }
        public Nullable<System.Guid> LastAttachmentId { get; set; }
        public bool HasReplies { get; set; }
    
        public virtual Circle Circle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts1 { get; set; }
        public virtual Post Post1 { get; set; }
    }
}