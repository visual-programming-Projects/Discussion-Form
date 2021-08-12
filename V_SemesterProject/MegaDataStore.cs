using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_SemesterProject
{
    class MegaDataStore
    {
        public string Topic_ID { get; set; }
        public string Topic_name { get; set; }
        public string Topic_author { get; set; }
        public string Description { get; set; }
        public List<CommentStorage> comment { get; set; }
        public MegaDataStore(string Topic_ID, string Topic_name, string Topic_author, string Description, List<CommentStorage> comment)
        {
            this.comment = comment;
            this.Description = Description;
            this.Topic_author = Topic_author;
            this.Topic_ID = Topic_ID;
            this.Topic_name = Topic_name;
        }
        public override string ToString()
        {
            return Topic_name;
        }
    }
}
