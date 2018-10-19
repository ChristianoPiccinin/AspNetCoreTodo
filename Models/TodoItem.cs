using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    /*  This class defines what the database will need to store for each to-do
        item: an ID, a title or name, whether the item is complete, and what the
        due date is. Each line defines a property of the class:
     */
    public class TodoItem
    {
        public Guid id {get;set;}
        /*The Id property is a guid, or a globally unique identifier. Guids (or
        GUIDs) are long strings of letters and numbers, like 43ec09f2-7f70-
        4f4b-9559-65011d5781bb .
         */

        public bool IsDone{get;set;}
        /*  The IsDone property is a boolean (true/false value). */

        [Required]
        public string Title{get; set;}
        /*The Title property is a string (text value). */

        public DateTimeOffset? DueAt {get;set;}
        /*The DueAt property is a DateTimeOffset , which is a C# type that
        stores a date/time stamp along with a timezone offset from UTC. */
    }

    
}