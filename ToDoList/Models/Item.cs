using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.JoinEntities = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CategoryItem> JoinEntities { get;}

        [Display(Name="Item Completed")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public bool ItemCompleted { get; set; }
        public DateTime DueDate { get; set; }

    }
}
