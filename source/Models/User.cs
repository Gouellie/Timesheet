using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Models
{
    public class User : ObservableObject
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
