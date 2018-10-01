using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameShopNew.Models
{
    public enum ItemCategory { Health, Stamina, Magic }
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public ItemCategory Category { get; set; }

        [DataType("decimal(18,2)")]
        public double Cost { get; set; }
        public string IconURL { get; set; }



        [MaxLength(50)]
        public string Name { get; set; }


    }
}