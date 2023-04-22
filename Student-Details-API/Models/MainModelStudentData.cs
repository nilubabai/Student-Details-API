using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Details_API.Models
{
    public class MainModelStudentData
    {
        [JsonProperty("students")]
        public IList<Students> Students { get; set; }
    }
}