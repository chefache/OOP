﻿namespace WildFarm.Models.Foods
{
    public abstract class Food
    {
		private int quantity;

		protected Food(int quantity)
		{
			this.Quantity = quantity;
		}

		public int Quantity
		{
			get => quantity;

			set 
			{ 
				quantity = value; 
			}
		}
	}
}
