using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Robot : IIdentifiable,IModelable
    {
        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public string Id { get; set; }

        public string Model { get; set; }
    }
}
