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
        ItemCategory Category;

        [DataType("decimal(18,2)")]
        double Cost;
        string IconURL;

        [Required]
        int ID;

        [MaxLength(50)]
        string Name;

        
    }
}