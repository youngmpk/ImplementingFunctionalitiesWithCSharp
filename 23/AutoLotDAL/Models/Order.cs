﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL.Models
{
    public partial class Order
    {
        //This property value is generated by DB under the rule of Identity.
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        public int CustId { get; set; }

        [Required]
        public int CarId { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        //Set CustId is a property for backing field for Customer navigaion property.
        //which means that CustId is a FK in Order table, and this FK is related to Customer table.
        [ForeignKey("CustId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("CarId")]
        public virtual Inventory Car { get; set; }
    }
}