using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Comment
    {
        public string CommentContent { get; set; }
        public DateTime DateOfComment { get; set; }

        public Comment() { }
        public Comment(string content, DateTime date)
        {
            CommentContent = content;
            DateOfComment = date;

        }
    }
}
