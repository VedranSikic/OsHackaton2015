﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.Field
{
	public class Project
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual GeneralUser User { get; set; }
		public List<ProjectFOI> FoiList { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		
	}
}