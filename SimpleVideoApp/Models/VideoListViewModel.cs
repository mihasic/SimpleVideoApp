using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SimpleVideoApp.Models
{
    public class VideoListViewModel
    {
        private static readonly string[] Videos =
        {
            "coronal_loops_anyone.mp4",
            "coronal_loops_towering_over_big_active_region.mp4"
        };

        public string Selected { get; set; }

        public IEnumerable<SelectListItem> Items
        {
            get
            {
                return Videos.Select(x => new SelectListItem
                {
                    Text = x.Split('.').First().Replace("_", " "),
                    Value = x,
                    Selected = x.Equals(Selected, StringComparison.OrdinalIgnoreCase)
                });
            }
        }

        public string Url
        {
            get { return "/Content/Video/" + Selected; }
        }

        public bool HasSelectedVideo
        {
            get { return Items.Any(x => x.Selected); }
        }
    }
}