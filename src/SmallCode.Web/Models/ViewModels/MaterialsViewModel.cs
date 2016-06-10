﻿using SmallCode.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallCode.Web.Models.ViewModels
{
    public class MaterialsViewModel : BaseViewModel
    {

        public string Title { set; get; }

        public string Description { set; get; }

        public string Summary { set; get; }

        public MaterialsType MaterialsType { set; get; }

        public Guid CategoryId { set; get; }

        public string Category { set; get; }

        public string Source { set; get; }

        public int Browses { set; get; }

        public SourceType SourceType { set; get; }

        public MaterialsViewModel() { }

        public MaterialsViewModel(Materials model)
        {
            this.Summary = model.Description.SubString(100, "......");
            this.Description = model.Description;
            this.CategoryId = model.CategoryId;
            this.MaterialsType = model.MaterialsType;
            this.Source = model.Source;
            this.SourceType = model.SourceType;
            this.Browses = model.Browses;
        }

    }
}