namespace App.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatItems
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string description { get; set; }

        public string DateAdd { get; set; }

        public string DateUpdate { get; set; }

      

       

        public virtual Users UserAdd { get; set; }

        public virtual Users UserUpdate{ get; set; }

    }
}
