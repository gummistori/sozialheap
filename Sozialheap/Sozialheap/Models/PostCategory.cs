//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sozialheap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostCategory
    {
        public PostCategory()
        {
            this.Posts = new HashSet<Post>();
        }
    
        public int categoryID { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Post> Posts { get; set; }
    }
}
