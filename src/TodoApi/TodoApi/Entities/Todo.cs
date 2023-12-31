﻿using System.ComponentModel.DataAnnotations;

namespace TodoApi.Entities
{
	public class Todo
	{
		[Key]
		public int Id { get; set; }

		public string? Title { get; set; }

		public bool isChecked { get; set; }
	}
}
