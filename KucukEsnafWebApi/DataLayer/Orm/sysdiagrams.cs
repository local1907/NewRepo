using DataLayer.Orm.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Orm
{
    [Table("sysdiagrams")]
    public class sysdiagrams 
    {
        [MaxLength(128)]
        [Required(ErrorMessage = "name is required")]
        public string name { get; set; }
        [Required(ErrorMessage = "principal id is required")]
        public int principal_id { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "diagram id is required")]
        public int diagram_id { get; set; }
        public int? version { get; set; }
        [MaxLength]
        public byte[] definition { get; set; }
    }

}
