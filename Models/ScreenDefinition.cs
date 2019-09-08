using System;
using System.Collections.Generic;

namespace Aquila.Models
{
    public class ListScreen
    {
        public string Name {get; set;}

        public Guid Id {get; set;}
        public List<Field> Filters {get; set;}

        public List<Field> Results {get; set;}

        public ListScreen()
        {
            Filters = new List<Field>();
            Results = new List<Field>();
        }

    }

    
    public class Field
    {
        public string Name {get; set;}

        public string Type {get; set;}
    }

    public sealed class Types
    {
        public static readonly string Text = "TEXT";
        public static readonly string Date = "DATE";

        public static readonly string Integer = "INTEGER";

        public static readonly string Float = "FLOAT";
    }
}