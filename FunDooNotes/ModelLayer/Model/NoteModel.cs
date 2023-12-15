using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer.Model
{
    public class NoteModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Remainder { get; set; }
        public string Colors { get; set; }
        public string image { get; set; }

        public bool IsArchive { get; set; }
        public bool IsPin { get; set; }
        public bool IsTrash { get; set; }
        


    }
}
