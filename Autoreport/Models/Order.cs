﻿using Autoreport.Models.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Autoreport.Models
{
    [TypeConverter(typeof(ExpectationResultConverter<OrderStatus>))]
    public enum OrderStatus
    {
        [Description("В процессе")]
        Proceed = 0,
        [Description("Просрочен")]
        Expired = 1,
        [Description("Завершен")]
        Completed = 2
    }

    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required, DisplayName("Стоимость"), Range(1.0, 100000.0)]
        public double Cost { get; set; }

        [Required, DisplayName("Дата заказа")]
        public DateTime Order_date { get; set; }

        [Required, DisplayName("Дата возврата")]
        public DateTime Return_date { get; set; }

        [Required, DisplayName("Статус")]
        public OrderStatus Status { get; set; }

        [Required, DisplayName("Клиент")]
        public virtual Client OrderClient { get; set; }

        [Required, DisplayName("Сотрудник")]
        public virtual Employee OrderEmployeer { get; set; }

        [Required, DisplayName("Залог")]
        public virtual Deposit OrderDeposit { get; set; }

        [Required] // DisplayName("Диски")
        public virtual List<Disk> Disks { get; set; }
    }
}
