﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace RepositoryLayer.Entity
{
    public class LabelEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LabelId { get; set; }
        public string LabelName { get; set; }

        [ForeignKey("UserId")]
        public int Id { get; set; }
        [JsonIgnore]

        public virtual UsersEntity UserId { get; set; }


        [ForeignKey("NotesId")]
        public long NoteId { get; set; }
        [JsonIgnore]
        public virtual NotesEntity NotesId { get; set; }

    }
}
