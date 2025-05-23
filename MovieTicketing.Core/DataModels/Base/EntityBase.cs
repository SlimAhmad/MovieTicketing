﻿using System.ComponentModel.DataAnnotations;

namespace MovieTicketing.Core
{
    public abstract class EntityBase
    {

        /// <summary>
        /// The id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The current concurrent time stamp
        /// </summary>
        [Timestamp]
        public byte[] TimeStamp { get; set; }

    }
}
