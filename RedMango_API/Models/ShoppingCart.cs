﻿using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedMango_API.Models
{
	public class ShopingCart
	{
		public int Id { get; set; }
		public string UserId { get; set; }
		public ICollection<CartItem>CartItems { get; set; }
		[NotMapped]
		public double CartTotal { get; set; }
        [NotMapped]
        public string StripePaymentIntentId { get; set; }
        [NotMapped]
        public string ClientSecret { get; set; }
	}
	
}

