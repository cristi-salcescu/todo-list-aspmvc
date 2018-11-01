using Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Front.Models
{
    [DataContract]
    public class IndexModel
    {
        [DataMember]
        public List<TodoDto> Todos { get; set; }
    }
}