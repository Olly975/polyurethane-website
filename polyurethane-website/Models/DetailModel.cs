﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Polyurethane.Data.Models;

namespace polyurethane_website.Models
{
    public class DetailModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public List<ImageModel> Images { get; set; }  = new List<ImageModel>();
        public List<DetailParamModel> Params { get; set; }  = new List<DetailParamModel>();
    }
}