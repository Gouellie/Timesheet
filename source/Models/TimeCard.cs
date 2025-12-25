using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Models
{
    public class TimeCard : ObservableObject
    {
        public DateOnly StartDate { get; }
    }
}
